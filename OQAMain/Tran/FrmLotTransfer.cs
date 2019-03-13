using Syncfusion.Windows.Forms;
using OQA_Core;
using System;
using System.Windows.Forms;
using WCFModels.OQA;
using WCFModels.Message;
using System.Collections.Generic;

namespace OQAMain
{
    public partial class FrmLotTransfer : OQABaseForm
    {
        #region " Windows Form auto generated code "
        public FrmLotTransfer()
        {
            InitializeComponent();
        }

        #endregion


        #region " Constant Definition "
        //private bool b_load_flag = false;

        #endregion


        #region " Variable Definition "
        //private bool b_load_flag  ;
        private bool Have_flag = false;
        private string MasterLot;
        

        #endregion


        #region " Function Definition "

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


        public static string srtNum;
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
        private void LstIspCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < LotIDList.Items.Count; i++)
            {
                Have_flag = true;
                MessageBox.Show(i.ToString());
                MasterLot = LotIDList.GetItemText(LotIDList.Items[i]);
            }


        }
        private void FrmLotTransfer_Load(object sender, EventArgs e)
        {
            try
            {
                if (QueryLotIDList(GlobConst.TRAN_VIEW, '1') == false) return;

                if (Querylotinfo(GlobConst.TRAN_VIEW, '1', MasterLot) == false) return;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            //try
            //{
                
            //   // ship_no = txtShipNo.Text.Trim();
            //    // ship_no = "12453";
            //    if (Querylotinfo(GlobConst.TRAN_VIEW, '1', MasterLot) == false) return;

            //}
            //catch (System.Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString());
            //}
        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            FrmOQAShipListPrint formshiplistprint = new FrmOQAShipListPrint();
            MessageBox.Show("交接单号");
            formshiplistprint.ShowDialog();
        }
        public string GetSerialNum()
        {

            srtNum = DateTime.Now.ToString("yyyyMMddHHmm");
            Random ra = new Random();
            string a = srtNum += (" ");  //空格
            srtNum += ra.Next(100000, 999999);  //六位随机数
            return srtNum;

        }
        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private bool QueryLotIDList(char c_proc_step, char c_tran_flag)
        {
            ModelRsp<LotIDListView> in_node = new ModelRsp<LotIDListView>();
            LotIDListView in_data = new LotIDListView();

            in_data.C_PROC_STEP = c_proc_step;
            in_data.C_TRAN_FLAG = c_tran_flag;

            in_node.model = in_data;

            var out_data = OQASrv.Call.QueryLotList(in_node);

            if (out_data._success == true)
            {
                 //ComFunc.(LotIDList, true);
                //      txtCount.Text = out_data.model.PKGSHPDAT_list.Count.ToString();

                
                for (int i = 0; i < out_data.model.ISPLOTST_list.Count; i++)
                {
                    ListViewItem list_item = new ListViewItem();
                    ISPLOTSTS list = out_data.model.ISPLOTST_list[i];
                    list_item.Text = list.LotId;
                    LotIDList.Items.Add(list_item);
                }
                lblSucessMsg.Text = out_data._MsgCode;
                return true;
            }
            else
            {
                MessageBox.Show(out_data._ErrorMsg);
                return false;
            }
        }

        //全选
        private void Select_All_CheckedChanged(object sender, EventArgs e)
        {
            if (Select_All.Checked)
            {
                for (int i = 0; i < LotIDList.Items.Count; i++)
                {
                    LotIDList.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < LotIDList.Items.Count; i++)
                {
                    LotIDList.SetItemChecked(i, false);
                }
            }
        }
        private List<PKGSHPDAT> LOTlist;
       
        private bool Querylotinfo(char c_proc_step, char c_tran_flag, string in_masterlot_no)
        {
            ModelRsp<QueryLotDetailView> in_node = new ModelRsp<QueryLotDetailView>();
            QueryLotDetailView in_data = new QueryLotDetailView();

            in_data.C_PROC_STEP = c_proc_step;
            in_data.C_TRAN_FLAG = c_tran_flag;
            in_data.IN_MASTERLOT_NO= in_masterlot_no;

            in_node.model = in_data;

            var out_data = OQASrv.Call.QueryLotDetail(in_node);
            //var out_data_ship = OQASrv.Call.QryPKGShipSummaryInfo(in_node);

            if (out_data._success == true)
            {
                //lstShip = out_data_ship.model.PKGSHP_list;
                LOTlist = out_data.model.PKGSHPDAT_list;

               // ComFunc.InitListView(LOTlist, true);
                //      txtCount.Text = out_data.model.PKGSHPDAT_list.Count.ToString();

                for (int i = 0; i < out_data.model.PKGSHPDAT_list.Count; i++)
                {

                    ListViewItem list_item = new ListViewItem();
                    PKGSHPDAT list = out_data.model.PKGSHPDAT_list[i];
                    list_item.Text = list.LotId;
                    list_item.SubItems.Add(list.Qty);
                    list_item.SubItems.Add(list.PartId);
                    list_item.SubItems.Add(list.InspectResult);//修改数据使用
                    listship.Items.Add(list_item);


                }
                lblSucessMsg.Text = out_data._MsgCode;
                return true;
            }
            else
            {
                MessageBox.Show(out_data._ErrorMsg);
                return false;
            }


        }
    }
}