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
        #region " Windows Form auto generated code "
        public FrmAOIInput()
        {
            InitializeComponent();
        }

        #endregion


        #region " Constant Definition "
        //private bool b_load_flag = false;

        #endregion


        #region " Variable Definition "
        private string lotId = "";
        private string sideType = "";
        #endregion


        #region " Function Definition "
     
        
        private void button1_Click(object sender, EventArgs e)
        {
            waferSurF.clearPanel();
        }

        #region " 事务前数据检查 "
        private bool CheckCondition(string FuncName)
        {

            switch (ComFunc.Trim(FuncName))
            {
                case "CREATE":
                    return true;
                    break;

                case "UPDATE":
                    // TODO

                    break;
                case "DELETE":
                    // TODO
                    break;

            }

            return true;

        }

        #endregion

        #region "控件初始化 "        
        private void ClearData(string ProcStep)
        {

            try
            {
                switch (ProcStep)
                {
                    case "1":
                        //Initialize
                        ComFunc.FieldClear(this);
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
        #endregion


        #endregion



        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                //检查数据
              //  if (CheckCondition("CREATE") == false) return;
                UpdateModelReq<AOIShowView> updateReq = new UpdateModelReq<AOIShowView>();
                this.getUpdateModel(updateReq);
                ModelRsp<AOIShowView> rspInfo = OQASrv.Call.CreateOrUpdateAOI(updateReq);
                if (!rspInfo._success)
                {
                    MessageBox.Show(rspInfo._ErrorMsg);
                }
                else
                {
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        private void FrmAOIInput_Load(object sender, EventArgs e)
        {
            waferSurF.box = this.defectTextBox;
            this.pageInfoShow();
        }

        #region show function
        private void pageInfoShow()
        {
             lotId = "1";
            string slotId = "1";
             sideType = "F";

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
                            if (child.SideType.Equals(sideType)&& !slotComboBox.Items.Contains(child.SlotId))
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

        private void getUpdateModel(UpdateModelReq<AOIShowView> updateReq)
        {
            try
            {
                AOIShowView model = new AOIShowView();
                ISPWAFITM iSPWAFITM = new ISPWAFITM();
                ISPIMGDEF iSPIMGDEF = new ISPIMGDEF();
                List<ISPWAFDFT> sftList = new List<ISPWAFDFT>();
                List<ISPIMGDEF> imgList = new List<ISPIMGDEF>();
                String[] codeList = new string[25];
                codeList = waferSurF.defectCode;
              
                //wafer
                iSPWAFITM.LotId = lotId;
                iSPWAFITM.SlotId = slotComboBox.Text;
                iSPWAFITM.WaferId = "1";//mock
                iSPWAFITM.InspectType = "A";
                iSPWAFITM.SideType = sideType;
                iSPWAFITM.Magnification = MagnificationTextBox.Text;
                iSPWAFITM.DieQty = int.Parse(qtyTextBox.Text);
                iSPWAFITM.DefectRate = int.Parse(rateTextBox.Text);
                iSPWAFITM.ReviewUser = ReviewTextBox.Text;
                iSPWAFITM.DefectDesc = decRichTextBox.Text;
                iSPWAFITM.Cmt = cmtRichTextBox.Text;
                iSPWAFITM.IsInspect = "Y";
                //img
                //iSPIMGDEF.SlotId = iSPWAFITM.SlotId;
                //iSPIMGDEF.LotId = iSPWAFITM.LotId;
                //iSPIMGDEF.WaferId = iSPWAFITM.WaferId;
                //iSPIMGDEF.SideType = iSPWAFITM.SideType;
                //iSPIMGDEF.InspectType = iSPWAFITM.InspectType;
                //iSPIMGDEF.TransSeq = 2;
                //iSPIMGDEF.AreaId = 0;
                //iSPIMGDEF.ImagePath = imageTextBox.Text;
                //iSPIMGDEF.ImageId = "1";
                //iSPIMGDEF.ImageName = "name";
                //iSPIMGDEF.ImageType = "type";
                //imgList.Add(iSPIMGDEF);
                //dft


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
                            iSPWAFDFT.InspectType = iSPWAFITM.InspectType;
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
                model.ISPIMGDEF_list = imgList;
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
                ISPWAFITM.WaferId = "1";
                if (null != sideType)
                {
                    ISPWAFITM.SideType = sideType;
                }
                ISPWAFITM.InspectType = "A";//Micro Type
                AOIShowView model = new AOIShowView();
                model.ISPWAFITM_list = new List<ISPWAFITM>();
                model.ISPWAFITM_list.Add(ISPWAFITM);
                model.C_PROC_STEP = '1';
                model.QryAllFlag = true;
                model.C_TRAN_FLAG = GlobConst.TRAN_VIEW;
                ModelRsp<AOIShowView> view = new ModelRsp<AOIShowView>();
                view.model = model;
                ModelRsp<AOIShowView> qryResult = OQASrv.Call.QueryAOIInfo(view);
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
                       
                    }
                    else
                    {
                        OQA_Core.ComFunc.ClearBoxValue(groupBox3);
                    }
                    //if (null != qryResult.model.ISPIMGDEF_list && qryResult.model.ISPIMGDEF_list.Count > 0)
                    //{
                    //    //  imageTextBox.Text = qryResult.model.ISPIMGDEF_list[0].ImagePath;//mock value
                    //}

                }
                else
                {
                    OQA_Core.ComFunc.ClearBoxValue(groupBox3);
                }
                
                  waferSurF.showWafer(qryResult.model.ISPWAFDFT_list);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion

        private void slotComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string slotId = (sender as ComboBox).Text;
            //查询数据
            queryPageInfo(lotId, slotId, sideType);
        }

        private void MagnificationTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OQA_Core.ComFunc.CheckKeyPress(sender, e);
        }

    }
}