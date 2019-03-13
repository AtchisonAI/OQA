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
                lotid = txtLotID.Text.Trim();
                this.reportViewer1.LocalReport.DataSources.Clear();
                if (QueryPKGLabelInfo(GlobConst.TRAN_VIEW, '1', lotid) == false)
                    return;


            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void FrmPackageLabelPrint_Load(object sender, EventArgs e)
        {

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
                if (out_data.model.PKGLabel_list.Count() > 0)
                {
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("paramSlot", out_data.model.PKGLabel_list[0][(int)PKG_LIST.slot_id].ToString()));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("paramCustomerId", out_data.model.PKGLabel_list[0][(int)PKG_LIST.customer_id].ToString()));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("paramCustLotid", out_data.model.PKGLabel_list[0][(int)PKG_LIST.cust_lot_id].ToString()));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("paramCustPartid", out_data.model.PKGLabel_list[0][(int)PKG_LIST.cust_part_id].ToString()));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("paramLotId", out_data.model.PKGLabel_list[0][(int)PKG_LIST.lot_id].ToString()));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("paramOrignalCountry", out_data.model.PKGLabel_list[0][(int)PKG_LIST.orignal_country].ToString()));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("paramPartName", out_data.model.PKGLabel_list[0][(int)PKG_LIST.part_desc].ToString()));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("paramPartNo", out_data.model.PKGLabel_list[0][(int)PKG_LIST.part_id].ToString()));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("paramQAstamp", out_data.model.PKGLabel_list[0][(int)PKG_LIST.qa_stamp].ToString()));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("paramQuantity", out_data.model.PKGLabel_list[0][(int)PKG_LIST.qty].ToString()));


                    string PartNOBarcode = out_data.model.PKGLabel_list[0][(int)PKG_LIST.part_id].ToString().ToBarcode39().ImageToBytes().ToBase64();
                    string LotIdBarcode = out_data.model.PKGLabel_list[0][(int)PKG_LIST.lot_id].ToString().ToBarcode39().ImageToBytes().ToBase64();
                    string QuantityBarcode = out_data.model.PKGLabel_list[0][(int)PKG_LIST.qty].ToString().ToBarcode39().ImageToBytes().ToBase64();
                    string PartNameBarcode = out_data.model.PKGLabel_list[0][(int)PKG_LIST.part_desc].ToString().ToBarcode39().ImageToBytes().ToBase64();

                    reportViewer1.LocalReport.SetParameters(new ReportParameter("paramPartNOBarcode", PartNOBarcode));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("paramLotIdBarcode", LotIdBarcode));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("paramQuantityBarcode", QuantityBarcode));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("paramPartNameBarcode", PartNameBarcode)); 
                }
                else {
                    MessageBox.Show("输入的lotid有问题！");

                }
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
                    btnCreate.PerformClick();
                }
            }
        }

    }
}