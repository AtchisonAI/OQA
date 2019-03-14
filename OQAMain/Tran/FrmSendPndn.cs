using Syncfusion.Windows.Forms;
using OQA_Core;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WCFModels.Message;
using WCFModels.OQA;

namespace OQAMain
{
    public partial class FrmDefectSend : OQABaseForm
    {
        #region " Windows Form auto generated code "
        public FrmDefectSend()
        {
            InitializeComponent();
        }
        #endregion


        #region " Constant Definition "
        //private bool b_load_flag = false;
        private decimal Trans_Seq = 0;
        #endregion


        #region " Variable Definition "
        //private bool b_load_flag  ;
        private List<ISPLOTSTS> _ispLotSts = new List<ISPLOTSTS>();
        #endregion


        #region " Function Definition "

        #region " 事务前数据检查 "
        private bool CheckCondition(string FuncName)
        {

            switch (ComFunc.Trim(FuncName))
            {
                case "CREATE":

                    if (ComFunc.CheckValue(txtLotId, 1) == false)
                    {
                        MessageBox.Show("请填写Lot ID！");
                        return false;
                    }
                    if (ComFunc.CheckValue(txtHoldCode, 1) == false)
                    {
                        MessageBox.Show("请填写Hold Code！");
                        return false;
                    }
                    if (ComFunc.CheckValue(txtHoldCmt, 1) == false)
                    {
                        MessageBox.Show("请填写Hold Comment！");
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



        private bool QryLotIspStsInfo(char c_proc_step, char c_tran_flag)
        {
            ModelRsp<LotSlotidView> in_node = new ModelRsp<LotSlotidView>();
            LotSlotidView in_data = new LotSlotidView();

            in_data.C_PROC_STEP = c_proc_step;
            in_data.C_TRAN_FLAG = c_tran_flag;
            in_data.IN_LOT_ID = txtLotId.Text.Trim();

            in_node.model = in_data;

            var out_data = OQASrv.Call.QryLotIspStsInfo(in_node);
            _ispLotSts = out_data.model.ISPLOTSTS_list;

            if (out_data._success == true)
            {
               
                lblSucessMsg.Text = out_data._MsgCode;
                return true;
            }

            else
            {
                MessageBox.Show(out_data._ErrorMsg);
                return false;
            }
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

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                if (ComFunc.Trim(txtLotId.Text) != "")
                {
                    //QryMesLotInfo
                    if (QryLotIspStsInfo(GlobConst.TRAN_VIEW, '1') == false) return;
                    this.txtPartId.Text = _ispLotSts[0].PartId;
                    this.txtQty.Text = _ispLotSts[0].Qty.ToString();
                    //this.txtStepId.Text = _ispLotSts[0].StepId;
                    //this.txtStepName = _ispLotSts[0].StepName;
                }
            }
        }

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

        private void FrmDefectSend_Load(object sender, EventArgs e)
        {

        }

    }
}