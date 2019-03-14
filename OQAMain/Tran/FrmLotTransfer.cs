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
        private string MasterLot="";
        

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

        private enum SHIPLIST
        {
            LOT_ID = 0,
            QTY,
            PART_ID,
            INSPECT_RESULT
        }



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
            
           

        }
        private void FrmLotTransfer_Load(object sender, EventArgs e)
        {
            try
            {
                if (QueryLotIDList(GlobConst.TRAN_VIEW, '1') == false) return;

                
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
            MessageBox.Show("交接单号"+ srtNum);
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
        //显示所有LOT
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
                    LotIDList.Items.Add(list_item.Text);
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

        
    
        private bool Querylotinfo(char c_proc_step, char c_tran_flag,string in_masterlot_no)
        {
            ModelRsp<QueryLotDetailView> in_node = new ModelRsp<QueryLotDetailView>();
            QueryLotDetailView in_data = new QueryLotDetailView();

            in_data.C_PROC_STEP = c_proc_step;
            in_data.C_TRAN_FLAG = c_tran_flag;
            in_data.IN_MASTERLOT_NO= in_masterlot_no;

            in_node.model = in_data;

            var out_data = OQASrv.Call.QueryLotDetail(in_node);
            var total_count=0;
            //var out_data_ship = OQASrv.Call.QryPKGShipSummaryInfo(in_node);

            if (out_data._success == true)
            {
               if (c_tran_flag == '1') { 
                    ComFunc.InitListView(listship, true);
                    for (int i = 0; i < out_data.model.PKGSHPDAT_list.Count; i++)
                    {

                        ListViewItem list_item = new ListViewItem();
                      //  out_data.model.PKGLabel_list[0][(int)PKG_LIST.slot_id].ToString();

                      //  PKGSHPDAT list = out_data.model.PKGSHPDAT_list[i][(int)SHIPLIST.LOT_ID].ToString();
                        list_item.Text = out_data.model.PKGSHPDAT_list[i][(int)SHIPLIST.LOT_ID].ToString();
                        list_item.SubItems.Add(out_data.model.PKGSHPDAT_list[i][(int)SHIPLIST.QTY].ToString());
                        list_item.SubItems.Add(out_data.model.PKGSHPDAT_list[i][(int)SHIPLIST.PART_ID].ToString());
                        list_item.SubItems.Add(out_data.model.PKGSHPDAT_list[i][(int)SHIPLIST.INSPECT_RESULT].ToString());//修改数据使用
                        listship.Items.Add(list_item);
                        total_count = total_count + Convert.ToInt32(out_data.model.PKGSHPDAT_list[i][(int)SHIPLIST.QTY].ToString());
                        txtPartID.Text = out_data.model.PKGSHPDAT_list[i][(int)SHIPLIST.PART_ID].ToString();
                    }
                    txtQTY.Text = total_count.ToString();
                    txtDate.Text = DateTime.Now.ToString("yyyyMMddHHmm");
                }
                if (c_tran_flag == '2')
                {
                    
                    if (out_data.model.PKGSHPDAT_list.Count ==0 || out_data.model.PKGSHPDAT_list[0][0].ToString() != "1")
                    {
                        MessageBox.Show("选择的lotid不属于同一个part！");

                        //for (int i = 0; i < LotIDList.Items.Count; i++)
                        //{
                        //    LotIDList.SetItemChecked(i, false);
                        //}
                        //Select_All.Checked = false;
                        MasterLot = string.Empty;
                        return false;
                    }
                   
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

        private void LotIDList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // MasterLot = string.Empty;
            

            foreach (var item in LotIDList.CheckedItems)
            {
                if (e.NewValue == CheckState.Unchecked && item == LotIDList.Items[e.Index])
                {
                    continue;
                }

                if (MasterLot.Length == 0)
                {
                    MasterLot = "'" + item.ToString().Trim() + "'";
                }
                else
                {
                    MasterLot = MasterLot + ",'" + item.ToString().Trim() + "'";
                }

            }
            if (e.NewValue == CheckState.Checked)
            {
                if (MasterLot.Length == 0)
                {
                    MasterLot = "'" + LotIDList.Items[e.Index].ToString().Trim() + "'";
                }
                else
                {
                    MasterLot = MasterLot + ",'" + LotIDList.Items[e.Index].ToString().Trim() + "'";
                }
            }

            if (string.IsNullOrWhiteSpace(MasterLot))
            {
                ComFunc.InitListView(listship, true);
                txtPartID.Text = "";
                txtQTY.Text = "";
                return;
            }

            if (Querylotinfo(GlobConst.TRAN_VIEW, '2', MasterLot) == false)
            {
                LotIDList.ItemCheck -= LotIDList_ItemCheck;
                e.NewValue = CheckState.Unchecked;
                LotIDList.ItemCheck += LotIDList_ItemCheck;
                return;
            }
           
            if (Querylotinfo(GlobConst.TRAN_VIEW, '1', MasterLot) == false) return;
           

            MasterLot = string.Empty;
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            


            foreach (var item in LotIDList.Items)
            {
               
                if (MasterLot.Length == 0)
                {
                    MasterLot = "'" + item.ToString().Trim() + "'";
                }
                else
                {
                    MasterLot = MasterLot + ",'" + item.ToString().Trim() + "'";
                }

            }
            if (string.IsNullOrWhiteSpace(MasterLot))
            {
                ComFunc.InitListView(listship, true);
                return;
            }

            if (Querylotinfo(GlobConst.TRAN_VIEW, '2', MasterLot) == false)
            {
                return;
            }
            if (Querylotinfo(GlobConst.TRAN_VIEW, '1', MasterLot) == false) return;

            this.LotIDList.ItemCheck -= LotIDList_ItemCheck;
            this.LotIDList.CheckAll();
            this.LotIDList.ItemCheck += LotIDList_ItemCheck;
        }

        private void btnUnCheckAll_Click(object sender, EventArgs e)
        {
            this.LotIDList.ItemCheck -= LotIDList_ItemCheck;
            this.LotIDList.UnCheckAll();
            ComFunc.InitListView(listship, true);
            txtPartID.Text = "";
            txtQTY.Text = "";
            this.LotIDList.ItemCheck += LotIDList_ItemCheck;
        }
    }
}