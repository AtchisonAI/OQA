using Syncfusion.Windows.Forms;
using OQA_Core;
using System;
using System.Windows.Forms;
using System.Drawing;
using WCFModels.OQA;
using System.Collections.Generic;
using WCFModels.Message;


namespace OQAMain
{
    public partial class FrmAOIInput : OQABaseForm
    {
        #region Variable Definition 
        private string lotId = "";
        private string sideType = "";
        private string slotId = "";
        private string waferId = "";
        private decimal num = 0;
        private ISPIMGDEF imgInfo = new ISPIMGDEF();
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
            lotId = "ITM0142.02";
            slotId = "022";
            sideType = "F";
            waferId = "ITM0142.09";
            if (sideType.Equals(SideType.Front))
            {
                radioButtonF.Checked = true;
            }
            else
            {
                radioButtonB.Checked = true;
            }
            waferSurF.codeBox = this.defectTextBox;
            this.pageInfoShow();
        }
        
        public FrmAOIInput(string lotIdIn,string slotIdIn,string sideTypeIn)
        {
            InitializeComponent();
            lotId = lotIdIn;
            slotId = slotIdIn;
            sideType = sideTypeIn;
        }
        #endregion

        #region  Button or ValueChange Function 

        //数据保存按钮
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                //检查数据
                //  if (CheckCondition("CREATE") == false) return;
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
            if (radioButtonB.Checked)
            {
                sideType = SideType.Back;
            }
            else
            {
                sideType = SideType.Front;
            }

            slotId = "";
            slotComboBox.Items.Clear();
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
            if (MagnificationTextBox.Text.Length > 6)
            {
                MagnificationTextBox.Text = "";
            }
        }
        //qty文本框TextChanged
        private void qtyTextBox_TextChanged(object sender, EventArgs e)
        {
            string result = "0";
            queryLotInfo();
            if (null != qtyTextBox.Text && !("").Equals(qtyTextBox.Text))//判断TextBox的内容不为空，如果不判断会导致后面的非数字对比异常
            {
                if (num != 0)
                {
                    float rate = (float)(int.Parse(qtyTextBox.Text)) / (float)num * 100;
                    result = Math.Round(rate, 2).ToString();
                }
            }
            rateTextBox.Text = result;
        }
        //qty文本框输入控制
        private void qtyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComFunc.CheckKeyPress(sender, e);
            if (qtyTextBox.Text.Length > 6)
            {
                qtyTextBox.Text = "";
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
                if (sideType.Equals(SideType.Front))
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
                            if (!slotComboBox.Items.Contains(child.SlotId))
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
                if (!("").Equals(slotId))
                {
                    if (null != qryResult.model)
                    {
                        if (null != qryResult.model.ISPWAFITM_list && qryResult.model.ISPWAFITM_list.Count > 0)
                        {
                            decRichTextBox.Text = qryResult.model.ISPWAFITM_list[0].DefectDesc;
                            cmtRichTextBox.Text = qryResult.model.ISPWAFITM_list[0].Cmt;
                            ReviewTextBox.Text = qryResult.model.ISPWAFITM_list[0].ReviewUser;
                            MagnificationTextBox.Text = qryResult.model.ISPWAFITM_list[0].Magnification;
                            qtyTextBox.Text = qryResult.model.ISPWAFITM_list[0].DieQty.ToString();
                            rateTextBox.Text = qryResult.model.ISPWAFITM_list[0].DefectRate.ToString();
                            waferId = qryResult.model.ISPWAFITM_list[0].WaferId;
                            //slotId = qryResult.model.ISPWAFITM_list[0].SlotId;
                            //slotComboBox.Text = slotId;

                        }
                        else
                        {
                            ComFunc.ClearBoxValue(groupBox3);
                            imgInfo = null;
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
                            imgInfo = null;
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
                        imgInfo = null;
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

                if (string.IsNullOrWhiteSpace(slotComboBox.Text) || string.IsNullOrWhiteSpace(lotTextBox.Text))
                {
                    MessageBox.Show("请先选择lotId、slotId");
                    return;
                }
                iSPWAFITM.LotId = lotId;
                iSPWAFITM.SlotId = slotComboBox.Text;
                iSPWAFITM.WaferId = waferId;//mock
                iSPWAFITM.InspectType = InspectType.AOI;
                iSPWAFITM.SideType = sideType;
                iSPWAFITM.Magnification = MagnificationTextBox.Text;
                if (String.IsNullOrWhiteSpace(qtyTextBox.Text))
                {
                    qtyTextBox.Text = "0";
                }
                iSPWAFITM.DieQty = decimal.Parse(rateTextBox.Text);
                if (String.IsNullOrWhiteSpace(rateTextBox.Text))
                {
                    rateTextBox.Text = "0";
                }
                iSPWAFITM.DefectRate = decimal.Parse(rateTextBox.Text);
                iSPWAFITM.ReviewUser = ReviewTextBox.Text;
                iSPWAFITM.DefectDesc = decRichTextBox.Text;
                iSPWAFITM.Cmt = cmtRichTextBox.Text;
                iSPWAFITM.IsInspect = "Y";
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
                            iSPWAFDFT.InspectType = InspectType.AOI;
                            iSPWAFDFT.DefectCode = defect;
                            iSPWAFDFT.AreaId = i + 1;
                            sftList.Add(iSPWAFDFT);
                        }
                    }
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



    }
}