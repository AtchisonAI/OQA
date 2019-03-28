using OQA_Core;
using System;
using System.Windows.Forms;
using WCFModels.Message;
using WCFModels.OQA;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using WcfClientCore.Utils.Authority;

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
        private List<ISPLOTSTS> _ispLotSts = new List<ISPLOTSTS>();


        #endregion


        #region " Function Definition "

        #region " 事务前数据检查 "
        private bool CheckCondition(string FuncName)
        {

            switch (ComFunc.Trim(FuncName))
            {
                case "CHECK":
                    if (ComFunc.CheckValue(txtLotid, 1) == false)
                    {
                        foreach (DataGridViewColumn column in dataGridView1.Columns)
                        {
                            dataGridView1.Rows[0].Cells[column.Name].Value = string.Empty;
                        }
                        MessageBox.Show("Lot ID is null！");
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

        private bool QryInfo(char c_proc_step, char c_tran_flag)
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
                    if (out_data.model.ISPLOTSTS_list.Count(p => p.Status == LotSts.IspOut) == 0)
                    {
                        MessageBox.Show("LOT status can not Foup Change!");
                        return false;
                    }
                }
                else

                {
                    MessageBox.Show("LOT status can not Foup Change!");
                    return false;
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
                    if (out_data.model.ISPLOTSTS_list.Count(p => p.Status == LotSts.IspOut ) == 0)
                    {
                        MessageBox.Show("LOT status can not Foup Change!");
                        return false;
                    }
                }
                else

                {
                    MessageBox.Show("LOT status can not Foup Change!");
                    return false;
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


        private bool QryLotIspSlotidInfo(char c_proc_step, char c_tran_flag, out List<ISPWAFST> lstIspwafsts)
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



        private ModelRsp<LotSlotidSave> IstLotSltInfo(char c_proc_step, char c_tran_flag, string c_lot_id,List<PKGSLTDEF> LSOQACHKMESSLOTIDS, decimal TransSeq)
        {
            ModelRsp<LotSlotidSave> in_node = new ModelRsp<LotSlotidSave>();
            ModelRsp<LotSlotidSave> out_node = new ModelRsp<LotSlotidSave>();
            LotSlotidSave in_data = new LotSlotidSave();

            in_data.C_PROC_STEP = c_proc_step;
            in_data.C_TRAN_FLAG = c_tran_flag;
            //in_data. = TransSeq; //事务控制
            in_data.PkgsltdefList = LSOQACHKMESSLOTIDS;
            in_data.IN_LOT_ID = c_lot_id;

            in_node.model = in_data;

            out_node = OQASrv.Call.IstLotSltInfo(in_node);
            return out_node;
        }


        private bool UptLotIspStsInfo(char c_proc_step, char c_tran_flag, string c_lot_id)
        {
            ModelRsp<LotSlotidView> in_node = new ModelRsp<LotSlotidView>();
            LotSlotidView in_data = new LotSlotidView();
            decimal TransSeq = 0;
            in_data.C_PROC_STEP = GlobConst.TRAN_VIEW;
            in_data.C_TRAN_FLAG = c_tran_flag; 
            in_data.IN_LOT_ID = c_lot_id;
            in_node.model = in_data;
            var qry_data = OQASrv.Call.QryLotIspStsInfo(in_node);
            if (qry_data._success)
            {
                if (null !=qry_data.model && null != qry_data.model.ISPLOTSTS_list)
                {
                    if(qry_data.model.ISPLOTSTS_list.Count > 0)
                    {
                        TransSeq = qry_data.model.ISPLOTSTS_list[0].TransSeq;
                    }
                }
            }

            in_node.model.D_TRANSSEQ = TransSeq; //事务控制
            in_node.model.C_PROC_STEP = c_proc_step;
            in_node.model.S_USER_ID = ComFunc.Trim(AuthorityControl.GetUserProfile().userId);
            
            var out_data = OQASrv.Call.UptLotIspStsInfo(in_node);

            if (out_data._success == true)
            {
                lblSucessMsg.Text = out_data._MsgCode;
                MessageBox.Show(out_data._MsgCode);
                ClearData("1");
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
                    btnCheck_Click(null,null);
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                //检查控件
                if (CheckCondition("CHECK") == false) return;
                string s_lot_id = ComFunc.Trim(txtLotid.Text);
                List<ISPWAFST> lsIspwafsts = null;
                List<OQA_CHKMESSLOTID> lsOqaChkmesslotids = null;

                //调用事务服务
                if (QryLotIspStsInfo(GlobConst.TRAN_VIEW, '1') == false) return; 
                if (QryLotIspSlotidInfo(GlobConst.TRAN_VIEW, '1', out lsIspwafsts) == false) return;
                if (QryLotMesSlotidInfo(GlobConst.TRAN_VIEW, '1', out lsOqaChkmesslotids) == false) return;

                //存pkg

                //清空列表

                List<PKGSLTDEF> LSOQACHKMESSLOTIDS = new List<PKGSLTDEF>();

                for (int i = 0; i < lsOqaChkmesslotids.Count; i++)
                {
                    PKGSLTDEF item = new PKGSLTDEF();
                    item.LotId = lsOqaChkmesslotids[i].LotId;
                    item.SlotId = lsOqaChkmesslotids[i].SlotId;
                    item.WaferId = lsOqaChkmesslotids[i].WaferId;

                    LSOQACHKMESSLOTIDS.Add(item);
                }

                var outInfo = IstLotSltInfo(GlobConst.TRAN_CREATE, '1', s_lot_id, LSOQACHKMESSLOTIDS, Trans_Seq);
                if (!outInfo._success && null != outInfo.model)
                {
                    if (null != outInfo.model.PkgsltdefList && outInfo.model.PkgsltdefList.Count > 0)
                    {
                        LSOQACHKMESSLOTIDS = outInfo.model.PkgsltdefList;
                    }
                }
                //显示
                for (int i = 0; i < 25; i++)
                {
                    int j = i + 1;
                    
                    bool isInMes = LSOQACHKMESSLOTIDS.Count(p => p.SlotId == j.ToString().PadLeft(3, '0')) > 0;

                    if (isInMes)
                    {
                        dataGridView1.Rows[0].Cells[i].Value = "OK";
                        dataGridView1.Rows[0].Cells[i].Style.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        dataGridView1.Rows[0].Cells[i].Value = "/";
                        dataGridView1.Rows[0].Cells[i].Style.BackColor = Color.LightGray;
                    }

                }
                btnCheck.Enabled = false;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string s_lot_id = ComFunc.Trim(txtLotid.Text);


            if (UptLotIspStsInfo(GlobConst.TRAN_UPDATE, '1', s_lot_id) == false) return;

            //跳转打印Label页面
            FrmPackageLabelPrint from = new FrmPackageLabelPrint(s_lot_id);
            AddNewFormToMdi(from);
            //txtLotid.Focus();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //FrmPackageLabelPrint from = new FrmPackageLabelPrint(txtLotid.Text.Trim());
            //from.FormBorderStyle = FormBorderStyle.FixedDialog;
            //from.WindowState = FormWindowState.Maximized;
            //from.StartPosition = FormStartPosition.CenterParent;
            //from.ShowDialog();
            //this.Hide();

        }

        private void btnEdite_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearData("1");
        }

        private void txtLotid_MouseDown(object sender, MouseEventArgs e)
        {
            ClearData("1");
            btnCheck.Enabled = true;
        }
    }
}