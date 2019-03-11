using Syncfusion.Windows.Forms;
using OQA_Core;
using System;
using System.Windows.Forms;
using System.IO;
using Microsoft.Reporting.WinForms;
using System.Linq;

namespace OQAMain
{
    public partial class FrmPackageLabelPrint : OQABaseForm
    {
        #region " Windows Form auto generated code "
        public FrmPackageLabelPrint()
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

             //   if (this.Lotid.Text !="") {
             //       string SLotid = this.Lotid.Text.Trim();

                    //sqlStr= select listagg(t.slot_id, ',') within
                    //                    group(
                    //                    order by slot_id, slot_id) as slot_id, 
                    // count(t.lot_id), 
                    // t.lot_id, 
                    //s.part_id, 
                    //s.part_desc, 
                    //s.rec_user, 
                    //s.customer_id, 
                    //s.cust_lot_id,
                    //s.cust_part_id, 
                    //s.orignal_country
                    //from pkgsltdef t, isplotsts s
                    //where t.lot_id = s.lot_id and t.lotid=:SLotid
                    //group by t.lot_id,
                    //        s.part_id,
                    //       s.part_desc,
                    //      s.rec_user,
                    //     s.customer_id,
                    //    s.cust_lot_id,
                    //   s.cust_part_id,
                    //  s.orignal_country

                //    this.reportViewer1.LocalReport.SetParameters(GenerateLabelParameters(help.GetDataTable(sqlStr, param)));
                    this.reportViewer1.RefreshReport();
              //  }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void FrmPackageLabelPrint_Load(object sender, EventArgs e)
        {
            InitReportViewer("OQAMain.Print.FrmPackageLabelPrint.rdlc");
            this.reportViewer1.RefreshReport();
            
        }

        public void InitReportViewer(string rptName)
        {
            reportViewer1.Reset();
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            //reportViewer1.LocalReport.ReportPath = Path.Combine(rptName);

            this.reportViewer1.LocalReport.ReportEmbeddedResource = rptName;
        //    this.reportViewer1.LocalReport.SubreportProcessing += LocalReport_SubreportProcessing;
            reportViewer1.RefreshReport();
        }

      //  private void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
     //   {
    //       if(e.Parameters!=null && e.Parameters.Count(p=>p.Name == "ReportSeq") == 1)
     //       {
         //       e
    //        }

   //     }

        //public List<ReportParameter> GenerateLabelParameters(System.Data.DataTable dtResult)
        //{
        //    string SlotID = dtResult.Rows[0]["SLOT_ID"].ToString();
        //    string Lotid = dtResult.Rows[0]["LOT_ID"].ToString();
        //    string Partid = dtResult.Rows[0]["PART_ID"].ToString();
        //    string Partname = dtResult.Rows[0]["PART_DESC"].ToString();
        //    string Recuser = dtResult.Rows[0]["REC_USER"].ToString();
        //    string Customerid = dtResult.Rows[0]["CUSTOMER_ID"].ToString();
        //    string Customerlotid = dtResult.Rows[0]["CUST_LOT_ID"].ToString();
        //    string Customerpartid = dtResult.Rows[0]["CUST_PART_ID"].ToString();
        //    string OrignalCountry = dtResult.Rows[0]["ORIGNAL_COUNTRY"].ToString();
        //    string Qty = dtResult.Rows[0]["QTY"].ToString();

        //    string codePartname = Partname.ToBarcode39().ImageToBytes().ToString();
        //    string codePartid = Partid.ToBarcode39().ImageToBytes().ToString();
        //    string codeQty = Qty.ToBarcode39().ImageToBytes().ToString();
        //    string codeLotid = Lotid.ToBarcode39().ImageToBytes().ToString();
        //    List<ReportParameter> lstParam = new List<ReportParameter>();
        //    lstParam.Add(new ReportParameter("paramPartName", Partname));
        //    lstParam.Add(new ReportParameter("paramPartNO2", Partid));
        //    lstParam.Add(new ReportParameter("paramCustomerId", Customerid));
        //    lstParam.Add(new ReportParameter("paramLotId", Lotid));
        //    lstParam.Add(new ReportParameter("paramSlot", SlotID));
        //    lstParam.Add(new ReportParameter("paramQuantity", Qty));
        //    lstParam.Add(new ReportParameter("paramCustLotid", Customerlotid));
        //    lstParam.Add(new ReportParameter("paramOrignalCountry", OrignalCountry));

        //    lstParam.Add(new ReportParameter("paramCustPartid", Customerpartid));
        //    lstParam.Add(new ReportParameter("paramQAstamp", Recuser));
        //    lstParam.Add(new ReportParameter("barcodePartName", codePartname));
        //    lstParam.Add(new ReportParameter("barcodePartNO", codePartid));
        //    lstParam.Add(new ReportParameter("barcodeLotid", codeLotid));
        //    lstParam.Add(new ReportParameter("barcodeQuantity", codeQty));

        //    return lstParam;
        //}
    }
}