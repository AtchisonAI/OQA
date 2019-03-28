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
    public partial class FrmMircoInput : OQABaseForm
    {
        #region  Variable Definition 
        private string lotId = "";
        private string slotId = "";
        private string waferId = "";
        private decimal? num = 0;
        private string sideType = SideType.Front;
        private List<ISPIMGDEF> imgInfoList = new List<ISPIMGDEF>();
        ISPWAFITM wafInfo = new ISPWAFITM();
        #endregion

        #region  Windows Form auto generated code 
        public FrmMircoInput()
        {
            InitializeComponent();
        }

        #endregion

        #region Page Load
        private void FrmMircoInput_Load(object sender, EventArgs e)
        {
            rbtnNine.Checked = true;
            checkAllOk();
            waferSurF.nodeMode = true;
            waferSurF.WaferSur_Load(null, null);
            waferSurF.groupNode = this.groupBoxSelect;
            this.pageInfoShow();
        }

        public FrmMircoInput(string lotIdIn, string slotIdIn, string sideTypeIn)
        {
            InitializeComponent();
            if (!string.IsNullOrWhiteSpace(lotIdIn) && !string.IsNullOrWhiteSpace(slotIdIn) && !string.IsNullOrWhiteSpace(sideTypeIn))
            {
                lotId = lotIdIn;
                slotId = slotIdIn;
                sideType = sideTypeIn;
                txtLotId.Text = lotId;
                cboxSlotId.Text = slotId;
                txtLotId.Enabled = false;
                cboxSlotId.Enabled = false;
            }
        }
        #endregion

        #region Button or ValueChange Function 
        //9/13点单选按钮CheckedChanged
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNine.Checked)
            {
                rbtnNine.Checked = true;
                hideNode(false);
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnThir.Checked)
            {
                rbtnThir.Checked = true;
                hideNode(true);
            }
        }
        //保存按钮
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cboxSlotId.Text) || string.IsNullOrWhiteSpace(txtLotId.Text))
                {
                    MessageBox.Show("请先选择lotId、slotId");
                    return;
                }
                UpdateModelReq<AOIShowView> updateReq = new UpdateModelReq<AOIShowView>();
                getUpdateModel(updateReq);
                ModelRsp<AOIShowView> rspInfo = OQASrv.Call.CreateOrUpdateAOI(updateReq);
                refreshPage();
                if (!rspInfo._success)
                {
                    MessageBox.Show(rspInfo._ErrorMsg);
                }
                else
                {
                    lblSucessMsg.Text = rspInfo._MsgCode;
                    MessageBox.Show("保存成功!");
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
                if (string.IsNullOrWhiteSpace(cboxSlotId.Text) || string.IsNullOrWhiteSpace(txtLotId.Text))
                {
                    MessageBox.Show("请先选择lotId、slotId");
                    return;
                }
                UpdateModelReq<AOIShowView> updateReq = new UpdateModelReq<AOIShowView>();
                getUpdateModel(updateReq);
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
        //刷新按钮
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshPage();
        }
        //slotId下拉框SelectedIndexChanged
        private void slotComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            slotId = (sender as ComboBox).Text;
            //查询数据
            queryPageInfo(lotId, slotId, sideType);
        }
        private void txtLotId_MouseDown(object sender, MouseEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lotId))
            {
                ComFunc.ClearBoxValue(groupBox3);
                ComFunc.ClearBoxValue(groupBoxSelect);
                rbtnNine.Checked = true;
                waferSurF.clearPanel();
                txtLotId.Clear();
                cboxSlotId.Items.Clear();
                cboxSlotId.Text = "";
                lotId = "";
                slotId = "";
                waferId = "";
            }
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
        private void decRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                if (ComFunc.Trim(rtboxDsc.Text) != "")
                {
                    rtboxCmt.Focus();
                }
            }
        }
        
        //qty文本框TextChanged
        private void qtyTextBox_TextChanged(object sender, EventArgs e)
        {
            string result = "0";
            queryLotInfo();
            if (null != txtQty.Text && !("").Equals(txtQty.Text))//判断TextBox的内容不为空，如果不判断会导致后面的非数字对比异常
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
                    rtboxDsc.Focus();
                }
            }

        }
        #endregion

        #region Common Function
        //9点模式隐藏3个点
        private void hideNode(Boolean flag)
        {
            label20.Visible = flag;
            okBox_18.Visible = flag;
            ngBox_18.Visible = flag;
            label21.Visible = flag;
            okBox_12.Visible = flag;
            ngBox_12.Visible = flag;
            label22.Visible = flag;
            okBox_8.Visible = flag;
            ngBox_8.Visible = flag;
            label23.Visible = flag;
            okBox_14.Visible = flag;
            ngBox_14.Visible = flag;
            imageUpload_12.Visible = flag;
            imageUpload_8.Visible = flag;
            imageUpload_14.Visible = flag;
            imageUpload_18.Visible = flag;
            waferSurF.panelF_8.Enabled = flag;
            waferSurF.panelF_12.Enabled = flag;
            waferSurF.panelF_14.Enabled = flag;
            waferSurF.panelF_18.Enabled = flag;
        }
        //所有选择框初始化（都为ok）
        public void checkAllOk()
        {
            foreach (Control control in groupBoxSelect.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox c = control as CheckBox;
                    if (control.Name.Split('_')[0].Equals("okBox"))
                    {
                        c.Checked = true;
                    }
                }
            }

        }
        //刷新页面
        private void refreshPage()
        {
            ComFunc.ClearBoxValue(groupBox3);
            ComFunc.ClearBoxValue(groupBoxSelect);
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
                btnSide.Text = "Frontside";
                txtLotId.Text = lotId;
                cboxSlotId.Text = slotId;
                ISPWAFITM ISPWAFITM = new ISPWAFITM();
                ISPWAFITM.LotId = lotId;
                ISPWAFITM.SideType = sideType;
                ISPWAFITM.InspectType = InspectType.MI;
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

                
                
                wafInfo.Magnification = ComFunc.Trim(txtMag.Text);
                wafInfo.UpdateUserId= AuthorityControl.GetUserProfile().userId;
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
                wafInfo.DefectDesc = ComFunc.Trim(rtboxDsc.Text);
                wafInfo.Cmt = ComFunc.Trim(rtboxCmt.Text);
                if (rbtnNine.Checked)
                {
                    wafInfo.InspectPoint = "9";
                }
                else
                {
                    wafInfo.InspectPoint = "13";
                }
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
                            iSPWAFDFT.InspectType = InspectType.MI;
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
        //页面数据查询
        private void queryPageInfo(string lotId, string slotId, string sideType)
        {
            try
            {
                ISPWAFITM ISPWAFITM = new ISPWAFITM();
                ISPWAFITM.LotId = lotId;
                ISPWAFITM.SlotId = slotId;
                //ISPWAFITM.WaferId = waferId;
                ISPWAFITM.SideType = sideType;
                ISPWAFITM.InspectType = InspectType.MI;
                AOIShowView model = new AOIShowView();
                model.ISPWAFITM_list = new List<ISPWAFITM>();
                model.ISPWAFITM_list.Add(ISPWAFITM);
                model.C_PROC_STEP = '1';
                model.QryAllFlag = true;
                model.C_TRAN_FLAG = GlobConst.TRAN_VIEW;
                ModelRsp<AOIShowView> view = new ModelRsp<AOIShowView>();
                view.model = model;
                imgInfoList = null;
                ModelRsp<AOIShowView> qryResult = OQASrv.Call.QueryAOIInfo(view);
                if (!("").Equals(slotId))
                {
                    if (null != qryResult.model)
                    {
                        if (null != qryResult.model.ISPWAFITM_list && qryResult.model.ISPWAFITM_list.Count > 0)
                        {
                            wafInfo = qryResult.model.ISPWAFITM_list[0];
                            rtboxDsc.Text = ComFunc.Trim(qryResult.model.ISPWAFITM_list[0].DefectDesc);
                            rtboxCmt.Text = ComFunc.Trim(qryResult.model.ISPWAFITM_list[0].Cmt);
                            txtMag.Text = ComFunc.Trim(qryResult.model.ISPWAFITM_list[0].Magnification);
                            txtRate.Text = ComFunc.Trim(qryResult.model.ISPWAFITM_list[0].DefectRate.ToString());
                            txtQty.Text = ComFunc.Trim(qryResult.model.ISPWAFITM_list[0].DieQty.ToString());
                            waferId = ComFunc.Trim(qryResult.model.ISPWAFITM_list[0].WaferId);
                            if (ComFunc.Trim(qryResult.model.ISPWAFITM_list[0].InspectPoint).Equals("13"))
                            {
                                rbtnThir.Checked = true;
                            }
                            //slotId = qryResult.model.ISPWAFITM_list[0].SlotId;
                            //slotComboBox.Text = slotId;
                        }
                        else
                        {
                            ComFunc.ClearBoxValue(groupBox3);
                            waferSurF.clearPanel();
                            checkAllOk();
                        }
                        if (null != qryResult.model.ISPIMGDEF_list && qryResult.model.ISPIMGDEF_list.Count > 0)
                        {
                            imgInfoList = qryResult.model.ISPIMGDEF_list;
                            foreach (ISPIMGDEF imgInfo in imgInfoList)
                            {
                                foreach (Control control in groupBoxSelect.Controls)
                                {
                                    if (control is ImageUpload.ImageUpload)
                                    {
                                        if (control.Name.Split('_')[1].Equals((imgInfo.AreaId).ToString()))
                                        {
                                            ImageUpload.ImageUpload img = control as ImageUpload.ImageUpload;
                                            img.InitByImgInstance(imgInfo);
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {//清除图片
                            ComFunc.ClearBoxValue(groupBoxSelect);
                        }
                        waferSurF.showWafer(qryResult.model.ISPWAFDFT_list);
                    }

                }
                else
                {
                    ComFunc.ClearBoxValue(groupBox3);
                    waferSurF.clearPanel();
                    checkAllOk();
                    ComFunc.ClearBoxValue(groupBoxSelect);
                }



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
        //图片上传
        private void uploadCommonFunc(decimal areaId, ImageUpload.ImageUpload.ByArea item)
        {
            //ImageUpload.ImageUpload.ByArea item = new ImageUpload.ImageUpload.ByArea();

            item.LotID = lotId;
            item.Slot_ID = slotId;
            item.Side_Type = sideType;
            item.Wafer_ID = waferId;
            item.Inspect_Type = InspectType.MI;
            item.ImageType = "Type_" + areaId;
            item.Area_ID = areaId;
            if (null != imgInfoList && imgInfoList.Count > 0)
            {
                foreach (ISPIMGDEF img in imgInfoList)
                {
                    if (img.AreaId == item.Area_ID)
                    {
                        item.TranSeq = img.TransSeq;
                        item.ImageId = img.ImageId;

                    }
                }
            }

        }

        #endregion

        #region Upload Picture Click Function
        private void imageUpload_11_btnUploadClicked(object sender, EventArgs e)
        {
            ImageUpload.ImageUpload.ByArea item = new ImageUpload.ImageUpload.ByArea();
            uploadCommonFunc(11, item);
            imageUpload_11.UpLoadFlag = 4;//by area
            imageUpload_11.UpLoadByArea = item;
        }

        private void imageUpload_13_btnUploadClicked(object sender, EventArgs e)
        {
            ImageUpload.ImageUpload.ByArea item = new ImageUpload.ImageUpload.ByArea();
            uploadCommonFunc(13, item);
            imageUpload_13.UpLoadFlag = 4;//by area
            imageUpload_13.UpLoadByArea = item;
        }

        private void imageUpload_15_btnUploadClicked(object sender, EventArgs e)
        {
            ImageUpload.ImageUpload.ByArea item = new ImageUpload.ImageUpload.ByArea();
            uploadCommonFunc(15, item);
            imageUpload_15.UpLoadFlag = 4;//by area
            imageUpload_15.UpLoadByArea = item;
        }

        private void imageUpload_3_btnUploadClicked(object sender, EventArgs e)
        {
            ImageUpload.ImageUpload.ByArea item = new ImageUpload.ImageUpload.ByArea();
            uploadCommonFunc(3, item);
            imageUpload_3.UpLoadFlag = 4;//by area
            imageUpload_3.UpLoadByArea = item;
        }

        private void imageUpload_23_btnUploadClicked(object sender, EventArgs e)
        {
            ImageUpload.ImageUpload.ByArea item = new ImageUpload.ImageUpload.ByArea();
            uploadCommonFunc(23, item);
            imageUpload_23.UpLoadFlag = 4;//by area
            imageUpload_23.UpLoadByArea = item;
        }

        private void imageUpload_17_btnUploadClicked(object sender, EventArgs e)
        {
            ImageUpload.ImageUpload.ByArea item = new ImageUpload.ImageUpload.ByArea();
            uploadCommonFunc(17, item);
            imageUpload_17.UpLoadFlag = 4;//by area
            imageUpload_17.UpLoadByArea = item;
        }

        private void imageUpload_7_btnUploadClicked(object sender, EventArgs e)
        {
            ImageUpload.ImageUpload.ByArea item = new ImageUpload.ImageUpload.ByArea();
            uploadCommonFunc(7, item);
            imageUpload_7.UpLoadFlag = 4;//by area
            imageUpload_7.UpLoadByArea = (item);
        }

        private void imageUpload_9_btnUploadClicked(object sender, EventArgs e)
        {
            ImageUpload.ImageUpload.ByArea item = new ImageUpload.ImageUpload.ByArea();
            uploadCommonFunc(9, item);
            imageUpload_9.UpLoadFlag = 4;//by area
            imageUpload_9.UpLoadByArea = (item);
        }

        private void imageUpload_19_btnUploadClicked(object sender, EventArgs e)
        {
            ImageUpload.ImageUpload.ByArea item = new ImageUpload.ImageUpload.ByArea();
            uploadCommonFunc(19, item);
            imageUpload_19.UpLoadFlag = 4;//by area
            imageUpload_19.UpLoadByArea = (item);
        }

        private void imageUpload_18_btnUploadClicked(object sender, EventArgs e)
        {
            ImageUpload.ImageUpload.ByArea item = new ImageUpload.ImageUpload.ByArea();
            uploadCommonFunc(18, item);
            imageUpload_18.UpLoadFlag = 4;//by area
            imageUpload_18.UpLoadByArea = (item);
        }

        private void imageUpload_12_btnUploadClicked(object sender, EventArgs e)
        {
            ImageUpload.ImageUpload.ByArea item = new ImageUpload.ImageUpload.ByArea();
            uploadCommonFunc(12, item);
            imageUpload_12.UpLoadFlag = 4;//by area
            imageUpload_12.UpLoadByArea = (item);
        }

        private void imageUpload_8_btnUploadClicked(object sender, EventArgs e)
        {
            ImageUpload.ImageUpload.ByArea item = new ImageUpload.ImageUpload.ByArea();
            uploadCommonFunc(8, item);
            imageUpload_8.UpLoadFlag = 4;//by area
            imageUpload_8.UpLoadByArea = (item);
        }

        private void imageUpload_14_btnUploadClicked(object sender, EventArgs e)
        {
            ImageUpload.ImageUpload.ByArea item = new ImageUpload.ImageUpload.ByArea();
            uploadCommonFunc(14, item);
            imageUpload_14.UpLoadFlag = 4;//by area
            imageUpload_14.UpLoadByArea = (item);
        }




        #endregion

        #region PreviewLabelClicked

        private void showPicture(ImageUpload.ImageUpload imageUpload)
        {
            Form newForm = new Form();
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.Size = new System.Drawing.Size(600, 600);
            PictureView pictureView = new PictureView();
            string path = imageUpload.GetImagePath();
            if (!string.IsNullOrEmpty(path))
            {
                pictureView.LoadImageAsync(ComFunc.GetPicServerPath(path));
            }
            newForm.Controls.Add(pictureView);
            newForm.ShowDialog();
        }

        private void imageUpload_11_PreviewLableClicked(object sender, EventArgs e)
        {
            showPicture(imageUpload_11);
        }

        private void imageUpload_13_PreviewLableClicked(object sender, EventArgs e)
        {
            showPicture(imageUpload_13);
        }

        private void imageUpload_15_PreviewLableClicked(object sender, EventArgs e)
        {
            showPicture(imageUpload_15);
        }

        private void imageUpload_3_PreviewLableClicked(object sender, EventArgs e)
        {
            showPicture(imageUpload_3);
        }

        private void imageUpload_23_PreviewLableClicked(object sender, EventArgs e)
        {
            showPicture(imageUpload_23);
        }

        private void imageUpload_17_PreviewLableClicked(object sender, EventArgs e)
        {
            showPicture(imageUpload_17);
        }

        private void imageUpload_7_PreviewLableClicked(object sender, EventArgs e)
        {
            showPicture(imageUpload_7);
        }

        private void imageUpload_9_PreviewLableClicked(object sender, EventArgs e)
        {
            showPicture(imageUpload_9);
        }

        private void imageUpload_19_PreviewLableClicked(object sender, EventArgs e)
        {
            showPicture(imageUpload_19);
        }

        private void imageUpload_18_PreviewLableClicked(object sender, EventArgs e)
        {
            showPicture(imageUpload_18);
        }

        private void imageUpload_12_PreviewLableClicked(object sender, EventArgs e)
        {
            showPicture(imageUpload_12);
        }

        private void imageUpload_8_PreviewLableClicked(object sender, EventArgs e)
        {
            showPicture(imageUpload_8);
        }

        private void imageUpload_14_PreviewLableClicked(object sender, EventArgs e)
        {
            showPicture(imageUpload_14);
        }


        #endregion

       
    }
}