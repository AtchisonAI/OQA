﻿using Syncfusion.Windows.Forms;
using OQA_Core;
using System;
using System.Windows.Forms;
using WCFModels.OQA;
using WCFModels.Message;
using System.Collections.Generic;
using WcfClientCore.Utils.Authority;
using System.Linq;

namespace OQAMain
{
    public partial class FrmLotTransfer : OQABaseForm
    {
        #region " Windows Form auto generated code "
        public FrmLotTransfer()
        {
            InitializeComponent();
            QueryLotIDList(GlobConst.TRAN_VIEW, '1') ;
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
        private decimal Trans_Seq = 0;

        #region " Function Definition "

        #region " 事务前数据检查 "
        private bool CheckCondition(string FuncName)
        {

            switch (ComFunc.Trim(FuncName))
            {
                case "CREATE":

                    //            if (ComFunc.CheckValue(ComFunc.Trim(txtLotID.Text), 1) == false)
                    //            {
                    //                MessageBox.Show("Input of required contents is null！");
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
            INSPECT_RESULT,
            TRANS_SEQ
        }



        public static string srtNum;
      
        private void FrmLotTransfer_Load(object sender, EventArgs e)
        {
            txtCreater.Text= AuthorityControl.GetUserProfile().userId;

        }


        private List<PKGSHPDAT> insert_data = new List<PKGSHPDAT>();

      

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            insert_data.Clear();
            GetSerialNum();
            MessageBox.Show("Ship ID:\n"+ srtNum);
            FrmOQAShipListPrint formshiplistprint = new FrmOQAShipListPrint(srtNum);

            string s_PartID = ComFunc.Trim(txtPartID.Text);
            string s_QTY = ComFunc.Trim(txtQTY.Text);
            string s_Date = ComFunc.Trim(txtDate.Text);
            string s_Creater = ComFunc.Trim(txtCreater.Text);
            char cTranFlag;
            cTranFlag = GlobConst.TRAN_CREATE;


            //调用事务服务
            //
            if (CreateLotTransferInfo(cTranFlag, '1', s_PartID, s_Creater, s_QTY, s_Date, srtNum, Trans_Seq) == true)
            {           
                foreach (ListViewItem item in this.listship.Items)
                {
                    PKGSHPDAT item1 = new PKGSHPDAT();
                    string lotid = item.SubItems[0].Text;
                    string qty = item.SubItems[1].Text;
                    string partid = item.SubItems[2].Text;
                    string isp_result = item.SubItems[3].Text;
                    string update_trans_seq = item.SubItems[4].Text;
                    item1.LotId= lotid.ToString();
                    item1.Qty = qty;
                    item1.PartId = partid;
                    item1.InspectResult = isp_result;
                    item1.TransSeq = Convert.ToDecimal(update_trans_seq);
                    
                    insert_data.Add(item1);
                }


                if (CreateLotTransferListInfo(cTranFlag, '1', srtNum) == true)
                {
                    if (CreateLotTransferListInfo(GlobConst.TRAN_UPDATE, '1', srtNum) == false)
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }

                formshiplistprint.FormBorderStyle = FormBorderStyle.FixedDialog;
                formshiplistprint.WindowState = FormWindowState.Maximized;
                formshiplistprint.StartPosition = FormStartPosition.CenterParent;
                formshiplistprint.ShowDialog();

                ComFunc.InitListView(listship, true);
                txtPartID.Text = "";
                txtQTY.Text = "";
                txtDate.Text= "";
                LotIDList.Items.Clear();
                if (QueryLotIDList(GlobConst.TRAN_VIEW, '1') == false) return;

               // AddNewFormToMdi(formshiplistprint);

            }                     
        }
       
        //得到shipID
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
                List<ISPLOTSTS> SortByTime = out_data.model.ISPLOTST_list.OrderByDescending(o => o.UpdateTime).ToList();
                for (int i = 0; i < SortByTime.Count; i++)
                {
                    ListViewItem list_item = new ListViewItem();
                    ISPLOTSTS list = SortByTime[i];
                    list_item.Text = list.LotId.PadRight(18)+ list.PartId;
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

        //checkedlistbox的masterlot，checkedlistbox的masterlot
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

            if (out_data._success == true)
            {
               if (c_tran_flag == '1') { 
                    ComFunc.InitListView(listship, true);
                    for (int i = 0; i < out_data.model.PKGSHPDAT_list.Count; i++)
                    {

                        ListViewItem list_item = new ListViewItem();

                        list_item.Text = out_data.model.PKGSHPDAT_list[i][(int)SHIPLIST.LOT_ID].ToString();
                        list_item.SubItems.Add(out_data.model.PKGSHPDAT_list[i][(int)SHIPLIST.QTY].ToString());
                        list_item.SubItems.Add(out_data.model.PKGSHPDAT_list[i][(int)SHIPLIST.PART_ID].ToString());
                        list_item.SubItems.Add(out_data.model.PKGSHPDAT_list[i][(int)SHIPLIST.INSPECT_RESULT].ToString());
                        list_item.SubItems.Add(out_data.model.PKGSHPDAT_list[i][(int)SHIPLIST.TRANS_SEQ].ToString());
                        listship.Items.Add(list_item);
                        total_count = total_count + Convert.ToInt32(out_data.model.PKGSHPDAT_list[i][(int)SHIPLIST.QTY].ToString());
                        txtPartID.Text = out_data.model.PKGSHPDAT_list[i][(int)SHIPLIST.PART_ID].ToString();
                    }
                    txtQTY.Text = total_count.ToString();
                    txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                }
                if (c_tran_flag == '2')
                {
                    
                    if (out_data.model.PKGSHPDAT_list.Count ==0 || out_data.model.PKGSHPDAT_list[0][0].ToString() != "1")
                    {
                        MessageBox.Show("The Lot ID selected does not belong to the same Part ID!");
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
        //insert to PKGSHPSTS 
        private bool CreateLotTransferInfo(char c_proc_step, char c_tran_flag, string part_id, string Creater, string QTY,string ship_date,string ship_id, decimal TransSeq)
        {
            ModelRsp<LotTransferSave> in_node = new ModelRsp<LotTransferSave>();
            LotTransferSave in_data = new LotTransferSave();

            in_data.C_PROC_STEP = c_proc_step;
            in_data.C_TRAN_FLAG = c_tran_flag;
            in_data.D_TRANSSEQ = TransSeq; //事务控制
            in_data.IN_PART_ID = part_id;
            in_data.IN_CREATER = Creater;
            in_data.IN_QTY = QTY;
            in_data.IN_SHIP_DATE = ship_date;
            in_data.IN_SHIPID = ship_id;


            in_node.model = in_data;

            var out_data = OQASrv.Call.CreateLotTransferInfo(in_node);

            if (out_data._success == true)
            {
                lblSucessMsg.Text = out_data._MsgCode;
                //MessageBox.Show(out_data._MsgCode);
                return true;
            }
            else
            {
                MessageBox.Show(out_data._ErrorMsg);
                return false;
            }

        }

        //insert to PKGSHPDAT
        private bool CreateLotTransferListInfo(char c_proc_step, char c_tran_flag,  string ship_id)
        {
            ModelRsp<LotTransferListSave> in_node = new ModelRsp<LotTransferListSave>();
            LotTransferListSave in_data = new LotTransferListSave();


            in_node.model.C_PROC_STEP = c_proc_step;
            in_node.model.C_TRAN_FLAG = c_tran_flag;
            in_node.model.IN_SHIPID = ship_id;
            in_node.model.S_USER_ID = AuthorityControl.GetUserProfile().userId;

            in_node.model.INSERTPKGSHPDAT_list = insert_data;

            var out_data = OQASrv.Call.CreateLotTransferListInfo(in_node);

            if (out_data._success == true)
            {
                lblSucessMsg.Text = out_data._MsgCode;
                //MessageBox.Show(out_data._MsgCode);
                return true;
            }
            else
            {
                MessageBox.Show(out_data._ErrorMsg);
                return false;
            }

        }

        //checkedlistbox选择，产生MASTERLOT
        private void LotIDList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            foreach (var item in  LotIDList.CheckedItems)
            {
                if (e.NewValue == CheckState.Unchecked && item == LotIDList.Items[e.Index])
                {
                    continue;
                }

                if (MasterLot.Length == 0)
                {
                    MasterLot = "'" + item.ToString().Split(' ')[0].Trim() + "'";
                }
                else
                {
                    MasterLot = MasterLot + ",'" + item.ToString().Split(' ')[0].Trim() + "'";
                }

            }
            if (e.NewValue == CheckState.Checked)
            {
                if (MasterLot.Length == 0)
                {
                    MasterLot = "'" + LotIDList.Items[e.Index].ToString().Split(' ')[0].Trim() + "'";
                }
                else
                {
                    MasterLot = MasterLot + ",'" + LotIDList.Items[e.Index].ToString().Split(' ')[0].Trim() + "'";
                }
            }

            if (string.IsNullOrWhiteSpace(MasterLot))
            {
                ComFunc.InitListView(listship, true);
                txtPartID.Text = "";
                txtQTY.Text = "";
                txtDate.Text = "";
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

        //全选
        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            foreach (var item in LotIDList.Items)
            {
               
                if (MasterLot.Length == 0)
                {
                    MasterLot = "'" + item.ToString().Split(' ')[0].Trim() + "'";
                }
                else
                {
                    MasterLot = MasterLot + ",'" + item.ToString().Split(' ')[0].Trim() + "'";
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

        //取消全选
        private void btnUnCheckAll_Click(object sender, EventArgs e)
        {
            this.LotIDList.ItemCheck -= LotIDList_ItemCheck;
            this.LotIDList.UnCheckAll();
            ComFunc.InitListView(listship, true);
            txtPartID.Text = "";
            txtQTY.Text = "";          
            txtDate.Text = "";
            this.LotIDList.ItemCheck += LotIDList_ItemCheck;
        }


        //搜索lotID
        private bool SearchLotIDList(char c_proc_step, char c_tran_flag,string searchlotid)
        {
            ModelRsp<QueryLotDetailView> in_node = new ModelRsp<QueryLotDetailView>();
            QueryLotDetailView in_data = new QueryLotDetailView();

            in_data.C_PROC_STEP = c_proc_step;
            in_data.C_TRAN_FLAG = c_tran_flag;
            in_data.IN_SEARCHLOTID_NO = searchlotid;
            in_node.model = in_data;

            var out_data = OQASrv.Call.QueryLotDetail(in_node);

            if (out_data._success == true)
            {
                LotIDList.Items.Clear();
                for (int i = 0; i < out_data.model.SEARCHLOTID_list.Count; i++)
                {
                    ListViewItem list_item = new ListViewItem();
                   
                    list_item.Text = out_data.model.SEARCHLOTID_list[i][0].ToString().PadRight(18)+out_data.model.SEARCHLOTID_list[i][1];
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


        private void chkALL_CheckedChanged(object sender, EventArgs e)
        {
            if (chkALL.Checked == true)
            {
                foreach (var item in LotIDList.Items)
                {

                    if (MasterLot.Length == 0)
                    {
                        MasterLot = "'" + item.ToString().Split(' ')[0].Trim() + "'";
                    }
                    else
                    {
                        MasterLot = MasterLot + ",'" + item.ToString().Split(' ')[0].Trim() + "'";
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
            else
            {
                this.LotIDList.ItemCheck -= LotIDList_ItemCheck;
                this.LotIDList.UnCheckAll();
                ComFunc.InitListView(listship, true);
                txtPartID.Text = "";
                txtQTY.Text = "";
                txtDate.Text = "";
                this.LotIDList.ItemCheck += LotIDList_ItemCheck;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearData("1");
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.LotIDList.ItemCheck -= LotIDList_ItemCheck;
            if (ComFunc.Trim(txtSearchLotID.Text) != "")
            {
                if (SearchLotIDList(GlobConst.TRAN_VIEW, '3', txtSearchLotID.Text.Trim()) == false) return;
            }
            else
            {
                LotIDList.Items.Clear();
                if (QueryLotIDList(GlobConst.TRAN_VIEW, '1') == false) return;
            }
            this.LotIDList.ItemCheck += LotIDList_ItemCheck;
        }

        private void txtSearchLotID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnQuery.PerformClick();
            }
        }
    }
}