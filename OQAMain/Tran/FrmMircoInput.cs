﻿using Syncfusion.Windows.Forms;
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
        #region " Windows Form auto generated code "
        public FrmMircoInput()
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
            waferSurF.Visible = true;
            waferSurF.Enabled = true;
            waferSurB.Enabled = false;
            waferSurB.Visible = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            frontFlag = false;
            this.backButton.BackColor = Color.Green;
            this.frontButton.BackColor = Color.Gray;
            waferSurB.Enabled = true;
            waferSurB.Visible = true;
            waferSurF.Visible = false;
            waferSurF.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            waferSurF.clearPanel();
            waferSurB.clearPanel();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioNine.Checked)
            {
                radioNine.Checked = true;
                groupBoxThree.Visible = false;
                groupBoxThree.Enabled = false;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioThr.Checked)
            {
                radioThr.Checked = true;
                groupBoxThree.Visible = true;
                groupBoxThree.Enabled = true;
            }
        }
        #region " 事务前数据检查 "
        private bool CheckCondition(string FuncName)
        {

            switch (ComFunc.Trim(FuncName))
            {
                case "CREATE":

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
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void FrmMircoInput_Load(object sender, EventArgs e)
        {
            radioNine.Checked = true;
            this.checkAllOk();
            this.pageInfoShow();
            waferSurB.Enabled = false;
            waferSurB.Visible = false;
            this.frontButton.BackColor = Color.Green;
            this.backButton.BackColor = Color.Gray;
        }

        #region show function
        private void pageInfoShow()
        {
            string lotId = "1";
            string slotId = "1";
            string sideType = "F";
            try
            {
                ModelRsp<AOIShowView> view = new ModelRsp<AOIShowView>();
                AOIShowView model = new AOIShowView();
                model.C_PROC_STEP = '1';
                model.C_TRAN_FLAG = GlobConst.TRAN_VIEW;
                ISPWAFITM ISPWAFITM = new ISPWAFITM();
                ISPWAFITM.LotId = lotId;
                ISPWAFITM.SlotId = slotId;
                ISPWAFITM.WaferId = "1";
                ISPWAFITM.SideType = sideType;
                ISPWAFITM.InspectType = "A";
                model.ISPWAFITM = ISPWAFITM;
                view.model = model;
                lotTextBox.Text = view.model.ISPWAFITM.LotId;
                slotComboBox.Text = view.model.ISPWAFITM.SlotId;
                slotComboBox.Items.AddRange(new string[] { slotComboBox.Text });
                ModelRsp<AOIShowView> qryResult = OQASrv.OQAClient.QueryAOIInfo(view);
                if (null != qryResult.model)
                {
                    if (null != qryResult.model.ISPWAFITM)
                    {
                        MagnificationTextBox.Text = qryResult.model.ISPWAFITM.Magnification;
                        qtyTextBox.Text = qryResult.model.ISPWAFITM.DieQty.ToString();
                        rateTextBox.Text = qryResult.model.ISPWAFITM.DefectRate.ToString();
                        decRichTextBox.Text = qryResult.model.ISPWAFITM.DefectDesc;
                        cmtRichTextBox.Text = qryResult.model.ISPWAFITM.Cmt;
                    }
                    if (null != qryResult.model.ISPIMGDEF_list && qryResult.model.ISPIMGDEF_list.Count > 0)
                    {
                        //imageTextBox.Text = qryResult.model.ISPIMGDEF_list[0].ImagePath;//mock value
                    }
                }

                waferSurF.showWafer(qryResult.model.ISPWAFDFT_list);//显示wafer表格
                if (null != qryResult.model.ISPWAFDFT_list && qryResult.model.ISPWAFDFT_list.Count > 0)
                {
                    foreach (var child in qryResult.model.ISPWAFDFT_list)
                    {
                        showDefectCheck(child.AreaId.ToString(), child.DefectCode);
                    }

                }

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

        public void showDefectCheck(string id, string code)
        {
            foreach (Control control in groupBoxNine.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox c = control as CheckBox;
                    if (control.Name.Split('_')[1].Equals(id))
                    {

                        if (null != code && !code.Equals(""))
                        {
                            if (control.Name.Split('_')[0].Equals("ngBox"))
                            {
                                c.Checked = true;
                            }
                            if (control.Name.Split('_')[0].Equals("okBox"))
                            {
                                c.Checked = false;
                            }
                        }
                    }
                }
            }
            if (radioThr.Checked)
            {
                foreach (Control control in groupBoxThree.Controls)
                {
                    if (control is CheckBox)
                    {
                        CheckBox c = control as CheckBox;
                        if (control.Name.Split('_')[1].Equals(id))
                        {

                            if (null != code && !code.Equals(""))
                            {
                                if (control.Name.Split('_')[0].Equals("ngBox"))
                                {
                                    c.Checked = true;
                                }
                                if (control.Name.Split('_')[0].Equals("okBox"))
                                {
                                    c.Checked = false;
                                }
                            }
                        }
                    }
                }
            }
        }

        public void checkAllOk()
        {
            foreach (Control control in groupBoxNine.Controls)
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
        #endregion
    }
}