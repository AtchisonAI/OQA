using Syncfusion.Windows.Forms;
using OQA_Core;
using System;
using System.Windows.Forms;
using WCFModels.Message;
using WCFModels.OQA;
using System.Collections.Generic;

namespace OQAMain
{
    public partial class FrmDefectCodeSet : OQABaseForm
    {
        #region " Windows Form auto generated code "
        public FrmDefectCodeSet()
        {
            InitializeComponent();
        }
        #endregion


        #region " Constant Definition "
        //private bool b_load_flag = false;       
        private decimal Trans_Seq = 0;
        #endregion


        #region " Variable Definition "
        private bool Have_flag = false;
        //private bool b_load_flag  ;
        //private string s_Defect_Desc = " ";

        //e100835
        private string name = "";

        #endregion


        #region " Function Definition "

        #region " 事务前数据检查 "
        private bool CheckCondition(string FuncName)
        {

            switch (ComFunc.Trim(FuncName))
            {
                case "CREATE":

                    if (ComFunc.CheckValue(txtIspType, 1) == false)
                    {
                        MessageBox.Show("Input of required contents is null！");
                        txtIspType.Focus();
                        return false;
                    }

                    if (ComFunc.CheckValue(txtDefectCode, 1) == false)
                    {
                        MessageBox.Show("Input of required contents is null！");
                        txtIspType.Focus();
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


        private bool QueryDefectCodeInfo(char c_proc_step, char c_tran_flag)
        {
            ModelRsp<DefectCodeView> in_node = new ModelRsp<DefectCodeView>();
            DefectCodeView in_data = new DefectCodeView();

            in_data.C_PROC_STEP = c_proc_step;
            in_data.C_TRAN_FLAG = c_tran_flag;
            in_data.IN_ISP_TYPE = txtFilter.Text.Trim();
            
            in_node.model = in_data;

            var out_data = OQASrv.Call.QueryDefectCodeInfo(in_node);

            if (out_data._success == true)
            {
                         

                ComFunc.InitListView(LstIspCode, true);
                txtCount.Text = out_data.model.ISPDFTDEF_list.Count.ToString();

                for (int i = 0; i < out_data.model.ISPDFTDEF_list.Count; i++)
                {

                    ListViewItem list_item = new ListViewItem();
                    ISPDFTDEF list = out_data.model.ISPDFTDEF_list[i];
                    list_item.Text = list.InspectType;
                    list_item.SubItems.Add(list.DefectCode);
                    list_item.SubItems.Add(list.DftDesc);
                    list_item.SubItems.Add(list.TransSeq.ToString());//修改数据使用
                    LstIspCode.Items.Add(list_item);
                    
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

        private bool SaveIspCodeInfo(char c_proc_step, char c_tran_flag,string type,string code,string code_desc,decimal TransSeq)
        {
            ModelRsp<DefectCodeSave> in_node = new ModelRsp<DefectCodeSave>();
            DefectCodeSave in_data = new DefectCodeSave();

            in_data.C_PROC_STEP = c_proc_step;
            in_data.C_TRAN_FLAG = c_tran_flag;
            in_data.D_TRANSSEQ = TransSeq; //事务控制
            in_data.IN_ISP_CODE = code;
            in_data.IN_CODE_DESC = code_desc;
            in_data.IN_ISP_TYPE = type;

            in_node.model = in_data;

            var out_data = OQASrv.Call.CreateDefectCodeInfo(in_node);

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



        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                //检查控件
                if (CheckCondition("CREATE") == false) return;
                //传入参数收集
                char cTranFlag  ;
                if (Have_flag == true)
                {
                    cTranFlag = GlobConst.TRAN_UPDATE;
                }
                else
                {
                    cTranFlag = GlobConst.TRAN_CREATE;
                }

                // if (SaveIspCodeInfo(GlobConst.TRAN_UPDATE, '1') == false) return;
                
                string s_isp_code      = ComFunc.Trim(txtDefectCode.Text);
                string s_isp_code_desc = ComFunc.Trim(txtDefectDesc.Text);
                string s_isp_type      = ComFunc.Trim(txtIspType.Text   );
               

                //调用事务服务
                if (SaveIspCodeInfo(cTranFlag, '1', s_isp_type, s_isp_code, s_isp_code_desc,Trans_Seq) == true)
                {

                }
                else
                {
                }
                btnRefresh.PerformClick();


            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void rbnFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnFilter.Checked == true)
            {
                txtFilter.Enabled = true;
            }
        }

        private void rbnNoFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnNoFilter.Checked == true)
            {
                txtFilter.Text = "";
                txtFilter.Enabled = false;
            }
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                if (ComFunc.Trim(txtFilter.Text) != "")
                {
                    btnFilterView.PerformClick();
                }
            }
        }

        private void btnFilterView_Click(object sender, EventArgs e)
        {
            try
            {
                //检查数据
               // if (CheckCondition("TypeView") == false) return;

                //调用事务服务
                if (QueryDefectCodeInfo(GlobConst.TRAN_VIEW,'1') == false) return;

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void LstIspCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstIspCode.SelectedItems.Count > 0)
            {
                  Have_flag = true;
      
                txtIspType.Text = LstIspCode.SelectedItems[0].Text;
                txtDefectCode.Text = LstIspCode.SelectedItems[0].SubItems[1].Text;
                txtDefectDesc.Text = LstIspCode.SelectedItems[0].SubItems[2].Text;
                Trans_Seq = Convert.ToDecimal(LstIspCode.SelectedItems[0].SubItems[3].Text);

                txtDefectCode.Enabled = false;
                txtIspType.Enabled = false;
                //txtDefectDesc.Enabled = false;

            }
            else
            {
                Have_flag = false;
                ComFunc.FieldClear(grpDefectCode);
                txtDefectCode.Enabled = true;
                txtIspType.Enabled = true;
                //txtDefectDesc.Enabled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Have_flag = false;
            Trans_Seq = 0;
            ComFunc.FieldClear(grpDefectCode);
            txtDefectCode.Enabled = true;
            txtIspType.Enabled = true;
            txtDefectDesc.Enabled = true;

            btnFilterView.PerformClick();
        }
    }
}