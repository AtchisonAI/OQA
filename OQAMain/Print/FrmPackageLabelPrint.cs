using Syncfusion.Windows.Forms;
using OQA_Core;
using System;
using System.Windows.Forms;
using System.IO;
using Microsoft.Reporting.WinForms;
using System.Linq;
using WCFModels.Message;
using WCFModels.OQA;
using HiDM.LabelPrinting.Common.Extension;
using WcfClientCore.Utils.Authority;

namespace OQAMain
{
    public partial class FrmPackageLabelPrint : OQABaseForm
    {
        #region " Windows Form auto generated code "
        public FrmPackageLabelPrint()
        {
            InitializeComponent();
        }

        public FrmPackageLabelPrint(string sLotId)
        {
            InitializeComponent();
            this.txtLotID.Text = sLotId;
        }

        #endregion


        #region " Constant Definition "
        //private bool b_load_flag = false;

        #endregion


        #region " Variable Definition "
        //private bool b_load_flag  ;
        private string lotid;
        private enum PKG_LIST
        {
            slot_id = 0,
            qty,
            lot_id,
            part_id,
            part_desc,
            rec_user,
            customer_id,
            cust_lot_id,
            cust_part_id,
            orignal_country,                 //8  
            qa_stamp
        }
        #endregion


        #region " Function Definition "

        #region " 事务前数据检查 "
        private bool CheckCondition(string FuncName)
        {

            switch (ComFunc.Trim(FuncName))
            {
                case "Print":

                    if (ComFunc.CheckValue(txtLotID, 1) == false)
                    {
                        MessageBox.Show("必填内容输入为空！");
                        txtLotID.Focus();
                        return false;
                    }

                   

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



        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (CheckCondition("Print") == false) return;

            lotid = txtLotID.Text.Trim();
            this.reportViewer1.LocalReport.DataSources.Clear();

            if (QueryPKGLabelInfo(GlobConst.TRAN_VIEW, '1', lotid) == false)
                return;
        
        }

        private void FrmPackageLabelPrint_Load(object sender, EventArgs e)
        {
            
            if (ComFunc.Trim(txtLotID.Text) != "") {
                lotid = txtLotID.Text.Trim();
                this.reportViewer1.LocalReport.DataSources.Clear();
                if (QueryPKGLabelInfo(GlobConst.TRAN_VIEW, '1', lotid) == false)
                    return;
            }
        }

        private bool QueryPKGLabelInfo(char c_proc_step, char c_tran_flag, string in_lotid)
        {



            ModelRsp<PKGLabelPrintView> in_node = new ModelRsp<PKGLabelPrintView>();
            PKGLabelPrintView in_data = new PKGLabelPrintView();

            in_data.C_PROC_STEP = c_proc_step;
            in_data.C_TRAN_FLAG = c_tran_flag;
            in_data.IN_LOTID = in_lotid;

            in_node.model = in_data;

            var out_data = OQASrv.Call.QueryPKGLabelInfo(in_node);
            
            if (out_data._success == true)
            {
                //this.reportViewer1.LocalReport.DataSources.Clear();
                string PartNOBarcode=string.Empty; ;
                string LotIdBarcode =string.Empty;
                string QuantityBarcode = string.Empty;
                string PartNameBarcode = string.Empty;
                string Slot = string.Empty;
                string CustomerId = string.Empty;
                string CustLotid = string.Empty;
                string CustPartid = string.Empty;
                string LotId = string.Empty;
                string OrignalCountry = string.Empty;
                string PartName = string.Empty;
                string PartNo = string.Empty;
                string QAstamp = string.Empty;
                string Quantity = string.Empty;
              

                if (out_data.model.PKGLabel_list.Count() > 0)
                {
                    Slot = out_data.model.PKGLabel_list[0][(int)PKG_LIST.slot_id].ToString();
                    CustomerId = out_data.model.PKGLabel_list[0][(int)PKG_LIST.customer_id].ToString();
                    CustLotid = out_data.model.PKGLabel_list[0][(int)PKG_LIST.cust_lot_id].ToString();
                    CustPartid = out_data.model.PKGLabel_list[0][(int)PKG_LIST.cust_part_id].ToString();
                    LotId = out_data.model.PKGLabel_list[0][(int)PKG_LIST.lot_id].ToString();
                    OrignalCountry = out_data.model.PKGLabel_list[0][(int)PKG_LIST.orignal_country].ToString();
                    PartName = out_data.model.PKGLabel_list[0][(int)PKG_LIST.part_desc].ToString();
                    PartNo = out_data.model.PKGLabel_list[0][(int)PKG_LIST.part_id].ToString();
                    QAstamp = AuthorityControl.GetUserProfile().userId;
                    Quantity = out_data.model.PKGLabel_list[0][(int)PKG_LIST.qty].ToString();

                    PartNOBarcode = out_data.model.PKGLabel_list[0][(int)PKG_LIST.part_id].ToString().ToBarcode39().ImageToBytes().ToBase64();
                    LotIdBarcode = out_data.model.PKGLabel_list[0][(int)PKG_LIST.lot_id].ToString().ToBarcode39().ImageToBytes().ToBase64();
                    QuantityBarcode = out_data.model.PKGLabel_list[0][(int)PKG_LIST.qty].ToString().ToBarcode39().ImageToBytes().ToBase64();
                    PartNameBarcode = out_data.model.PKGLabel_list[0][(int)PKG_LIST.part_desc].ToString().ToBarcode39().ImageToBytes().ToBase64();
                }
                else {    
                    MessageBox.Show("输入的lotid有问题！");
                    txtLotID.Focus();
                    return false;
                }
                reportViewer1.LocalReport.SetParameters(new ReportParameter("paramSlot", Slot));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("paramCustomerId", CustomerId));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("paramCustLotid", CustLotid));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("paramCustPartid", CustPartid));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("paramLotId", LotId));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("paramOrignalCountry", OrignalCountry));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("paramPartName", PartName));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("paramPartNo", PartNo));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("paramQAstamp", QAstamp));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("paramQuantity", Quantity));

                reportViewer1.LocalReport.SetParameters(new ReportParameter("paramPartNOBarcode", PartNOBarcode));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("paramLotIdBarcode", LotIdBarcode));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("paramQuantityBarcode", QuantityBarcode));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("paramPartNameBarcode", PartNameBarcode));
                this.reportViewer1.RefreshReport();


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

        private void TxtLotPress_check(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (Char)13)
            {

                if (ComFunc.Trim(txtLotID.Text) != "")
                {

                    Print.PerformClick();
                }
            }
        }

    }
}