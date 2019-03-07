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
        private Boolean frontFlag = true;//正面

        #endregion


        #region " Function Definition "
        private void frontButton_Click(object sender, EventArgs e)
        {
            frontFlag = true;
            this.frontButton.BackColor = Color.Green;
            this.backButton.BackColor = Color.Gray;
            waferSurF.Enabled = true;
            waferSurB.Enabled = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            frontFlag = false;
            this.backButton.BackColor = Color.Green;
            this.frontButton.BackColor = Color.Gray;
            waferSurB.Enabled = true;
            waferSurF.Enabled = false;
        }

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

                    //            if (ComFunc.CheckValue(ComFunc.Trim(txtLotID.Text), 1) == false)
                    //            {
                    //                MessageBox.Show("必填内容输入为空！");
                    //                txtLotID.Focus();
                    //                return false;
                    //            }

                    //            if ( ComFunc.CheckValue(ComFunc.Trim(txtNewQty1.Text), 1) == false)
                    //            {
                    //                if (MPCF.CheckValue(txtNewQty1, 2) == false)
                    //                {
                    //                    tabTran.SelectedTab = tbpGeneral;
                    //                    txtNewQty1.Focus();
                    //                    return false;
                    //                }
                    //            }

                    //            if (ComFunc.Trim(cdvToFlow.Text) != "" && ComFunc.Trim(cdvToOperation.Text) == "")
                    //            {
                    //                MessageBox.Show("……");
                    //                tabTran.SelectedTab = tbpGeneral;
                    //                cdvToOperation.Focus();
                    //                return false;
                    //            }

                    //            if (LOT.GetDouble("QTY_1") > 0 || LOT.GetDouble("QTY_2") > 0 || LOT.GetDouble("QTY_3") > 0)
                    //            {
                    //                if (cdvResID.Items.Count > 0)
                    //                {
                    //                    if (MPCF.CheckValue(cdvResID, 1) == false)
                    //                    {
                    //                        tabTran.SelectedTab = tbpGeneral;
                    //                        cdvResID.Focus();
                    //                        return false;
                    //                    }
                    //                }
                    //            }

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
                if (CheckCondition("CREATE") == false) return;
                //调用事务服务
                // if (UpdateBoxShipment(GlobConst.TRAN_CREATE) == false) return;

                //控件重定义
                //if (MPCF.Trim(txtBox_LotID.Text) != "")
                //{
                //控件初始化
                //ComFunc.ClearList(lisOperLotList);
                //ComFunc.ClearList(spdBox_SubTask);
                ////MPCF.ClearList(spdOrderID);
                //ComFunc.FieldClear(spdOrderID);
                //ComFunc.ClearList(spdBox_LayoutID_MarkID);
                //ComFunc.FieldClear(pnlTask);
                //重新查询
                //View_Lot_List("2");
                //ViewSubLotListExt();
                //ViewLotBoxListExt('2');
                //View_Order_list(txtBox_LotID.Text);
                //}
                UpdateModelReq<AOIShowView> updateReq = new UpdateModelReq<AOIShowView>();
                this.getUpdateModel(updateReq);

                ModelRsp<AOIShowView> result = OQASrv.CallServer().CreateOrUpdateAOI(updateReq);
                if (!result._success)
                {
                    MessageBox.Show("更新失败");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
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
                String side = "F";
                if (frontFlag)
                {
                    codeList = waferSurF.defectCode;
                }
                else
                {
                    codeList = waferSurB.defectCode;
                    side = "B";
                }
                //wafer
                iSPWAFITM.LotId = textBox7.Text;
                iSPWAFITM.SlotId = comboBox1.Text;
                iSPWAFITM.WaferId = "1";//mock
                iSPWAFITM.InspectType = "A";
                iSPWAFITM.SideType = side;
                iSPWAFITM.Magnification = textBox1.Text.TrimEnd('X');
                iSPWAFITM.DieQty = int.Parse(textBox3.Text);
                iSPWAFITM.DefectRate = int.Parse(textBox5.Text.TrimEnd('%'));
                iSPWAFITM.ReviewUser = textBox6.Text;
                iSPWAFITM.DefectDesc = richTextBox1.Text;
                iSPWAFITM.Cmt = richTextBox2.Text;
                //img
                iSPIMGDEF.SlotId = iSPWAFITM.SlotId;
                iSPIMGDEF.LotId = iSPWAFITM.LotId;
                iSPIMGDEF.WaferId = iSPWAFITM.WaferId;
                iSPIMGDEF.SideType = iSPWAFITM.SideType;
                iSPIMGDEF.InspectType = iSPWAFITM.InspectType;
                iSPIMGDEF.TransSeq = 2;
                iSPIMGDEF.ImagePath = textBox3.Text;
                imgList.Add(iSPIMGDEF);
                //dft


                for (int i = 0; i < 24; i++)
                {
                    if (null != codeList[i] && !codeList[i].Equals(""))
                    {
                        ISPWAFDFT iSPWAFDFT = new ISPWAFDFT();
                        iSPWAFDFT.LotId = iSPWAFITM.LotId;
                        iSPWAFDFT.SlotId = iSPWAFITM.SlotId;
                        iSPWAFDFT.WaferId = iSPWAFITM.WaferId;
                        iSPWAFDFT.SideType = iSPWAFITM.SideType;
                        iSPWAFDFT.InspectType = iSPWAFITM.InspectType;
                        iSPWAFDFT.TransSeq = 2;
                        iSPWAFDFT.DefectCode = codeList[i];
                        iSPWAFDFT.AreaId = i;
                        sftList.Add(iSPWAFDFT);
                    }
                }

                model.c_proc_step = '1';
                model.c_tran_flag = 'U';
                model.ISPWAFITM = iSPWAFITM;
                model.ISPIMGDEF_list = imgList;
                model.ISPWAFDFT_list = sftList;
                updateReq.model = model;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void FrmAOIInput_Load(object sender, EventArgs e)
        {
            this.pageInfoShow();
        }
        private void pageInfoShow()
        {
            try
            {
                ModelRsp<AOIShowView> view = new ModelRsp<AOIShowView>();
                AOIShowView model = new AOIShowView();
                model.c_proc_step = 'Q';
                model.c_tran_flag = '1';
                ISPWAFITM ISPWAFITM = new ISPWAFITM();
                ISPWAFITM.LotId = "1";
                ISPWAFITM.SlotId = "1";
                ISPWAFITM.WaferId = "1";
                ISPWAFITM.SideType = "F";
                ISPWAFITM.InspectType = "A";
                model.ISPWAFITM = ISPWAFITM;
                view.model = model;
                textBox7.Text = view.model.ISPWAFITM.LotId;
                comboBox1.Text = view.model.ISPWAFITM.SlotId;
                comboBox1.Items.AddRange(new string[] { comboBox1.Text });
                ModelRsp<AOIShowView> qryResult = OQASrv.CallServer().QueryAOIInfo(view);

                textBox1.Text = qryResult.model.ISPWAFITM.Magnification+"X";
                textBox3.Text = qryResult.model.ISPWAFITM.DieQty.ToString();
                textBox3.Text = qryResult.model.ISPIMGDEF_list[0].ImagePath;//mock value
                textBox5.Text = qryResult.model.ISPWAFITM.DefectRate+"%";
                textBox6.Text = qryResult.model.ISPWAFITM.ReviewUser;
                richTextBox1.Text = qryResult.model.ISPWAFITM.DefectDesc;
                richTextBox2.Text = qryResult.model.ISPWAFITM.Cmt;
                waferSurF.box = this.textBox2;
                waferSurF.showWafer(qryResult.model.ISPWAFDFT_list);

                if (ISPWAFITM.SideType != "F")
                {//显示正反面判断
                    waferSurF.Enabled = false;
                    this.backButton.BackColor = Color.Green;
                    this.frontButton.BackColor = Color.Gray;
                }
                else
                {
                    waferSurB.Enabled = false;
                    this.frontButton.BackColor = Color.Green;
                    this.backButton.BackColor = Color.Gray;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
    }
}