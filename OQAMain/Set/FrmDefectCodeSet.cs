using Syncfusion.Windows.Forms;
using OQA_Core;
using System;
using System.Windows.Forms;
using WCFModels.Message;
using WCFModels.OQA;
using System.Collections.Generic;

namespace OQAMain
{
    public partial class FrmDefectCodeSet : OQABaseForm
    {
        #region " Windows Form auto generated code "
        public FrmDefectCodeSet()
        {
            InitializeComponent();
        }

        #endregion


        #region " Constant Definition "
        //private bool b_load_flag = false;

        #endregion


        #region " Variable Definition "
        //private bool b_load_flag  ;
        private string s_ISP_Type = " ";
        private string s_Defect_Code = " ";
        //private string s_Defect_Desc = " ";
        #endregion


        #region " Function Definition "

        #region " 事务前数据检查 "
        private bool CheckCondition(string FuncName)
        {

            switch (ComFunc.Trim(FuncName))
            {
                case "CREATE":

                    if (ComFunc.CheckValue(txtIspType, 1) == false)
                    {
                        MessageBox.Show("必填内容输入为空！");
                        txtIspType.Focus();
                        return false;
                    }

                    if (ComFunc.CheckValue(txtDefectCode, 1) == false)
                    {
                        MessageBox.Show("必填内容输入为空！");
                        txtIspType.Focus();
                        return false;
                    }

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


        private bool QueryDefectCodeInfo(char c_proc_step, char c_tran_flag)
        {
            ModelRsp<DefectCodeView> in_node = new ModelRsp<DefectCodeView>();
            DefectCodeView in_data = new DefectCodeView();

            in_data.C_PROC_STEP = c_proc_step;
            in_data.C_TRAN_FLAG = c_tran_flag;
            
            in_node.model = in_data;

            var out_data = OQASrv.CallServer().QueryDefectCodeInfo(in_node);

            if (out_data._success == true)
            {
                ComFunc.InitListView(LstIspCode, true);
                for (int i = 0; i < out_data.model.ISPDFTDEF_list.Count; i++)
                {
                    ListViewItem list_item = new ListViewItem();
                    ISPDFTDEF list = out_data.model.ISPDFTDEF_list[i];
                    list_item.SubItems.Add(list.InspectType);
                    list_item.SubItems.Add(list.DefectCode);
                    list_item.SubItems.Add(list.DftDesc);
                    LstIspCode.Items.Add(list_item);
                }
            }
            else
            {
                MessageBox.Show(out_data._ErrorMsg);
            }

            //LstIspCode.Items.Add(ListView(data.model.ISPDFTDEF_list));
            //data.model.ISPDFTDEF_list;
            //LstIspCode.d

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

                if (ComFunc.Trim(s_ISP_Type) != "" && (ComFunc.Trim(s_Defect_Code) != ""))
                {
                    //GlobConst.TRAN_UPDATE
                }
                else
                {
                    //GlobConst.TRAN_CREATE
                }
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

        private void rbnFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnFilter.Checked == true)
            {
                txtFilter.Enabled = true;
            }
        }

        private void rbnNoFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnNoFilter.Checked == true)
            {
                ComFunc.FieldClear(txtFilter);
                txtFilter.Enabled = false;
            }
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                if (ComFunc.Trim(txtFilter.Text) != "")
                {
                    btnFilterView.PerformClick();
                }
            }
        }

        private void btnFilterView_Click(object sender, EventArgs e)
        {
            //QryDefectCodeInfo
            try
            {
                //检查数据
               // if (CheckCondition("TypeView") == false) return;


                //调用事务服务
                if (QueryDefectCodeInfo(GlobConst.TRAN_VIEW,'1') == false) return;

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
    }
}