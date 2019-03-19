﻿using Syncfusion.Windows.Forms;
using OQA_Core;
using System;
using System.Windows.Forms;
using System.Drawing;
using WCFModels.OQA;
using System.Collections.Generic;
using WCFModels.Message;
using OQA_Core.Controls;

namespace OQAMain
{
    public partial class FrmMarcoInput : OQABaseForm
    {
        #region Variable Definition 
        private string lotId = "";
        private string sideType = "";
        private string slotId = "";
        private string waferId = "";
        private bool jumpFlag = false;//页面跳转
        private ISPIMGDEF imgInfo = new ISPIMGDEF();
        #endregion

        #region  Windows Form auto generated code 
        public FrmMarcoInput()
        {
            InitializeComponent();
        }

        #endregion

        #region Page Load
        private void FrmMarcoInput_Load(object sender, EventArgs e)
        {

            if (sideType.Equals(SideType.Front))
            {
                radioButtonF.Checked = true;
            }
            else
            {
                radioButtonB.Checked = true;
            }
            this.pageInfoShow();
        }

        public FrmMarcoInput(string lotIdIn, string slotIdIn, string sideTypeIn)
        {
            InitializeComponent();
            if (!string.IsNullOrWhiteSpace(lotIdIn) && !string.IsNullOrWhiteSpace(slotIdIn) && !string.IsNullOrWhiteSpace(sideTypeIn))
            {
                lotId = lotIdIn;
                slotId = slotIdIn;
                sideType = sideTypeIn;
                lotTextBox.Text = lotId;
                slotComboBox.Text = slotId;
                jumpFlag = true;
            }
        }
        #endregion

        #region  Button or ValueChange Function 
        //数据保存按钮
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                //检查数据
                // if (CheckCondition("CREATE") == false) return;
                UpdateModelReq<AOIShowView> updateReq = new UpdateModelReq<AOIShowView>();
                this.getUpdateModel(updateReq);
                ModelRsp<AOIShowView> rspInfo = OQASrv.Call.CreateOrUpdateAOI(updateReq);
                refreshPage();
                if (!rspInfo._success)
                {
                    MessageBox.Show(rspInfo._ErrorMsg);
                }
                else
                {
                    MessageBox.Show("保存成功!");
                    lblSucessMsg.Text = rspInfo._MsgCode;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        //提交
        private void btnEdite_Click(object sender, EventArgs e)
        {
            try
            {
                //检查数据
                // if (CheckCondition("CREATE") == false) return;
                UpdateModelReq<AOIShowView> updateReq = new UpdateModelReq<AOIShowView>();
                this.getUpdateModel(updateReq);
                ModelRsp<AOIShowView> rspInfo = OQASrv.Call.CreateOrUpdateAOI(updateReq);
                refreshPage();
                if (!rspInfo._success)
                {
                    MessageBox.Show(rspInfo._ErrorMsg);
                }
                else
                {
                    lblSucessMsg.Text = rspInfo._MsgCode;
                    this.Close();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        //slotId下拉框SelectedIndexChanged
        private void slotComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            slotId = (sender as ComboBox).Text;
            //查询数据
            queryPageInfo(lotId, slotId, sideType);
        }
        //图片保存按钮
        private void imageUpload1_btnUploadClicked(object sender, EventArgs e)
        {
            
            imageUpload1.UpLoadFlag = 3;//by side
            ImageUpload.ImageUpload.BySide item = new ImageUpload.ImageUpload.BySide();
            item.LotID = lotId;
            item.Slot_ID = slotId;
            item.Side_Type = sideType;
            item.Wafer_ID = waferId;
            item.Inspect_Type = InspectType.MA;
            item.ImageType = "Type_M";
            if (null != imgInfo)
            {
                item.TranSeq = imgInfo.TransSeq;
                item.ImageId = imgInfo.ImageId;
            }

            imageUpload1.UpLoadBySide = item;
        }
        //刷新按钮
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshPage();
        }
        //单选框CheckedChanged
        private void radioButtonB_CheckedChanged(object sender, EventArgs e)
        {
            if (jumpFlag && radioButtonB.Checked)
            {
                if (sideType.Equals(SideType.Front))
                {
                    slotId = "";
                    slotComboBox.Items.Clear();
                }
            }
            else
            {
                slotId = "";
                slotComboBox.Items.Clear();
            }
            jumpFlag = false;
            if (radioButtonB.Checked)
            {
                sideType = SideType.Back;
            }
            else
            {
                sideType = SideType.Front;
            }
            pageInfoShow();
        }
        //lotId文本框TextChanged
        private void lotTextBox_TextChanged(object sender, EventArgs e)
        {
            if (null != lotTextBox.Text && !("").Equals(lotTextBox.Text))
            {
                lotId = lotTextBox.Text;
                if (slotComboBox.Items.Count > 0)
                {
                    slotId = "";
                    slotComboBox.Items.Clear();
                }
                pageInfoShow();
            }
            else
            {
                ComFunc.ClearBoxValue(groupBox3);
                waferSurF.clearPanel();
            }
        }
        #endregion

        #region Common Function
        //刷新功能
        private void refreshPage()
        {
            ComFunc.ClearBoxValue(groupBox3);
            waferSurF.clearPanel();
            slotComboBox.Text = slotId;
            queryPageInfo(lotId, slotId, sideType);
        }
        //页面查询及slot下拉框查询
        private void pageInfoShow()
        {
            try
            {
                if (sideType.Equals("F"))
                {
                    frontButton.Text = "Frontside";
                }
                else
                {
                    frontButton.Text = "Backside";
                }
                lotTextBox.Text = lotId;
                slotComboBox.Text = slotId;
                ISPWAFITM ISPWAFITM = new ISPWAFITM();
                ISPWAFITM.LotId = lotId;
                ISPWAFITM.SideType = sideType;
                ISPWAFITM.InspectType = InspectType.MA;
                //查询slot
                ModelRsp<AOIShowView> req = new ModelRsp<AOIShowView>();
                AOIShowView model = new AOIShowView();
                model.ISPWAFITM_list = new List<ISPWAFITM>();
                model.ISPWAFITM_list.Add(ISPWAFITM);
                model.QryAllFlag = false;
                model.C_PROC_STEP = '1';
                model.C_TRAN_FLAG = GlobConst.TRAN_VIEW;
                req.model = model;
                var info = OQASrv.Call.QueryAOIInfo(req);
                //slot 下拉框取值
                if (null != info && null != info.model)
                {
                    if (null != info.model.ISPWAFITM_list && info.model.ISPWAFITM_list.Count > 0)
                    {
                        foreach (ISPWAFITM child in info.model.ISPWAFITM_list)
                        {
                            if (child.SideType.Equals(sideType) && !slotComboBox.Items.Contains(child.SlotId))
                            {
                                slotComboBox.Items.Add(child.SlotId);
                            }
                        }
                    }
                }

                queryPageInfo(lotId, slotId, sideType);


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        //保存/更新数据
        private void getUpdateModel(UpdateModelReq<AOIShowView> updateReq)
        {
            try
            {
                AOIShowView model = new AOIShowView();
                ISPWAFITM iSPWAFITM = new ISPWAFITM();
                List<ISPWAFDFT> sftList = new List<ISPWAFDFT>();
                String[] codeList = new string[25];
                codeList = waferSurF.defectCode;

                //wafer
                if(string.IsNullOrWhiteSpace(slotComboBox.Text)|| string.IsNullOrWhiteSpace(lotTextBox.Text))
                {
                    MessageBox.Show("请先选择lotId、slotId");
                    return;
                }
                iSPWAFITM.LotId = lotId;
                iSPWAFITM.SlotId = slotComboBox.Text.Trim();
                iSPWAFITM.WaferId = waferId;
                iSPWAFITM.InspectType = InspectType.MA;
                iSPWAFITM.SideType = sideType;
                if (!String.IsNullOrWhiteSpace(decRichTextBox.Text))
                {
                    iSPWAFITM.DefectDesc = decRichTextBox.Text.Trim();
                }
                if (!String.IsNullOrWhiteSpace(cmtRichTextBox.Text))
                {
                    iSPWAFITM.Cmt = cmtRichTextBox.Text.Trim();
                }
                iSPWAFITM.InspectPoint = "25";

                for (int i = 0; i < 24; i++)
                {
                    if (null != codeList[i] && !codeList[i].Equals(""))
                    {
                        string[] code = codeList[i].Split(',');
                        foreach (string defect in code)
                        {
                            ISPWAFDFT iSPWAFDFT = new ISPWAFDFT();
                            iSPWAFDFT.LotId = iSPWAFITM.LotId;
                            iSPWAFDFT.SlotId = iSPWAFITM.SlotId;
                            iSPWAFDFT.WaferId = iSPWAFITM.WaferId;
                            iSPWAFDFT.SideType = iSPWAFITM.SideType;
                            iSPWAFDFT.InspectType = InspectType.MA;
                            iSPWAFDFT.DefectCode = defect;
                            iSPWAFDFT.AreaId = i + 1;
                            sftList.Add(iSPWAFDFT);
                        }
                    }
                }
                if (sftList.Count > 0)
                {
                    iSPWAFITM.InspectResult = "N";
                }
                else
                {
                    iSPWAFITM.InspectResult = "Y";
                }
                model.C_PROC_STEP = '1';
                model.C_TRAN_FLAG = GlobConst.TRAN_CREATE;
                model.ISPWAFITM_list = new List<ISPWAFITM>();
                model.ISPWAFITM_list.Add(iSPWAFITM);
                model.ISPWAFDFT_list = sftList;
                updateReq.model = model;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        //页面数据查询
        private void queryPageInfo(string lotId, string slotId, string sideType)
        {
            try
            {
                ISPWAFITM ISPWAFITM = new ISPWAFITM();
                ISPWAFITM.LotId = lotId;
                ISPWAFITM.SlotId = slotId;
                // ISPWAFITM.WaferId = waferId;
                if (null != sideType)
                {
                    ISPWAFITM.SideType = sideType;
                }
                ISPWAFITM.InspectType = InspectType.MA;
                AOIShowView model = new AOIShowView();
                model.ISPWAFITM_list = new List<ISPWAFITM>();
                model.ISPWAFITM_list.Add(ISPWAFITM);
                model.C_PROC_STEP = '1';
                model.QryAllFlag = true;
                model.C_TRAN_FLAG = GlobConst.TRAN_VIEW;
                ModelRsp<AOIShowView> view = new ModelRsp<AOIShowView>();
                view.model = model;
                imgInfo = null;
                ModelRsp<AOIShowView> qryResult = OQASrv.Call.QueryAOIInfo(view);
                if (!("").Equals(slotId))
                {
                    if (null != qryResult.model)
                    {
                        if (null != qryResult.model.ISPWAFITM_list && qryResult.model.ISPWAFITM_list.Count > 0)
                        {
                            decRichTextBox.Text = qryResult.model.ISPWAFITM_list[0].DefectDesc;
                            cmtRichTextBox.Text = qryResult.model.ISPWAFITM_list[0].Cmt;
                            waferId = qryResult.model.ISPWAFITM_list[0].WaferId;
                        }
                        else
                        {
                            ComFunc.ClearBoxValue(groupBox3);
                        }
                        if (null != qryResult.model.ISPIMGDEF_list && qryResult.model.ISPIMGDEF_list.Count > 0)
                        {
                            imgInfo = qryResult.model.ISPIMGDEF_list[0];
                            foreach (Control control in groupBox3.Controls)
                            {
                                if (control is ImageUpload.ImageUpload)
                                {
                                    ImageUpload.ImageUpload img = control as ImageUpload.ImageUpload;
                                    img.InitByImgInstance(imgInfo);
                                }
                            }
                        }
                        else
                        {//清除图片
                            foreach (Control control in groupBox3.Controls)
                            {
                                if (control is ImageUpload.ImageUpload)
                                {
                                    ImageUpload.ImageUpload img = control as ImageUpload.ImageUpload;
                                    img.RefreshContrl();
                                }
                            }
                        }
                        waferSurF.showWafer(qryResult.model.ISPWAFDFT_list);

                    }
                    else
                    {
                        ComFunc.ClearBoxValue(groupBox3);
                    }
                }
                else
                {
                    ComFunc.ClearBoxValue(groupBox3);
                    waferSurF.clearPanel();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        //图片预览
        private void imageUpload1_PreviewLableClicked(object sender, EventArgs e)
        {
            Form newForm = new Form();
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.Size = new System.Drawing.Size(600, 600);
            PictureView pictureView = new PictureView();
            string path = imageUpload1.GetImagePath();
            if (!string.IsNullOrEmpty(path))
            {
                pictureView.LoadImageAsync(ComFunc.GetPicServerPath(path));
            }
            newForm.Controls.Add(pictureView);
            newForm.ShowDialog();
        }

        #endregion
    }
}