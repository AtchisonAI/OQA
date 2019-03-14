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
    public partial class FrmMircoInput : OQABaseForm
    {
        #region  Variable Definition 
        private string lotId = "";
        private string sideType = "";
        private string slotId = "";
        private string waferId = "";
        private decimal num = 0;
        private List<ISPIMGDEF> imgInfoList = new List<ISPIMGDEF>();
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
            lotId = "ITM0150";
            slotId = "001";
            sideType = "F";
            waferId = "ITM0150.01";
            if (sideType.Equals(SideType.Front))
            {
                radioButtonF.Checked = true;
            }
            else
            {
                radioButtonB.Checked = true;
            }
            radioNine.Checked = true;
            checkAllOk();
            waferSurF.nodeMode = true;
            waferSurF.WaferSur_Load(null, null);
            waferSurF.groupNode = this.groupBoxSelect;
            this.pageInfoShow();
        }
        #endregion

        #region Button or ValueChange Function 
        //9/13点单选按钮CheckedChanged
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioNine.Checked)
            {
                radioNine.Checked = true;
                hideNode(false);
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioThir.Checked)
            {
                radioThir.Checked = true;
                hideNode(true);
            }
        }
        //保存按钮
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
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
        //MagnificationTextBox文本框输入控制
        private void MagnificationTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComFunc.CheckKeyPress(sender, e);
            if (MagnificationTextBox.Text.Length > 6)
            {
                MagnificationTextBox.Text = "";
            }
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
                checkAllOk();
            }
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
        //9点模式隐藏3个点
        private void hideNode(Boolean flag)
        {
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
            imageUpload_12.Visible = flag;
            imageUpload_8.Visible = flag;
            imageUpload_14.Visible = flag;
            waferSurF.panelF_8.Enabled = flag;
            waferSurF.panelF_12.Enabled = flag;
            waferSurF.panelF_14.Enabled = flag;
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

                if (null == slotComboBox.Text || ("").Equals(slotComboBox.Text)
                     && null == lotTextBox.Text || ("").Equals(lotTextBox.Text))
                {
                    MessageBox.Show("请先选择lotId、slotId");
                    return;
                }
                iSPWAFITM.LotId = lotId;
                iSPWAFITM.SlotId = slotComboBox.Text;
                iSPWAFITM.WaferId = waferId;//mock
                iSPWAFITM.InspectType = InspectType.MI;
                iSPWAFITM.SideType = sideType;
                iSPWAFITM.Magnification = MagnificationTextBox.Text;
                iSPWAFITM.DieQty = decimal.Parse(qtyTextBox.Text);
                iSPWAFITM.DefectRate = decimal.Parse(rateTextBox.Text);
                iSPWAFITM.DefectDesc = decRichTextBox.Text;
                iSPWAFITM.Cmt = cmtRichTextBox.Text;
                iSPWAFITM.IsInspect = "Y";
                if (radioNine.Checked)
                {
                    iSPWAFITM.InspectPoint = "9";
                }
                else
                {
                    iSPWAFITM.InspectPoint = "13";
                }
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
                            iSPWAFDFT.InspectType = InspectType.MI;
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
                ModelRsp<AOIShowView> qryResult = OQASrv.Call.QueryAOIInfo(view);
                if (!("").Equals(slotId))
                {
                    if (null != qryResult.model)
                    {
                        if (null != qryResult.model.ISPWAFITM_list && qryResult.model.ISPWAFITM_list.Count > 0)
                        {
                            decRichTextBox.Text = qryResult.model.ISPWAFITM_list[0].DefectDesc;
                            cmtRichTextBox.Text = qryResult.model.ISPWAFITM_list[0].Cmt;
                            MagnificationTextBox.Text = qryResult.model.ISPWAFITM_list[0].Magnification;
                            rateTextBox.Text = qryResult.model.ISPWAFITM_list[0].DefectRate.ToString();
                            qtyTextBox.Text = qryResult.model.ISPWAFITM_list[0].DieQty.ToString();
                            waferId = qryResult.model.ISPWAFITM_list[0].WaferId;
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
                        }
                        waferSurF.showWafer(qryResult.model.ISPWAFDFT_list);
                    }

                }
                else
                {
                    ComFunc.ClearBoxValue(groupBox3);
                    waferSurF.clearPanel();
                    checkAllOk();
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
        private void uploadCommonFunc(decimal araeId, ImageUpload.ImageUpload.ByArea item)
        {
            //ImageUpload.ImageUpload.ByArea item = new ImageUpload.ImageUpload.ByArea();
            item.LotID = lotId;
            item.Slot_ID = slotId;
            item.Side_Type = sideType;
            item.Wafer_ID = "1";
            item.Inspect_Type = "A";//mock
            item.ImageType = "ISP";
            item.Area_ID = araeId;
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
        

      

      
    }
}