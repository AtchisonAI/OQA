using Syncfusion.Windows.Forms;
using OQA_Core;
using System;
using System.Windows.Forms;
using System.Drawing;
using WCFModels.OQA;
using System.Collections.Generic;
using WCFModels.Message;
using OQA_Core.Controls;
using WcfClientCore.Utils.Authority;

namespace OQAMain
{
    public partial class FrmAOIInput : OQABaseForm
    {
        #region Variable Definition 
        private string lotId = "";
        private string slotId = "";
        private string waferId = "";
        private decimal? num = 0;
        private string sideType = SideType.Front;
        private bool jumpFlag = false;//页面跳转
        private ISPIMGDEF imgInfo = new ISPIMGDEF();
        ISPWAFITM wafInfo = new ISPWAFITM();
        #endregion

        #region  Windows Form auto generated code 
        public FrmAOIInput()
        {
            InitializeComponent();
        }

        #endregion

        #region Page Load
        private void FrmAOIInput_Load(object sender, EventArgs e)
        {

            if (sideType.Equals(SideType.Front))
            {
                rbtnF.Checked = true;
            }
            else
            {
                rbtnB.Checked = true;
            }
            waferSurF.codeBox = this.txtDefectCode;
            this.pageInfoShow();
        }

        public FrmAOIInput(string lotIdIn, string slotIdIn, string sideTypeIn)
        {
            InitializeComponent();
            if (!string.IsNullOrWhiteSpace(lotIdIn) && !string.IsNullOrWhiteSpace(slotIdIn) && !string.IsNullOrWhiteSpace(sideTypeIn))
            {
                lotId = lotIdIn;
                slotId = slotIdIn;
                sideType = sideTypeIn;
                txtLotId.Text = lotId;
                cboxSlotId.Text = slotId;
                jumpFlag = true;
                txtLotId.Enabled = false;
                cboxSlotId.Enabled = false;
                rbtnB.Enabled = false;
                rbtnF.Enabled = false;
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
                if (string.IsNullOrWhiteSpace(cboxSlotId.Text) || string.IsNullOrWhiteSpace(txtLotId.Text))
                {
                    MessageBox.Show("请先选择lotId、slotId");
                    return;
                }
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
                    MessageBox.Show("Program Success.");
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
                if (string.IsNullOrWhiteSpace(cboxSlotId.Text) || string.IsNullOrWhiteSpace(txtLotId.Text))
                {
                    MessageBox.Show("请先选择lotId、slotId");
                    return;
                }
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
        //图片保存按钮
        private void imageUpload1_btnUploadClicked(object sender, EventArgs e)
        {
            imageUpload1.UpLoadFlag = 3;//by side
            ImageUpload.ImageUpload.BySide item = new ImageUpload.ImageUpload.BySide();
            item.LotID = lotId;
            item.Slot_ID = slotId;
            item.Side_Type = sideType;
            item.Wafer_ID = waferId;
            item.Inspect_Type = InspectType.AOI;//mock
            item.ImageType = "Type_A";
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
        //side单选框CheckedChanged
        private void radioButtonB_CheckedChanged(object sender, EventArgs e)
        {
           
            if (jumpFlag && rbtnB.Checked)
            {
                if (sideType.Equals(SideType.Front))
                {
                    slotId = "";
                    cboxSlotId.Items.Clear();
                }
            }
            else
            {
                slotId = "";
                cboxSlotId.Items.Clear();
            }
            jumpFlag = false;
            if (rbtnB.Checked)
            {
                sideType = SideType.Back;
            }
            else
            {
                sideType = SideType.Front;
            }
            if (sideType.Equals(SideType.Front))
            {
                btnSide.Text = "Frontside";
            }
            else
            {
                btnSide.Text = "Backside";
            }
            pageInfoShow();
        }
    
        //slotId下拉框SelectedIndexChanged
        private void slotComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            slotId = (sender as ComboBox).Text;
            //查询数据
            queryPageInfo(lotId, slotId, sideType);
        }
        //MagnificationTextBox文本框输入控制
        private void MagnificationTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComFunc.CheckKeyPress(sender, e);
            txtMag.MaxLength = 6;
            if (e.KeyChar == (Char)13)
            {
                if (ComFunc.Trim(txtMag.Text) != "")
                {
                    txtQty.Focus();
                }
            }
        }
        //qty文本框TextChanged
        private void qtyTextBox_TextChanged(object sender, EventArgs e)
        {
            string result = "0";
            queryLotInfo();
            if (!string.IsNullOrWhiteSpace(txtQty.Text))//判断TextBox的内容不为空，如果不判断会导致后面的非数字对比异常
            {
                if (num != 0)
                {
                    float rate = (float)(int.Parse(txtQty.Text)) / (float)num * 100;
                    result = Math.Round(rate, 2).ToString();
                }
            }
            txtRate.Text = result;
        }
        //qty文本框输入控制
        private void qtyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComFunc.CheckKeyPress(sender, e);
            txtQty.MaxLength = 6;
            if (e.KeyChar == (Char)13)
            {
                if (ComFunc.Trim(txtQty.Text) != "")
                {
                    txtReview.Focus();
                }
            }
        }
        //回车光标控制
        private void ReviewTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                if (ComFunc.Trim(txtReview.Text) != "")
                {
                    rtboxDsc.Focus();
                }
            }
        }
        //回车光标控制
        private void decRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                if (ComFunc.Trim(rtboxDsc.Text) != "")
                {
                    rtboxcmt.Focus();
                }
            }
        }

        private void txtLotId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (null != txtLotId.Text && !("").Equals(txtLotId.Text))
                {
                    lotId = txtLotId.Text;
                    if (cboxSlotId.Items.Count > 0)
                    {
                        slotId = "";
                        cboxSlotId.Items.Clear();
                    }
                    pageInfoShow();
                }
                else
                {
                    ComFunc.ClearBoxValue(groupBox3);
                    waferSurF.clearPanel();
                }
            }

        }
        //回车光标控制
        private void cmtRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

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

        #region Common Function
        //刷新功能
        private void refreshPage()
        {
            ComFunc.ClearBoxValue(groupBox3);
            waferSurF.clearPanel();
            cboxSlotId.Text = slotId;
            queryPageInfo(lotId, slotId, sideType);
        }
        //页面查询及slot下拉框查询
        private void pageInfoShow()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(lotId))
                {
                    return;
                }
                if (sideType.Equals(SideType.Front))
                {
                    btnSide.Text = "Frontside";
                }
                else
                {
                    btnSide.Text = "Backside";
                }
                txtLotId.Text = lotId;
                cboxSlotId.Text = slotId;
                ISPWAFITM ISPWAFITM = new ISPWAFITM();
                ISPWAFITM.LotId = lotId;
                ISPWAFITM.SideType = sideType;
                ISPWAFITM.InspectType = InspectType.AOI;
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
                            if (!cboxSlotId.Items.Contains(ComFunc.Trim(child.SlotId)))
                            {
                                cboxSlotId.Items.Add(ComFunc.Trim(child.SlotId));
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
        //页面数据查询
        private void queryPageInfo(string lotId, string slotId, string sideType)
        {
            try
            {
                ISPWAFITM ISPWAFITM = new ISPWAFITM();
                ISPWAFITM.LotId = lotId;
                ISPWAFITM.SlotId = slotId;
                //  ISPWAFITM.WaferId = waferId;
                ISPWAFITM.SideType = sideType;
                ISPWAFITM.InspectType = InspectType.AOI;
                AOIShowView model = new AOIShowView();
                model.ISPWAFITM_list = new List<ISPWAFITM>();
                model.ISPWAFITM_list.Add(ISPWAFITM);
                model.C_PROC_STEP = '1';
                model.QryAllFlag = true;
                model.C_TRAN_FLAG = GlobConst.TRAN_VIEW;
                ModelRsp<AOIShowView> view = new ModelRsp<AOIShowView>();
                view.model = model;
                ModelRsp<AOIShowView> qryResult = OQASrv.Call.QueryAOIInfo(view);
                imgInfo = null;
                if (!("").Equals(slotId))
                {
                    if (null != qryResult.model)
                    {
                        if (null != qryResult.model.ISPWAFITM_list && qryResult.model.ISPWAFITM_list.Count > 0)
                        {
                            wafInfo = qryResult.model.ISPWAFITM_list[0];
                            rtboxDsc.Text = ComFunc.Trim(qryResult.model.ISPWAFITM_list[0].DefectDesc);
                            rtboxcmt.Text = ComFunc.Trim(qryResult.model.ISPWAFITM_list[0].Cmt);
                            txtReview.Text = ComFunc.Trim(qryResult.model.ISPWAFITM_list[0].ReviewUser);
                            txtMag.Text = ComFunc.Trim(qryResult.model.ISPWAFITM_list[0].Magnification);
                            txtQty.Text = ComFunc.Trim(qryResult.model.ISPWAFITM_list[0].DieQty.ToString());
                            txtRate.Text = ComFunc.Trim(qryResult.model.ISPWAFITM_list[0].DefectRate.ToString());
                            waferId = ComFunc.Trim(qryResult.model.ISPWAFITM_list[0].WaferId);
                            //slotId = qryResult.model.ISPWAFITM_list[0].SlotId;
                            //slotComboBox.Text = slotId;

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
                        waferSurF.clearPanel();
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

               
                wafInfo.UpdateUserId = AuthorityControl.GetUserProfile().userId;
                wafInfo.Magnification = ComFunc.Trim(txtMag.Text);
                if (String.IsNullOrWhiteSpace(txtQty.Text))
                {
                    txtQty.Text = "0";
                }
                wafInfo.DieQty = decimal.Parse(txtQty.Text);
                if (String.IsNullOrWhiteSpace(txtRate.Text))
                {
                    txtRate.Text = "0";
                }
                wafInfo.DefectRate = decimal.Parse(txtRate.Text);
                wafInfo.ReviewUser = ComFunc.Trim(txtReview.Text);
                wafInfo.DefectDesc = ComFunc.Trim(rtboxDsc.Text);
                wafInfo.Cmt = ComFunc.Trim(rtboxcmt.Text);
                wafInfo.InspectPoint = "25";

                for (int i = 0; i < 24; i++)
                {
                    if (null != codeList[i] && !codeList[i].Equals(""))
                    {
                        string[] code = codeList[i].Split(',');
                        foreach (string defect in code)
                        {
                            ISPWAFDFT iSPWAFDFT = new ISPWAFDFT();
                            iSPWAFDFT.LotId = wafInfo.LotId;
                            iSPWAFDFT.SlotId = wafInfo.SlotId;
                            iSPWAFDFT.WaferId = wafInfo.WaferId;
                            iSPWAFDFT.SideType = wafInfo.SideType;
                            iSPWAFDFT.InspectType = InspectType.AOI;
                            iSPWAFDFT.DefectCode = defect;
                            iSPWAFDFT.AreaId = i + 1;
                            iSPWAFDFT.CreateUserId = AuthorityControl.GetUserProfile().userId;
                            sftList.Add(iSPWAFDFT);
                        }
                    }
                }
                if (sftList.Count > 0)
                {
                    wafInfo.InspectResult = "N";
                }
                else
                {
                    wafInfo.InspectResult = "Y";
                }
                model.C_PROC_STEP = '1';
                model.C_TRAN_FLAG = GlobConst.TRAN_CREATE;
                model.ISPWAFITM_list = new List<ISPWAFITM>();
                model.ISPWAFITM_list.Add(wafInfo);
                model.ISPWAFDFT_list = sftList;
                updateReq.model = model;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        //查询批数量（计算rate的分母）
        private void queryLotInfo()
        {
            ModelRsp<LotstsInfoView> view = new ModelRsp<LotstsInfoView>();
            LotstsInfoView model = new LotstsInfoView();
            ISPLOTSTS ISPLOTSTS = new ISPLOTSTS();
            ISPLOTSTS.LotId = lotId;
            ISPLOTSTS.Status = "Create";
            model.C_PROC_STEP = '1';
            model.C_TRAN_FLAG = GlobConst.TRAN_VIEW;
            model.ISPLOTSTS = ISPLOTSTS;
            view.model = model;
            ModelRsp<LotstsInfoView> qryResult = OQASrv.Call.QuerySlotstsInfo(view);
            if (null != qryResult.model)
            {
                if (null != qryResult.model.ISPLOTSTS)
                {
                    num = qryResult.model.ISPLOTSTS.ProductDieQty;
                }
            }
        }



        #endregion

        private void txtLotId_MouseDown(object sender, MouseEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lotId))
            {
                ComFunc.ClearBoxValue(groupBox3);
                waferSurF.clearPanel();
                txtLotId.Clear();
                cboxSlotId.Items.Clear();
                cboxSlotId.Text = "";
                lotId = "";
                slotId = "";
                waferId = "";
            } 
    }
    }
}