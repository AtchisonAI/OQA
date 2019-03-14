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

namespace OQAMain
{
    public partial class FrmOQAShipListPrint : OQABaseForm
    {
        #region " Windows Form auto generated code "
        public FrmOQAShipListPrint()
        {
            InitializeComponent();
        }

        #endregion


        #region " Constant Definition "
        //private bool b_load_flag = false;

        #endregion


        #region " Variable Definition "
       // private bool b_load_flag  ;
        private bool Have_flag = false;
        private string ship_no;
        //private string shipID;
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
        
        private void FrmOQAShipListPrint_Load(object sender, EventArgs e)
        {
            txtShipNo.Text = FrmLotTransfer.srtNum.ToString();
   
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
                    list_item.SubItems.Add(list.InspectResult);//修改数据使用
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
                lstParam.Add(new ReportParameter("barcodeImage", string.Empty));
            }
            return lstParam;
        }
        //绑定DATASET1
        public List<FrmOQAShipListPrintData> GenerateLabelDatasource()
        {
            List<FrmOQAShipListPrintData> result = new List<FrmOQAShipListPrintData>();

            for (int index = 0; index < lstShipList.Count; index++) {
                int No = index+1;
                string Lotid = lstShipList[index].LotId.ToString();
                string Qty = lstShipList[index].Qty;
                string InspectResult = lstShipList[index].InspectResult;
                result.Add(new FrmOQAShipListPrintData() { No = index.ToString(), LotID = Lotid, LotQty = Qty, InspectionRequest = InspectResult, Remark="" });
            }

            return result;
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            try
            {
                //检查数据
                // if (CheckCondition("TypeView") == false) return;

                //调用事务服务
                  ship_no = txtShipNo.Text.Trim();
               // ship_no = "12453";
                if (QueryPKGSHPInfo(GlobConst.TRAN_VIEW, '1', ship_no) == false) return;

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
       
    }
}