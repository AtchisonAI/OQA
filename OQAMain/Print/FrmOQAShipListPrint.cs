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
        //private bool b_load_flag  ;

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
        private string shipID;
        public FrmOQAShipListPrint(string shipID)
        {
            InitializeComponent();
            this.shipID = shipID;
        }
        private void FrmOQAShipListPrint_Load(object sender, EventArgs e)
        {

            textBox1.Text = shipID;
            InitReportViewer("FrmOQAShipListPrint.rdlc");
            //DataTable dtMaster = getShipMasterData(shipID);
            //DataTable dtDetails = getOraclePKGSHPDAT(shipID);

            //this.dataGridView1.DataSource = dtDetails;
            //this.dataGridView1.AllowUserToAddRows = false;

            //this.reportViewer2.LocalReport.DataSources.Clear();
            //var dataSourceList = GenerateLabelDatasource(dtDetails);
            //var dataSource = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dataSourceList);
            //this.reportViewer2.LocalReport.DataSources.Add(dataSource);
            //this.reportViewer2.LocalReport.SetParameters(GenerateLableParamters(dtMaster));
            this.reportViewer2.RefreshReport();
        }
        public void InitReportViewer(string rptName)
        {
            reportViewer2.Reset();
            reportViewer2.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer2.LocalReport.ReportPath = Path.Combine(rptName);
            reportViewer2.RefreshReport();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {

        }
        //private DataTable getOraclePKGSHPDAT(string shipID)
        //{
        //    var sql = string.Format("SELECT A.LOT_ID,A.QTY,A.PART_ID,A.INSPECT_RESULT FROM PKGSHPDAT A WHERE SHIP_ID = '{0}'", shipID); ;
        //    DataTable dataTable = OracleHelp.GetDataTable(sql);

        //    return dataTable;
        //}

        //private DataTable getShipMasterData(string shipID)
        //{
        //    var sql = string.Format("SELECT A.PART_ID,A.QTY,A.SHIP_DATE FROM PKGSHPSTS A WHERE SHIP_ID = '{0}'", shipID); ;
        //    DataTable dataTable = OracleHelp.GetDataTable(sql);

        //    return dataTable;
        //}

        //打印表头内容
        public List<ReportParameter> GenerateLableParamters(System.Data.DataTable dtMaster)
        {
            string PartID1 = dtMaster.Rows[0]["PART_ID"].ToString();
            string Qtysys1 = dtMaster.Rows[0]["QTY"].ToString();
            string Datesys1 = dtMaster.Rows[0]["SHIP_DATE"].ToString();
            string codePackedDate = GenerateBarCodeByZen(shipID);

            List<ReportParameter> lstParam = new List<ReportParameter>();
            lstParam.Add(new ReportParameter("ParameterPartID", PartID1));
            lstParam.Add(new ReportParameter("ParamWaferQty", Qtysys1));
            lstParam.Add(new ReportParameter("ParamDate", Datesys1));

           lstParam.Add(new ReportParameter("ParameterBarcode", codePackedDate));
            return lstParam;
        }
       
        //内容打印
        public List<FrmOQAShipListPrintData> GenerateLabelDatasource(DataTable dtDetails)
        {
            List<FrmOQAShipListPrintData> result = new List<FrmOQAShipListPrintData>();
            int index = 0;
            foreach (DataRow row in dtDetails.Rows)
            {
                index++;
                string lotID = row["LOT_ID"].ToString();
                string qty = row["QTY"].ToString();
                string inspResult = row["INSPECT_RESULT"].ToString();

                result.Add(new FrmOQAShipListPrintData() { No = index.ToString(), LotID = lotID, LotQty = qty, InspectionRequest = inspResult });

            }

            return result;
        }
        //二维码转化
        private string GenerateBarCodeByZen(string codeContent)
        {
            CodeQrBarcodeDraw qrcode = BarcodeDrawFactory.CodeQr;
            Image img = qrcode.Draw(codeContent, qrcode.GetDefaultMetrics(40));
            return img.ImageToBytes().ToBase64();

        }

        private void btnEdite_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}