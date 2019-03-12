using Syncfusion.Windows.Forms;
using OQA_Core;
using System;
using System.Windows.Forms;
using WCFModels.Message;
using WCFModels.OQA;
using System.Linq;
using Syncfusion.XPS;
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
            if (out_data._success == true)
            {
                if (out_data.model.ISPLOTST_list.Count > 0)
                {
                    if (out_data.model.ISPLOTST_list.Count(p => p.Status == "已检验") == 0)
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
                dataGridView1.Rows[0].Cells[0].Value = "Match With MES";
                for (int i = 1; i < 26; i++)
                {

                    if (out_data.model.ISPWAFST_list.Count(p => p.SlotId == i.ToString().PadLeft(3, '0')) > 0)
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



        private bool QryLotMesSlotidInfo(char c_proc_step, char c_tran_flag, out List<PKGSLTDEF> lsPkgsltdefs)
        {
            lsPkgsltdefs = null;
            ModelRsp<LotSlotidView> in_node = new ModelRsp<LotSlotidView>();
            LotSlotidView in_data = new LotSlotidView();

            in_data.C_PROC_STEP = c_proc_step;
            in_data.C_TRAN_FLAG = c_tran_flag;
            in_data.IN_LOT_ID = txtLotid.Text.Trim();

            in_node.model = in_data;
            
            var out_data = OQASrv.Call.QryLotMesSlotidInfo(in_node);

            if (out_data._success == true)
            {
              

                lsPkgsltdefs = out_data.model.PKGSLTDEF_list;
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
                List<PKGSLTDEF> lsPkgsltdefs = null;

                //调用事务服务
                if (QryLotIspStsInfo(GlobConst.TRAN_VIEW, '1') == false) return;
                if (QryLotIspSlotidInfo(GlobConst.TRAN_VIEW, '1',out lsIspwafsts) == false) return;
                if (QryLotMesSlotidInfo(GlobConst.TRAN_VIEW, '1',out lsPkgsltdefs) == false) return;


                for (int i = 1; i < 26; i++)
                {
                    bool isInISP = false;
                    dataGridView1.Rows[0].Cells[i].Style.BackColor = Color.White;

                    if (lsIspwafsts.Count(p => p.SlotId == i.ToString().PadLeft(3, '0')) > 0)
                    {
                        isInISP = true;
                    }

                    bool isInMES = false;

                    if (lsPkgsltdefs.Count(p => p.SlotId == i.ToString().PadLeft(3, '0')) > 0)
                    {
                        isInMES = true;
                    }


                    if (isInMES)
                    {
                        if (isInISP)
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
                        if (isInISP)
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

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

       
    }
}