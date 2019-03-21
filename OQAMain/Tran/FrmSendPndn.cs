using Syncfusion.Windows.Forms;
using OQA_Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.EnterpriseServices;
using System.Windows.Forms;
using WcfClientCore.Utils.Authority;
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
                    if (ComFunc.CheckValue(txtOperatorNo, 1) == false)
                    {
                        MessageBox.Show("请填写Operator NO！");
                        return false;
                    }
                    if (ComFunc.CheckValue(txtSupervisorNo, 1) == false)
                    {
                        MessageBox.Show("请填写Supervisor NO！");
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
            
            if (out_data._success == true)
            {
                this.txtPartId.Text = out_data.model.ISPLOTSTS_list[0].PartId;
                this.txtQty.Text = out_data.model.ISPLOTSTS_list[0].Qty.ToString();
                //this.txtStepId.Text = out_data.model.ISPLOTSTS_list[0].StepId.;
                //this.txtStepName = out_data.model.ISPLOTSTS_list[0].StepName;

                lblSucessMsg.Text = out_data._MsgCode;
                return true;
            }

            else
            {
                ClearData("2");
                MessageBox.Show(out_data._ErrorMsg);
                return false;
            }
        }


        public bool isInOut_Pndn= false;
        
        private List<OUT_PNDN> lsPndnInfo = new List<OUT_PNDN>();
        private bool QryPndnInfo(char c_proc_step, char c_tran_flag)
        {
            ModelRsp<LotPndnInfoView> in_node = new ModelRsp<LotPndnInfoView>();
            LotPndnInfoView in_data = new LotPndnInfoView();

            in_data.C_PROC_STEP = c_proc_step;
            in_data.C_TRAN_FLAG = c_tran_flag;
            in_data.IN_LOT_ID = txtLotId.Text.Trim();


            in_node.model = in_data;

            var out_data = OQASrv.Call.QryPndnInfo(in_node);
            lsPndnInfo = out_data.model.PndnList;

            dataGridView1.Rows.Clear();
            DataGridViewRow dt = new DataGridViewRow();
            if (out_data._success == true)
            {
                int Scount = out_data.model.PndnList.Count;


                if (Scount > 0)
                {
                    for (int i = 0; i < Scount; i++)
                    {
                        int idx = dataGridView1.Rows.Add();
                        dt = dataGridView1.Rows[idx];

                        if (out_data.model.PndnList[i].PndnStatus == "Y")
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        }
                        
                        dt.Cells[0].Value = i + 1;
                        dt.Cells[1].Value = out_data.model.PndnList[i].PndnNo.ToString();
                        dt.Cells[2].Value = out_data.model.PndnList[i].Dept.ToString();
                        dt.Cells[2].ReadOnly = true;
                        dt.Cells[3].Value = out_data.model.PndnList[i].InspectType.ToString();
                        dt.Cells[4].Value = out_data.model.PndnList[i].DefectCode.ToString();
                        dt.Cells[5].Value = out_data.model.PndnList[i].SlotId.ToString();
                        dt.Cells[6].Value = out_data.model.PndnList[i].Spec.ToString();
                        dt.Cells[7].Value = out_data.model.PndnList[i].Remark.ToString();
                        txtHoldCode.Text = out_data.model.PndnList[i].HoldCode.ToString();
                        txtHoldCmt.Text = out_data.model.PndnList[i].HoldComment.ToString();
                        txtSupervisorNo.Text = out_data.model.PndnList[i].SupervisorId.ToString();
                    }

                    isInOut_Pndn = true;
                }
                else
                {
                    isInOut_Pndn = false;
                    if (QryIspDftInfo(GlobConst.TRAN_VIEW, '1') == false) return false;
                    
                }

                lblSucessMsg.Text = out_data._MsgCode;
                return true;
            }

            else
            {
                isInOut_Pndn = false;
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
        
        private List<OUT_PNDN> PndnInfoList = new List<OUT_PNDN>();
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
            PndnInfoList = out_data.model.PndnList;
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

        private void ReFresh()
        {
            dataGridView1.Rows.Clear();
            DataGridViewRow dt = new DataGridViewRow();

            if (PndnInfoList.Count > 0)
            {
                for (int i = 0; i < PndnInfoList.Count; i++)
                {
                    int idx = dataGridView1.Rows.Add();
                    dt = dataGridView1.Rows[idx];
                    if (PndnInfoList[i].PndnStatus=="Y")
                    {
                        //dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    }
                    else
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    
                    dt.Cells[0].Value = i + 1;
                    dt.Cells[1].Value = PndnInfoList[i].PndnNo;
                    dt.Cells[2].Value = PndnInfoList[i].Dept;
                    dt.Cells[3].Value = PndnInfoList[i].InspectType;
                    dt.Cells[4].Value = PndnInfoList[i].DefectCode;
                    dt.Cells[5].Value = PndnInfoList[i].SlotId;
                    dt.Cells[6].Value = PndnInfoList[i].Spec;
                    dt.Cells[7].Value = PndnInfoList[i].Remark;
                }
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
                    case "2":
                        //Initialize
                        ComFunc.FieldClear(this,txtLotId,txtOperatorNo);
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
                try
                {
                    if (ComFunc.Trim(txtLotId.Text) != "")
                    {
                        //Lotid正确带出来料表中的信息


                        if (QryLotIspStsInfo(GlobConst.TRAN_VIEW, '1') == false) return;
                        if (QryPndnInfo(GlobConst.TRAN_VIEW, '1') == false) return;


                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
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
                
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    OUT_PNDN item = new OUT_PNDN();

                    item.LotId = txtLotId.Text;
                    item.PartId = txtPartId.Text;
                    item.Qty = txtQty.Text.ToDecimal();
                    //item.StepId = txtStepId.Text;
                    //item.StepName = txtStepName.Text;

                    item.HoldCode = txtHoldCode.Text;
                    item.HoldComment = txtHoldCmt.Text;

                    item.PndnNo = dataGridView1.Rows[i].Cells[dataGridViewTextBoxColumn1.Name].Value.ToString();
                    item.Dept = dataGridView1.Rows[i].Cells[dataGridViewTextBoxColumn2.Name].Value.ToString();
                    item.InspectType = dataGridView1.Rows[i].Cells[dataGridViewTextBoxColumn3.Name].Value.ToString();
                    item.DefectCode = dataGridView1.Rows[i].Cells[dataGridViewTextBoxColumn4.Name].Value.ToString();
                    item.SlotId = dataGridView1.Rows[i].Cells[dataGridViewTextBoxColumn5.Name].Value.ToString();
                    item.Spec = dataGridView1.Rows[i].Cells[dataGridViewTextBoxColumn6.Name].Value.ToString();
                    item.Remark = dataGridView1.Rows[i].Cells[dataGridViewTextBoxColumn7.Name].Value.ToString();

                    item.UserId = txtOperatorNo.Text;
                    item.SupervisorId = txtSupervisorNo.Text;

                    if (string.IsNullOrWhiteSpace(item.Dept) == true)
                    {
                        MessageBox.Show("请输入Dept");
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(item.Spec) == true)
                    {
                        MessageBox.Show("请输入Spec");
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(item.Remark) == true)
                    {
                        MessageBox.Show("请输入Remark");
                        return;
                    }

                    
                    lsOutPndns.Add(item);
                }
                

                string s_lot_id = ComFunc.Trim(txtLotId.Text);


                if (isInOut_Pndn==true)
                {
                    if (IstPndnInfo(GlobConst.TRAN_UPDATE, '1', s_lot_id, lsOutPndns, Trans_Seq) == false) return;
                }
                else
                {
                    if (IstPndnInfo(GlobConst.TRAN_CREATE, '1', s_lot_id, lsOutPndns, Trans_Seq) == false) return;
                }

                if (QryPndnInfo(GlobConst.TRAN_VIEW, '1') == false) return;

                //ReFresh();
                

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void FrmDefectSend_Load(object sender, EventArgs e)
        {
            txtOperatorNo.Text=AuthorityControl.GetUserProfile().userId;
            
        }

        private void btnEdite_Click(object sender, EventArgs e)
        {

        }

        private void txtLotId_MouseDown(object sender, MouseEventArgs e)
        {
            ClearData("2");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearData("1");
        }
    }
}