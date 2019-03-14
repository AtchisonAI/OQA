using Syncfusion.Windows.Forms;
using OQA_Core;
using System;
using System.Windows.Forms;
using WCFModels.Message;
using WCFModels.OQA;

namespace OQAMain
{
    public partial class FrmLotInspect : OQABaseForm
    {
        #region " Windows Form auto generated code "
        public FrmLotInspect()
        {
            InitializeComponent();
        }

        #endregion


        #region " Constant Definition "
        //private bool b_load_flag = false;

        #endregion


        #region " Variable Definition "
        //private bool b_load_flag  ;
        private decimal d_lotdieqty;
        private string s_vendorname;
        private string s_vendorlotno;
        private string s_orderno;
        private string s_sentime;
        #endregion


        #region " Function Definition "

        #region " 事务前数据检查 "
        private bool CheckCondition(string FuncName)
        {

            switch (ComFunc.Trim(FuncName))
            {
                case "VIEW":

                    //if (ComFunc.CheckValue(txtFoupID, 1) == false)
                    //{
                    //    MessageBox.Show("必填内容输入为空！");
                    //    txtFoupID.Focus();
                    //    return false;
                    //}

                    if (ComFunc.CheckValue(txtLotFilter, 1) == false)
                    {
                        MessageBox.Show("必填内容输入为空！");
                        txtLotID.Focus();
                        return false;
                    }

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

        private bool QueryMesLotInfo(char c_proc_step, char c_tran_flag)
        {
            ModelRsp<IspMesLot> in_node = new ModelRsp<IspMesLot>();
            IspMesLot in_data = new IspMesLot();

            in_data.C_PROC_STEP = c_proc_step;
            in_data.C_TRAN_FLAG = c_tran_flag;
            in_data.C_LOT_ID = txtLotFilter.Text.Trim();
            in_data.C_FOUP_ID = TxtFoupFilter.Text.Trim();

            in_node.model = in_data;

            var out_data = OQASrv.Call.QryMesLotInfo(in_node);

            if (out_data._success == true)
            {                    
                    OqaMeslot list = out_data.model.OQAMESLOT_LIST[0];
                    txtLotID.Text = list.Lotid;
                    txtFoupID.Text = list.Foupid;
                    txtPartID.Text = list.Partid;
                    txtLotQty.Text = list.Qty.ToString();
                    d_lotdieqty = list.Dieqty;
                    txtLotType.Text = list.Lottype;
                s_vendorname = list.Vendorname;
                s_vendorlotno = list.Vendorlotno;
                s_orderno = list.Orderno;
                s_sentime = list.Sentime;
                 

                return true;
            }
            else
            {
                MessageBox.Show(out_data._ErrorMsg);
                return false;
            }


        }
        #endregion



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

        private void imageUpload1_btnUploadClicked(object sender, EventArgs e)
        {

            imageUpload1.UpLoadFlag = UpLoadFlag.ByLot;
            ImageUpload.ImageUpload.ByLot item = new ImageUpload.ImageUpload.ByLot();
            item.LotID = "2";
            item.ImageType = ImageType.ISP;
            //item.TranSeq = 0;
            //item.ImageId = "test";
            imageUpload1.UpLoadByLot = item;
        }

        private void btnFilterView_Click(object sender, EventArgs e)
        {
            try
            {
                //检查数据
                 if (CheckCondition("VIEW") == false) return;

                //调用事务服务
                if (QueryMesLotInfo(GlobConst.TRAN_VIEW, '1') == false) return;

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}