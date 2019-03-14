using OQA_Core;
using System;
using System.Windows.Forms;
using WCFModels.Message;
using WCFModels.OQA;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;

namespace OQAMain
{
    public partial class FrmFoupChange : OQABaseForm
    {
        #region " Windows Form auto generated code "
        public FrmFoupChange()
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
        private bool Have_Flag = false;
       
        private List<OQA_CHKMESSLOTID> _lsOqaChkmesslotids = new List<OQA_CHKMESSLOTID>();
        private List<PKGSLTDEF> LSOQACHKMESSLOTIDS = new List<PKGSLTDEF>();
        private List<ISPLOTSTS> _ispLotSts= new List<ISPLOTSTS>();


        #endregion


        #region " Function Definition "

        #region " 事务前数据检查 "
        private bool CheckCondition(string FuncName)
        {

            switch (ComFunc.Trim(FuncName))
            {
                case "CHECK":
                    if (ComFunc.CheckValue(txtLotid,1)==false)
                    {
                        foreach (DataGridViewColumn column in dataGridView1.Columns)
                        {
                            dataGridView1.Rows[0].Cells[column.Name].Value = string.Empty;
                        }
                        MessageBox.Show("必填内容输入为空！");
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
            in_data.IN_LOT_ID = txtLotid.Text.Trim();

            in_node.model = in_data;

            var out_data = OQASrv.Call.QryLotIspStsInfo(in_node);
            _ispLotSts = out_data.model.ISPLOTSTS_list;

            if (out_data._success == true)
            {
                //判断Lot是否收料
                if (out_data.model.ISPLOTSTS_list.Count > 0)
                {
                    //判断收料Lot状态是否检验完成
                    if (out_data.model.ISPLOTSTS_list.Count(p => p.Status == "IspOut") == 0)
                    {
                        MessageBox.Show("LOT当前不符合Foup Change状态!!");
                    }
                }
                else
                {
                    MessageBox.Show("LOT当前不符合Foup Change状态!");
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


        private bool QryLotIspSlotidInfo(char c_proc_step, char c_tran_flag,out List<ISPWAFST> lstIspwafsts)
        {
            lstIspwafsts = null;
            ModelRsp<LotSlotidView> in_node = new ModelRsp<LotSlotidView>();
            LotSlotidView in_data = new LotSlotidView();

            in_data.C_PROC_STEP = c_proc_step;
            in_data.C_TRAN_FLAG = c_tran_flag;
            in_data.IN_LOT_ID = txtLotid.Text.Trim();

            in_node.model = in_data;

            var out_data = OQASrv.Call.QryLotIspSlotidInfo(in_node);
            
            

            if (out_data._success == true)
            {
                //dataGridView1.Rows[0].Cells[0].Value = "Match With MES";
                for (int i = 0; i < 25; i++)
                {
                    int j = i + 1;
                    if (out_data.model.ISPWAFST_list.Count(p => p.SlotId == j.ToString().PadLeft(3, '0')) > 0)
                    {
                        dataGridView1.Rows[0].Cells[i].Value = "OK";
                    }
                    else
                    {
                        dataGridView1.Rows[0].Cells[i].Value = "/";
                    }
                }

                lstIspwafsts = out_data.model.ISPWAFST_list;
                lblSucessMsg.Text = out_data._MsgCode;
                return true;
            }
            else
            {
                MessageBox.Show(out_data._ErrorMsg);
                return false;
            }
        }
        

        private bool QryLotMesSlotidInfo(char c_proc_step, char c_tran_flag, out List<OQA_CHKMESSLOTID> lsOqaChkmesslotids)
        {
            lsOqaChkmesslotids = null;
            ModelRsp<LotSlotidView> in_node = new ModelRsp<LotSlotidView>();
            LotSlotidView in_data = new LotSlotidView();

            in_data.C_PROC_STEP = c_proc_step;
            in_data.C_TRAN_FLAG = c_tran_flag;
            in_data.IN_LOT_ID = txtLotid.Text.Trim();

            in_node.model = in_data;
            
            var out_data = OQASrv.Call.QryLotMesSlotidInfo(in_node);

            if (out_data._success == true)
            {


                lsOqaChkmesslotids = out_data.model.OQA_CHKMESSLOTID_list;
                //ListViewItem list_item = new ListViewItem();
                //list_item.Text = list.SlotId;
                //list_item.SubItems.Add(list.TransSeq.ToString());//修改数据使用
                //LstIspCode.Items.Add(list_item);

                lblSucessMsg.Text = out_data._MsgCode;
                return true;
            }
            else
            {
                MessageBox.Show(out_data._ErrorMsg);
                return false;
            }
        }


        private bool IstLotSltInfo(char c_proc_step, char c_tran_flag, string c_lot_id, List<PKGSLTDEF> LSOQACHKMESSLOTIDS,decimal TransSeq)
        {
            ModelRsp<LotSlotidSave> in_node = new ModelRsp<LotSlotidSave>();
            LotSlotidSave in_data = new LotSlotidSave();

            in_data.C_PROC_STEP = c_proc_step;
            in_data.C_TRAN_FLAG = c_tran_flag;
            //in_data. = TransSeq; //事务控制
            in_data.PkgsltdefList = LSOQACHKMESSLOTIDS;
            in_data.IN_LOT_ID = c_lot_id;

            in_node.model = in_data;

            var out_data = OQASrv.Call.IstLotSltInfo(in_node);

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


        private bool UptLotIspStsInfo(char c_proc_step, char c_tran_flag, string c_lot_id, decimal TransSeq)
        {
            ModelRsp<LotSlotidView> in_node = new ModelRsp<LotSlotidView>();
            LotSlotidView in_data = new LotSlotidView();

            in_data.C_PROC_STEP = c_proc_step;
            in_data.C_TRAN_FLAG = c_tran_flag;
            in_data.D_TRANSSEQ = TransSeq; //事务控制
            in_data.IN_LOT_ID = c_lot_id;

            in_node.model = in_data;

            var out_data = OQASrv.Call.UptLotIspStsInfo(in_node);

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
                if (ComFunc.Trim(txtLotid.Text) != "")
                {
                    btnCheck.PerformClick();
                }
            }
        }

        private void btnCheck_Click(object sender , EventArgs e)
        {
            try
            {
                //检查控件
                if (CheckCondition("CHECK") == false) return;

                List<ISPWAFST> lsIspwafsts = null;
                List<OQA_CHKMESSLOTID> lsOqaChkmesslotids = null;
              
                //调用事务服务
                if (QryLotIspStsInfo(GlobConst.TRAN_VIEW, '1') == false) return;
                if (QryLotIspSlotidInfo(GlobConst.TRAN_VIEW, '1',out lsIspwafsts) == false) return;
                if (QryLotMesSlotidInfo(GlobConst.TRAN_VIEW, '1',out lsOqaChkmesslotids) == false) return;
               
                
                for (int i = 0; i < 25; i++)
                {
                    bool isInIsp = false;
                    dataGridView1.Rows[0].Cells[i].Style.BackColor = Color.White;
                    int j = i + 1;
                    if (lsIspwafsts.Count(p => p.SlotId == j.ToString().PadLeft(3, '0')) > 0)
                    {
                        isInIsp = true;
                    }

                    bool isInMes = lsOqaChkmesslotids.Count(p => p.SlotId == j.ToString().PadLeft(3, '0')) > 0;
                    
                    if (isInMes)
                    {
                        if (isInIsp)
                        {
                            dataGridView1.Rows[0].Cells[i].Value = "OK";
                        }
                        else
                        {
                            dataGridView1.Rows[0].Cells[i].Style.BackColor = Color.Yellow;
                        }
                    }
                    else
                    {
                        if (isInIsp)
                        {
                            dataGridView1.Rows[0].Cells[i].Value = "/";
                            dataGridView1.Rows[0].Cells[i].Style.BackColor = Color.Red;
                        }
                        else
                        {
                            dataGridView1.Rows[0].Cells[i].Value = "/";
                        }
                    }

                }

                //UpdateModelListReq<PKGSLTDEF> Do_Save = new UpdateModelListReq<PKGSLTDEF>();
                //Do_Save.models = lsPkgsltdefs;
                string s_lot_id = ComFunc.Trim(txtLotid.Text);
                
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //清空列表
            LSOQACHKMESSLOTIDS.Clear();
            
            if (CheckCondition("CREATE") == false) return;
                                   
            //List<OQA_CHKMESSLOTID> lsOqaChkmesslotids = null;
            List<PKGSLTDEF> lsPkgsltdefs = new List<PKGSLTDEF>();

            if (QryLotMesSlotidInfo(GlobConst.TRAN_VIEW, '1', out _lsOqaChkmesslotids) == false) return;

            for (int i = 0; i < _lsOqaChkmesslotids.Count; i++)
            {
                PKGSLTDEF item = new PKGSLTDEF();
                item.LotId = _lsOqaChkmesslotids[i].LotId;
                item.SlotId = _lsOqaChkmesslotids[i].SlotId;
                item.WaferId = _lsOqaChkmesslotids[i].WaferId;

                LSOQACHKMESSLOTIDS.Add(item);
            }

            string s_lot_id = ComFunc.Trim(txtLotid.Text);
            if (_ispLotSts.Count > 0)
            {
                Trans_Seq = _ispLotSts[0].TransSeq;
            }
            

            if (LSOQACHKMESSLOTIDS.Count > 0)
            {
                if (IstLotSltInfo(GlobConst.TRAN_CREATE, '1', s_lot_id, LSOQACHKMESSLOTIDS, Trans_Seq) == false) return;
                if (UptLotIspStsInfo(GlobConst.TRAN_UPDATE, '1', s_lot_id, Trans_Seq) == false) return;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            FrmPackageLabelPrint from = new FrmPackageLabelPrint(txtLotid.Text.Trim());
            from.FormBorderStyle = FormBorderStyle.FixedDialog;
            from.WindowState = FormWindowState.Maximized;
            from.StartPosition = FormStartPosition.CenterParent;
            from.ShowDialog();
            //this.Hide();

        }
    }
}