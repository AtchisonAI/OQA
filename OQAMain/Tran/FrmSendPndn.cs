using Syncfusion.Windows.Forms;
using OQA_Core;
using System;
using System.Collections.Generic;
using System.Data;
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

        public FrmDefectSend(string sLotId)
        {
            InitializeComponent();
            this.txtLotId.Text = sLotId;
        }


        #endregion


        #region " Constant Definition "
        //private bool b_load_flag = false;
        private decimal Trans_Seq = 0;
        #endregion


        #region " Variable Definition "
        //private bool b_load_flag  ;
        private List<ISPLOTSTS> _ispLotSts = new List<ISPLOTSTS>();
        private List<ISPWAFDFT> _ispwafdft = new List<ISPWAFDFT>();

        private enum Dft_List
        {
            lot_id = 0,
            inspect_type,
            defect_code,
            slot_id

        }
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

        
        private List<object[]> lsIspwafdfts = new List<object[]>();
        private bool QryIspDftInfo(char c_proc_step, char c_tran_flag)
        {
            ModelRsp<IspWafDftView> in_node = new ModelRsp<IspWafDftView>();
            IspWafDftView in_data = new IspWafDftView();

            in_data.C_PROC_STEP = c_proc_step;
            in_data.C_TRAN_FLAG = c_tran_flag;
            in_data.IN_LOTID = txtLotId.Text.Trim();
            

            in_node.model = in_data;

            var out_data = OQASrv.Call.QryIspDftInfo(in_node);
            lsIspwafdfts = out_data.model.Ispwafdft_list;
            
            dataGridView1.Rows.Clear();
            DataGridViewRow dt = new DataGridViewRow();
            if (out_data._success == true)
            {
                int Scount = out_data.model.Ispwafdft_list.Count;
               

                if (out_data.model.Ispwafdft_list.Count > 0)
                {
                    for (int i = 0; i < Scount; i++)
                    {
                        int idx = dataGridView1.Rows.Add();
                        dt = dataGridView1.Rows[idx];
                        dt.Cells[0].Value = i+1;
                        dt.Cells[1].Value = "";
                        dt.Cells[2].Value = "";
                        dt.Cells[3].Value = out_data.model.Ispwafdft_list[i][(int)Dft_List.inspect_type].ToString();
                        dt.Cells[4].Value = out_data.model.Ispwafdft_list[i][(int)Dft_List.defect_code].ToString();
                        dt.Cells[5].Value = out_data.model.Ispwafdft_list[i][(int)Dft_List.slot_id].ToString();
                        dt.Cells[6].Value = "";
                        dt.Cells[7].Value = "";
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

        private bool IstPndnInfo(char c_proc_step, char c_tran_flag, string c_lot_id, List<OUT_PNDN> lsOutPndns, decimal TransSeq)
        {
            ModelRsp<LotPndnInfoSave> in_node = new ModelRsp<LotPndnInfoSave>();
            LotPndnInfoSave in_data = new LotPndnInfoSave();

            in_data.C_PROC_STEP = c_proc_step;
            in_data.C_TRAN_FLAG = c_tran_flag;
            //in_data. = TransSeq; //事务控制
            in_data.PndnList = lsOutPndns;
            in_data.IN_LOT_ID = c_lot_id;

            in_node.model = in_data;

            var out_data = OQASrv.Call.IstPndnInfo(in_node);

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
                    //Lotid正确带出来料表中的信息
                    if (QryLotIspStsInfo(GlobConst.TRAN_VIEW, '1') == false) return;
                    this.txtPartId.Text = _ispLotSts[0].PartId;
                    this.txtQty.Text = _ispLotSts[0].Qty.ToString();
                    //this.txtStepId.Text = _ispLotSts[0].StepId;
                    //this.txtStepName = _ispLotSts[0].StepName;
                    if (QryIspDftInfo(GlobConst.TRAN_VIEW, '1') == false) return;
                    //
                }
            }
        }

        private List<OUT_PNDN> lsOutPndns = new List<OUT_PNDN>();

        private void btnCreate_Click(object sender, EventArgs e)
        {
            lsOutPndns.Clear();
            try
            {
                //检查数据
                if (CheckCondition("CREATE") == false) return;
                for (int i = 0; i < lsIspwafdfts.Count; i++)
                {
                    OUT_PNDN item = new OUT_PNDN();
                    
                    item.LotId = txtLotId.Text;
                    item.PartId = txtPartId.Text;
                    item.Qty = txtQty.Text.ToDecimal();
                    //item.StepId = txtStepId.Text;
                    //item.StepName = txtStepName.Text;
                    
                    item.HoldCode = txtHoldCode.Text;
                    item.HoldComment = txtHoldCmt.Text;

                    //item.PndnNo = dataGridView1.Rows[i].Cells[dataGridViewTextBoxColumn1.Name].Value.ToString();
                    //item.Dept = dataGridView1.Rows[i].Cells[dataGridViewTextBoxColumn2.Name].Value.ToString();
                    item.InspectType = dataGridView1.Rows[i].Cells[dataGridViewTextBoxColumn3.Name].Value.ToString();
                    item.DefectCode = dataGridView1.Rows[i].Cells[dataGridViewTextBoxColumn4.Name].Value.ToString();
                    item.SlotId = dataGridView1.Rows[i].Cells[dataGridViewTextBoxColumn5.Name].Value.ToString();
                    //item.Spec = dataGridView1.Rows[i].Cells[dataGridViewTextBoxColumn6.Name].Value.ToString();
                    //item.Remark = dataGridView1.Rows[i].Cells[dataGridViewTextBoxColumn7.Name].Value.ToString();
                    
                    item.UserId = txtOperatorNo.Text;
                    //item.SupervisorId = txtSupervisorNo.Text;


                    lsOutPndns.Add(item);
                }

                string s_lot_id = ComFunc.Trim(txtLotId.Text);
                
                if (IstPndnInfo(GlobConst.TRAN_CREATE, '1', s_lot_id, lsOutPndns, Trans_Seq) == false) return;
                
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void FrmDefectSend_Load(object sender, EventArgs e)
        {

        }

        private void btnEdite_Click(object sender, EventArgs e)
        {

        }
    }
}