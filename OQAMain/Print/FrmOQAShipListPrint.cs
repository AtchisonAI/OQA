using Syncfusion.Windows.Forms;
using OQA_Core;
using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.IO;
using OQAMain.Print;
using Zen.Barcode;
using System.Drawing;
using transferForm;
using System.Data;
using WCFModels.Message;
using WCFModels.OQA;
using System.Linq;

namespace OQAMain
{
    public partial class FrmOQAShipListPrint : OQABaseForm
    {
        #region " Windows Form auto generated code "
        public FrmOQAShipListPrint()
        {
            InitializeComponent();
        }
        public FrmOQAShipListPrint(string shipId)
        {
            InitializeComponent();
            this.txtShowShipID.Text = shipId;
            this.txtShipFilter.Text = shipId;
        }

        #endregion


        #region " Constant Definition "
        //private bool b_load_flag = false;

        #endregion


        #region " Variable Definition "
       
        private string searchbydate;
        private string shipID;
        #endregion


        #region " Function Definition "

        #region " 事务前数据检查 "
        private bool CheckCondition(string FuncName)
        {

            switch (ComFunc.Trim(FuncName))
            {
                case "btnQuery":

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

        
        private void FrmOQAShipListPrint_Load(object sender, EventArgs e)
        {
            if (txtShowShipID.Text != "")
            {
                if (QueryPKGSHPInfo(GlobConst.TRAN_VIEW, '1', txtShowShipID.Text) == false) return;
            }
            
            dtFromTime.Value = DateTime.Now.AddDays(-7);
            this.reportViewer2.LocalReport.DataSources.Clear();
            btnQuery.PerformClick();

        }

        //二维码转化
        private string GenerateBarCodeByZen(string codeContent)
        {
            CodeQrBarcodeDraw qrcode = BarcodeDrawFactory.CodeQr;
            Image img = qrcode.Draw(codeContent, qrcode.GetDefaultMetrics(40));
            return img.ImageToBytes().ToBase64();

        }

        private List<PKGSHPSTS> lstShip;
        private List<PKGSHPDAT> lstShipList;
        private bool QueryPKGSHPInfo(char c_proc_step, char c_tran_flag,string in_ship_no)
        {
            ModelRsp<PKGShipView> in_node = new ModelRsp<PKGShipView>();
            PKGShipView in_data = new PKGShipView();

            in_data.C_PROC_STEP = c_proc_step;
            in_data.C_TRAN_FLAG = c_tran_flag;
            in_data.IN_SHIP_NO = in_ship_no;

            in_node.model = in_data;

            var out_data = OQASrv.Call.QryPKGShipInfo(in_node);
            var out_data_ship = OQASrv.Call.QryPKGShipSummaryInfo(in_node);

            if (out_data._success == true)
            {
                lstShip = out_data_ship.model.PKGSHP_list;
                lstShipList = out_data.model.PKGSHPDAT_list;

                this.reportViewer2.LocalReport.SetParameters(GenerateLabelParameters());
                this.reportViewer2.LocalReport.DataSources.Clear();
                var dataSource = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", GenerateLabelDatasource());
                this.reportViewer2.LocalReport.DataSources.Add(dataSource);


                reportViewer2.RefreshReport();
                ComFunc.InitListView(lisship, true);
          //      txtCount.Text = out_data.model.PKGSHPDAT_list.Count.ToString();
                  
                for (int i = 0; i < out_data.model.PKGSHPDAT_list.Count; i++)
                {

                    ListViewItem list_item = new ListViewItem();
                    PKGSHPDAT list = out_data.model.PKGSHPDAT_list[i];
                    list_item.Text = list.LotId;
                    list_item.SubItems.Add(list.Qty);
                    list_item.SubItems.Add(list.PartId);
                    list_item.SubItems.Add(list.InspectResult);
                    lisship.Items.Add(list_item);
                   

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

        //表头打印
        public List<ReportParameter> GenerateLabelParameters()
        {
            List<ReportParameter> lstParam = new List<ReportParameter>();

            if (lstShip.Count > 0)
            {
                string Partid = lstShip[0].PartId.ToString();
                string Shipdate = lstShip[0].ShipDate;
                string Qty = lstShip[0].Qty.ToString();
                string codePackedDate = GenerateBarCodeByZen(lstShip[0].ShipId.ToString());

                lstParam.Add(new ReportParameter("ParameterPartID", Partid));
                lstParam.Add(new ReportParameter("ParamWaferQty", Qty));
                lstParam.Add(new ReportParameter("ParamDate", Shipdate));
                lstParam.Add(new ReportParameter("ParameterBarcode", codePackedDate));
            }
            else
            {

                lstParam.Add(new ReportParameter("ParameterPartID", string.Empty));
                lstParam.Add(new ReportParameter("ParamWaferQty", string.Empty));
                lstParam.Add(new ReportParameter("ParamDate", string.Empty));
                lstParam.Add(new ReportParameter("ParameterBarcode", string.Empty));
            }
            return lstParam;
        }
        //绑定DATASET1
        public List<FrmOQAShipListPrintData> GenerateLabelDatasource()
        {
            List<FrmOQAShipListPrintData> result = new List<FrmOQAShipListPrintData>();

            if (lstShipList.Count > 0)
            {

                for (int index = 0; index < lstShipList.Count; index++)
                {
                    int No = index + 1;
                    string Lotid = lstShipList[index].LotId.ToString();
                    string Qty = lstShipList[index].Qty;
                    string InspectResult = lstShipList[index].InspectResult;
                    result.Add(new FrmOQAShipListPrintData() { No = No.ToString(), LotID = Lotid, LotQty = Qty, InspectionResult = InspectResult, Remark = "" });
                }
            }
            else {
                result.Add(new FrmOQAShipListPrintData() { No = "", LotID = "", LotQty = "", InspectionResult = "", Remark = "" });
            }

            return result;
        }

        //private void btnQuery_Click_1(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (CheckCondition("btnQuery") == false) return;

        //        ship_no = txtShipNo.Text.Trim();
        //        this.reportViewer2.LocalReport.DataSources.Clear();

        //        if (QueryPKGSHPInfo(GlobConst.TRAN_VIEW, '1', ship_no) == false)
        //            return;


        //       // ship_no = txtShipNo.Text.Trim();
        //       //// ship_no = "12453";
        //       // if (QueryPKGSHPInfo(GlobConst.TRAN_VIEW, '1', ship_no) == false) return;

        //    }
        //    catch (System.Exception ex)
        //    {
        //        MessageBox.Show(ex.Message.ToString());
        //    }
        //}

        //checkshipid单选
        private void CheckShipID_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            txtShowShipID.Text = "";
            shipID = CheckShipID.SelectedItem.ToString();
            if (CheckShipID.CheckedItems.Count > 0)
            {
                for (int i = 0; i < CheckShipID.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        CheckShipID.SetItemCheckState(i, System.Windows.Forms.CheckState.Unchecked);
                    }
                }
            }


            if (e.NewValue == CheckState.Unchecked)
            {
                clean();
                return;
            }

            if (QueryPKGSHPInfo(GlobConst.TRAN_VIEW, '1', shipID) == false) return;
        }

        private bool QueryShipIDList(char c_proc_step, char c_tran_flag)
        {
            ModelRsp<ShipIDListView> in_node = new ModelRsp<ShipIDListView>();
            ShipIDListView in_data = new ShipIDListView();

            in_data.C_PROC_STEP = c_proc_step;
            in_data.C_TRAN_FLAG = c_tran_flag;

            in_node.model = in_data;

            var out_data = OQASrv.Call.QueryShipIDList(in_node);

            if (out_data._success == true)
            {
                //ComFunc.(LotIDList, true);
                //      txtCount.Text = out_data.model.PKGSHPDAT_list.Count.ToString();

                List<PKGSHPSTS> SortByTime = out_data.model.SHIPIDLIST_list.OrderBy(o => o.CreateTime).ToList();
                for (int i = 0; i < SortByTime.Count; i++)
                {
                    ListViewItem list_item = new ListViewItem();
                    PKGSHPSTS list = SortByTime[i];
                    list_item.Text = list.ShipId;
                    CheckShipID.Items.Add(list_item.Text);
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

        //搜索shipid
        private void textBox1Press_check(object sender, KeyPressEventArgs e)
        {
            //LotQueryShipId = TxtLotQueryShipID.Text;
            if (e.KeyChar == (Char)13)
            {
                btnQuery.PerformClick();
                txtLotFilter.Focus();

            }

        }
        //LOTID查询shipid
        private bool SearchShipIDList(char c_proc_step, char c_tran_flag, string s_ship_id,string s_lot_id,string s_from_time,string s_to_time)
        {
            ModelRsp<ShipIDListView> in_node = new ModelRsp<ShipIDListView>();
            ShipIDListView in_data = new ShipIDListView();

            in_data.C_PROC_STEP = c_proc_step;
            in_data.C_TRAN_FLAG = c_tran_flag;
            in_data.IN_SEARCHSHIP_NO = s_ship_id;
            in_data.IN_LOT_ID = s_lot_id;
            in_data.IN_FROM_TIME = s_from_time;
            in_data.IN_TO_TIME = s_to_time;
            in_node.model = in_data;

            var out_data = OQASrv.Call.QueryShipIDList(in_node);


            if (out_data._success == true)
            {
                CheckShipID.Items.Clear();
                for (int i = 0; i < out_data.model.SEARCHshipID_list.Count; i++)
                {
                    ListViewItem list_item = new ListViewItem();

                    list_item.Text = out_data.model.SEARCHshipID_list[i][0].ToString();
                    CheckShipID.Items.Add(list_item.Text);

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

        //选择时间
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //    if (lstShip != null)
            //    {
            //        clean();
            //    }
            //    txtLotFilter.Text = "";
           
        //    //if (ComFunc.Trim(searchbydate) != "")
        //    //{
        //        if (SearchShipIDListByDate(GlobConst.TRAN_VIEW, '1', searchbydate,) == false) return;
        //    //}
        //    //else
        //    //{
        //    //    CheckShipID.Items.Clear();
        //    //    if (QueryShipIDList(GlobConst.TRAN_VIEW, '1') == false) return;
        //    //    // MessageBox.Show("输入要查询的shipID");
        //    //}
        }

        //search shipid by date
        //private bool SearchShipIDListByDate(char c_proc_step, char c_tran_flag, string searchshipidbydate,string A)
        //{
        //    ModelRsp<ShipIDListView> in_node = new ModelRsp<ShipIDListView>();
        //    ShipIDListView in_data = new ShipIDListView();

        //    in_data.C_PROC_STEP = c_proc_step;
        //    in_data.C_TRAN_FLAG = c_tran_flag;
        //   // in_data.IN_SEARCHBYDATE_NO = searchshipidbydate;
        //    in_node.model = in_data;

        //    var out_data = OQASrv.Call.QueryShipIDList(in_node);


        //    if (out_data._success == true)
        //    {
        //        CheckShipID.Items.Clear();
        //        for (int i = 0; i < out_data.model.SEARCHshipID_list.Count; i++)
        //        {
        //            ListViewItem list_item = new ListViewItem();

        //            list_item.Text = out_data.model.SEARCHshipID_list[i][0].ToString();
        //            CheckShipID.Items.Add(list_item.Text);

        //        }
        //        lblSucessMsg.Text = out_data._MsgCode;
        //        return true;
        //    }
        //    else
        //    {
        //        MessageBox.Show(out_data._ErrorMsg);
        //        return false;
        //    }
        //}
        private void clean()
        {
            ComFunc.InitListView(lisship, true);
            lstShip.Clear();
            this.reportViewer2.LocalReport.SetParameters(GenerateLabelParameters());
            this.reportViewer2.LocalReport.DataSources.Clear();
            lstShipList.Clear();
            var dataSource = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", GenerateLabelDatasource());
            this.reportViewer2.LocalReport.DataSources.Add(dataSource);
            reportViewer2.RefreshReport();
            return;
        } 

        private void btnQuery_Click(object sender, EventArgs e)
        {
              string s_to_time = null;
              string s_from_time = null;

            if (dtToTime.Enabled == true)
            {
                 s_to_time = dtToTime.Value.ToString("yyyyMMdd");

            }
            if (dtFromTime.Enabled == true)
            {
                 s_from_time = dtFromTime.Value.ToString("yyyyMMdd");

            }

            if (SearchShipIDList(GlobConst.TRAN_VIEW, '1', txtShipFilter.Text.Trim(), txtLotFilter.Text.Trim(), s_from_time, s_to_time) == false) return;


        }

        private void chkFromUse_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFromUse.Checked == false)
            {
                dtFromTime.Enabled = false;
            }
            else
            {
                dtFromTime.Enabled = true;
            }
        }

        private void chkToUse_CheckedChanged(object sender, EventArgs e)
        {
            if (chkToUse.Checked == false)
            {
                dtToTime.Enabled = false;
            }
            else
            {
                dtToTime.Enabled = true;
            }
        }

        private void txtLotFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtLotFilter.Text != "")
            {
                clean();
                btnQuery.PerformClick();
            }
            else {
                btnQuery.PerformClick();
            }
           
        }

        private void dtFromTime_ValueChanged(object sender, EventArgs e)
        {

            if (dtFromTime.Value >= dtToTime.Value && dtToTime.Enabled == true)
            {
                MessageBox.Show("起始日期不能超过截至日期.");
                dtFromTime.Value = DateTime.Now.AddDays(-7);
            }
        }

        private void dtToTime_ValueChanged(object sender, EventArgs e)
        {
            if (dtToTime.Value <= dtFromTime.Value && dtFromTime.Enabled == true)
            {
                MessageBox.Show("起始日期不能超过截至日期.");
                dtToTime.Value = DateTime.Now.Date;
            }
        }

        private void FrmOQAShipListPrint_Shown(object sender, EventArgs e)
        {

        }
    }
}