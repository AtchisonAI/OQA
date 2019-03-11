using Syncfusion.Windows.Forms;
using OQA_Core;
using System;
using System.Windows.Forms;

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
                case "CREATE":
                    if (ComFunc.CheckValue(txtLotid,1)==false)
                    {
                        MessageBox.Show("必填内容输入为空！");
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


        //private bool QuerySlotidInfo(char c_proc_step, char c_tran_flag)
        //{
        //    ModelRsp<FoupChange> in_node = new ModelRsp<FoupChange>();

        //    in_node.model.c_proc_step = c_proc_step;

        //    in_node.model.c_tran_flag = c_tran_flag;
        //    var data = OQASrv.CallServer().QuerySlotidInfo(in_node);

        //    //LstIspCode.d

        //    return true;
        //}

        //#endregion

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

                for(int i =1; i < 26; i++)
                {
                    if (i<26)
                    {
                        dataGridView1.SelectedRows[0].Cells[i].Value = "OK";
                    }
                    else
                    {
                        dataGridView1.SelectedRows[0].Cells[i].Value = "/";
                    }
                }


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
        
    }
}