using Syncfusion.Windows.Forms;
using OQA_Core;
using System;
using System.Windows.Forms;
using WCFModels.OQA;
using WCFModels.Message;
using Microsoft.Reporting.WinForms;
using System.Linq;
using OQAMain.Print;
using System.Collections.Generic;

namespace OQAMain
{
    public partial class FrmWaferInspectRecordPrint : OQABaseForm
    {
        #region " Windows Form auto generated code "
        public FrmWaferInspectRecordPrint()
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



        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {

                
                //检查数据
                if (CheckCondition("Print") == false) return;

                lotid = txtLotID.Text.Trim();

                if (QueryWaferInspectRecordInfo(GlobConst.TRAN_VIEW, '1', lotid) == false)
                    return;
                else
                {
                    this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", new List<WaferInspectRecord_sub>()));
                    this.reportViewer1.RefreshReport();
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

        private void FrmWaferInspectRecordPrint_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
           
            reportViewer1.LocalReport.SubreportProcessing += LocalReport_SubreportProcessing;
        }


        public List<ReportParameter> GenerateLabelParameters()
        {
            List<ReportParameter> lstParam = new List<ReportParameter>();

            if (lstLot.Count > 0)
            {
                string lotID = lstLot[0].LotId;
                string Partid = lstLot[0].PartId.ToString();
                string Qty = lstLot[0].Qty.ToString();
                string Stime = lstLot[0].UpdateTime.ToString();

                lstParam.Add(new ReportParameter("paramLotID", lotID));
                lstParam.Add(new ReportParameter("paramPartID", Partid));
                lstParam.Add(new ReportParameter("paramQTY", Qty));
                lstParam.Add(new ReportParameter("paramDate", Stime));
            }

            return lstParam;
        }


        private void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            if (e.Parameters != null && e.Parameters.Count(p => p.Name == "ReportSeq") == 1)
            {
                var waferSeq = int.Parse(e.Parameters["ReportSeq"].Values[0]);
                e.DataSources.Clear();
                var slotID = Math.Ceiling((decimal)waferSeq / 2);
                var side = waferSeq % 2 ==1?"F":"B";
                var waferdefectcode = new List<WaferInspectRecord_sub>();

            
                

                    if (lstISPWAFDFT.Count(p=>decimal.Parse(p.SlotId)==slotID && p.SideType ==side) > 0)
                {
                    var currentSlotISPWAFDFT = lstISPWAFDFT.Where(p => decimal.Parse(p.SlotId) == slotID && p.SideType == side);

                    for (int idx = 1; idx <= 25; idx++)
                    {
                        string defectCod1 = string.Empty;
                        string defectCod2 = string.Empty;
                        string defectCod3 = string.Empty;
                        string defectCod4 = string.Empty;
                        string defectCod5 = string.Empty;
                        
                        if(currentSlotISPWAFDFT.Count(p=>p.AreaId == idx) >0)
                        {
                            defectCod1 = string.Join(",",currentSlotISPWAFDFT.Where(p => p.AreaId == idx).Select< ISPWAFDFT,string>(p=>p.DefectCode));
                        }
                        idx++;
                        if (currentSlotISPWAFDFT.Count(p => p.AreaId == idx) > 0)
                        {
                            defectCod2 = string.Join(",", currentSlotISPWAFDFT.Where(p => p.AreaId == idx).Select<ISPWAFDFT, string>(p => p.DefectCode));
                        }
                        idx++;
                        if (currentSlotISPWAFDFT.Count(p => p.AreaId == idx) > 0)
                        {
                            defectCod3 = string.Join(",", currentSlotISPWAFDFT.Where(p => p.AreaId == idx).Select<ISPWAFDFT, string>(p => p.DefectCode));
                        }

                        idx++;
                        if (currentSlotISPWAFDFT.Count(p => p.AreaId == idx) > 0)
                        {
                            defectCod4 = string.Join(",", currentSlotISPWAFDFT.Where(p => p.AreaId == idx).Select<ISPWAFDFT, string>(p => p.DefectCode));
                        }
                        idx++;
                        if (currentSlotISPWAFDFT.Count(p => p.AreaId == idx) > 0)
                        {
                            defectCod5 = string.Join(",", currentSlotISPWAFDFT.Where(p => p.AreaId == idx).Select<ISPWAFDFT, string>(p => p.DefectCode));
                        }

                        var waferInspectRecord_sub = new WaferInspectRecord_sub(defectCod1, defectCod2, defectCod3, defectCod4, defectCod5);

                        waferdefectcode.Add(waferInspectRecord_sub);

                    }

                }
                else
                {
                    for (int idx = 1; idx <= 5; idx++)
                    {
                        string defectCod1 = string.Empty;
                        string defectCod2 = string.Empty;
                        string defectCod3 = string.Empty;
                        string defectCod4 = string.Empty;
                        string defectCod5 = string.Empty;

                       
                        var waferInspectRecord_sub = new WaferInspectRecord_sub(defectCod1, defectCod2, defectCod3, defectCod4, defectCod5);

                        waferdefectcode.Add(waferInspectRecord_sub);

                    }
                }
                e.DataSources.Add(new ReportDataSource("DataSet1", waferdefectcode));
            }

            
        }

        private List<ISPWAFDFT> lstISPWAFDFT;
        private List<ISPLOTSTS> lstLot;

        private bool QueryWaferInspectRecordInfo(char c_proc_step, char c_tran_flag,string in_lotid)
        {

           

            ModelRsp<WaferInspectRecordView> in_node = new ModelRsp<WaferInspectRecordView>();
            WaferInspectRecordView in_data = new WaferInspectRecordView();

            in_data.C_PROC_STEP = c_proc_step;
            in_data.C_TRAN_FLAG = c_tran_flag;
            in_data.IN_LOTID = in_lotid;

            in_node.model = in_data;

            var out_data = OQASrv.Call.QueryWaferInspectionRecordInfo(in_node);
            var out_data_lot = OQASrv.Call.QueryLotInfo(in_node);
         //   var DataTableCount = out_data.model.ISPWAFDFT_list.Count;
            if (out_data._success == true)
            {
                lstISPWAFDFT = out_data.model.ISPWAFDFT_list;
                lstLot = out_data_lot.model.LOT_list;

                this.reportViewer1.LocalReport.SetParameters(GenerateLabelParameters());
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


    }
}