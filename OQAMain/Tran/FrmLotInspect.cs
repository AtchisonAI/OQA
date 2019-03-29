using Syncfusion.Windows.Forms;
using OQA_Core;
using System;
using System.Windows.Forms;
using WCFModels.Message;
using WCFModels.OQA;
using WcfClientCore.Utils.Authority;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Data;
using System.Diagnostics;

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
        private decimal? d_lotdieqty;
        private string s_vendorname;
        private string s_vendorlotno;
        private string s_orderno;
        private string s_sentime;
        public decimal d_tran_seq = 0;
        private List<OqaMeslot>  list_meslot;
        private List<OqaMeswafer> list_wafer;
        private List<ISPWAFST> list_ispwafer;
        private List<ISPWAFITM> list_AOI;
        private List<ISPWAFITM> list_MAC;
        private List<ISPWAFITM> list_MIR;
        private List<ISPLOTSTS> list_lot;

        #endregion


        #region " Function Definition "

        #region " 事务前数据检查 "
        private bool CheckCondition(string FuncName)
        {

            switch (ComFunc.Trim(FuncName))
            {
                case "ISPVIEW":
                    if (ComFunc.CheckValue(txtISPLotFilter, 1) == false)
                    {
                        MessageBox.Show("Input of required contents is null！");
                        txtISPLotFilter.Focus();
                        return false;
                    }
                    break;

                case "VIEW":


                    if (ComFunc.CheckValue(txtLotFilter, 1) == false)
                    {
                        MessageBox.Show("Input of required contents is null！");
                        txtLotFilter.Focus();
                        return false;
                    }


                    break;

                case "UPDATE":
                    if (ComFunc.CheckValue(txtLotID, 1) == false)
                    {
                        MessageBox.Show("Input of required contents is null！");
                        txtLotID.Focus();
                        return false;
                    }
                    break;

                case "CREATE":
                    if (ComFunc.CheckValue(txtLotID, 1) == false)
                    {
                        MessageBox.Show("Input of required contents is null！");
                        txtLotID.Focus();
                        return false;
                    }
                    if (ComFunc.CheckValue(txtFoupID, 1) == false)
                    {
                        MessageBox.Show("Input of required contents is null！");
                        txtFoupID.Focus();
                        return false;
                    }
                    if (ComFunc.CheckValue(txtPartID, 1) == false)
                    {
                        MessageBox.Show("Input of required contents is null！");
                        txtPartID.Focus();
                        return false;
                    }
                    if (ComFunc.CheckValue(txtLotQty, 1) == false)
                    {
                        MessageBox.Show("Input of required contents is null！");
                        txtLotQty.Focus();
                        return false;
                    }
                    if (ComFunc.CheckValue(txtUserID, 1) == false)
                    {
                        MessageBox.Show("Input of required contents is null！");
                        txtUserID.Focus();
                        return false;
                    }

                    //txtLotID.Text = list.Lotid;
                    //txtFoupID.Text = list.Foupid;
                    //txtPartID.Text = list.Partid;
                    //txtLotQty.Text = list.Qty.ToString();
                    //d_lotdieqty = list.Dieqty;
                    //txtLotType.Text = list.Lottype;
                    //s_vendorname = list.Vendorname;
                    //s_vendorlotno = list.Vendorlotno;
                    //s_orderno = list.Orderno;
                    //s_sentime = list.Sentime;
                    //txtUserID.Text = AuthorityControl.GetUserProfile().userId;
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
                        ComFunc.InitListView(LstRcvLot, true);
                        ComFunc.FieldClear(this);
                        labPndn.Visible = false;
                        d_tran_seq = 0;
                        ImgISPLot.Enabled = false;
                        ImgISPLot.RefreshContrl();
                        btnEdite.Enabled = false;
                        break;
                    case "2"://
                        dgAOI.Rows.Clear();
                        dgMacro.Rows.Clear();
                        dgMIR.Rows.Clear();
                        btnEdite.Enabled = false;
                        break;
                    case "3"://AFTER SELECT 
                        ComFunc.FieldClear(grpMesLot);
                        labPndn.Visible = false;
                        btnEdite.Enabled = true;
                        break;
                    case "4":
                        //Initialize
                        ComFunc.InitListView(LstRcvLot, true);
                        ComFunc.FieldClear(this,txtISPLotFilter,txtISPFoupFilter);
                        labPndn.Visible = false;
                        d_tran_seq = 0;
                        ImgISPLot.Enabled = false;
                        ImgISPLot.RefreshContrl();
                        btnEdite.Enabled = true;
                        break;
                }

                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
        #endregion

        private bool QueryImgByLot(string s_lotid)
        {
            LotPackageInput in_node = new LotPackageInput();
            in_node.lotId = s_lotid;
            try
            {
                var out_node = OQASrv.Call.QueryPackageImg(in_node);
                if (out_node.models.Count > 0)
                {
                    InitImageControl(out_node.models);
                }
                else
                {
                    ImgISPLot.RefreshContrl();
                    ImgISPLot.Enabled = true;
                }

                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }

        private void InitImageControl(List<ISPIMGDEF> imageList)
        {
            foreach (ISPIMGDEF img in imageList)
            {
                switch (img.ImageType)
                {
                    case ImageType.ISP:
                        ImgISPLot.InitByImgInstance(img);
                        break;

                }
            }
        }

        


        private bool SaveISPLotInfo(char c_proc_step, char c_tran_flag)
        {
            try
            {
                ModelRsp<ISPLotSave> in_node = new ModelRsp<ISPLotSave>();
                ISPLotSave in_data = new ISPLotSave();
                in_data.C_PROC_STEP = c_proc_step;
                in_data.C_TRAN_FLAG = c_tran_flag;
                //string.IsNullOrWhiteSpace(ISPLotSave.model.S_USER_NAME)        

                if (c_proc_step == GlobConst.TRAN_CREATE)
                {
                    in_data.S_USER_ID = ComFunc.Trim(txtUserID.Text);
                    in_data.S_USER_NAME = ComFunc.Trim(txtName.Text);
                    in_data.ISPMESLOT_List = list_meslot;
                    in_data.ISPMESWAFER_List = list_wafer;
                }
                else
                {
                    in_data.S_LOT_ID = ComFunc.Trim(txtLotID.Text);
                    in_data.D_TRAN_SEQ = d_tran_seq;
                    in_data.S_USER_ID = ComFunc.Trim(AuthorityControl.GetUserProfile().userId);
                }

                if (string.IsNullOrWhiteSpace(txtDept.Text) == false)
                {
                    in_data.S_DEPT = ComFunc.Trim(txtDept.Text);
                }
                if (string.IsNullOrWhiteSpace(txtShift.Text) == false)
                {
                    in_data.S_REC_SHIFT = ComFunc.Trim(txtShift.Text);
                }
                if (string.IsNullOrWhiteSpace(txtPhone.Text) == false)
                {
                    in_data.S_PHONE = ComFunc.Trim(txtPhone.Text);
                }


                in_node.model = in_data;

                var out_data = OQASrv.Call.SaveISPLotInfo(in_node);
                if (out_data._success == true)
                {
                    MessageBox.Show(out_data._MsgCode);
                    return true;
                }
                else
                {
                    MessageBox.Show(out_data._ErrorMsg);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool SubmitISPLotInfo(char c_proc_step, char c_tran_flag)
        {
            try
            {
                ModelRsp<ISPLotSave> in_node = new ModelRsp<ISPLotSave>();
                ISPLotSave in_data = new ISPLotSave();
                in_data.C_PROC_STEP = c_proc_step;
                in_data.C_TRAN_FLAG = c_tran_flag;
                //string.IsNullOrWhiteSpace(ISPLotSave.model.S_USER_NAME)        

                if (c_proc_step == GlobConst.TRAN_CREATE)
                {
                    in_data.S_USER_ID = ComFunc.Trim(txtUserID.Text);
                    in_data.S_USER_NAME = ComFunc.Trim(txtName.Text);
                    in_data.ISPMESLOT_List = list_meslot;
                    in_data.ISPMESWAFER_List = list_wafer;
                }
                else
                {
                    in_data.S_LOT_ID = ComFunc.Trim(txtLotID.Text);
                    in_data.D_TRAN_SEQ = d_tran_seq;
                    in_data.S_USER_ID = ComFunc.Trim(AuthorityControl.GetUserProfile().userId);
                }

                if (string.IsNullOrWhiteSpace(txtDept.Text) == false)
                {
                    in_data.S_DEPT = ComFunc.Trim(txtDept.Text);
                }
                if (string.IsNullOrWhiteSpace(txtShift.Text) == false)
                {
                    in_data.S_REC_SHIFT = ComFunc.Trim(txtShift.Text);
                }
                if (string.IsNullOrWhiteSpace(txtPhone.Text) == false)
                {
                    in_data.S_PHONE = ComFunc.Trim(txtPhone.Text);
                }


                in_node.model = in_data;

                var out_data = OQASrv.Call.SaveISPLotInfo(in_node);
                if (out_data._success == true)
                {
                    MessageBox.Show(out_data._MsgCode);
                    //PNDN跳转
                    if (out_data.__ByPass == false)
                    {
                        string s_LotID = txtLotID.Text.Trim();
                        FrmDefectSend DefectSend = new FrmDefectSend(s_LotID);
                        DefectSend.FormBorderStyle = FormBorderStyle.FixedDialog;
                        DefectSend.WindowState = FormWindowState.Maximized;
                        DefectSend.StartPosition = FormStartPosition.CenterParent;
                        DefectSend.ShowDialog();
                        //AddNewFormToMdi(DefectSend);
                    }
                    return true;
                }
                else
                {
                    MessageBox.Show(out_data._ErrorMsg);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

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
                labPndn.Visible = true;
                lblSucessMsg.Text = out_data._MsgCode;
                txtShift.Focus();

                list_meslot = out_data.model.OQAMESLOT_LIST;
                list_meslot[0].Stage = "OQA";
                txtLotID.Text = list_meslot[0].Lotid;
                txtFoupID.Text = list_meslot[0].Foupid;
                txtPartID.Text = list_meslot[0].Partid;
                txtLotQty.Text = list_meslot[0].Qty.ToString();
                d_lotdieqty = list_meslot[0].Dieqty;
                txtLotType.Text = list_meslot[0].Lottype;
                s_vendorname = list_meslot[0].Vendorname;
                s_vendorlotno = list_meslot[0].Vendorlotno;
                s_orderno = list_meslot[0].Orderno;
                s_sentime = list_meslot[0].Sentime;
                txtUserID.Text = AuthorityControl.GetUserProfile().userId;
                txtRecDate.Text = DateTime.Now.ToString("yyyyMMddhhmmss");
                txtDept.Text = "FQA";

                if (string.IsNullOrWhiteSpace(out_data.model.S_PNDN_NO) == false)
                {
                    labPndn.Text = out_data.model.S_PNDN_NO;
                    labPndn.ForeColor = Color.Red;

                }
                else
                {
                    labPndn.Text = "Lot PNDN history and WAT data is OK!";
                    labPndn.ForeColor = Color.Blue;
                }

                list_wafer = out_data.model.OQAMESWAFER_LIST;
                int slotIndex;
                for (int i = 0; i < 25; i++)
                {
                    bool isInMES = false;
                    slotIndex = i + 1;

                    if (list_wafer.Count(p => p.Slotid == slotIndex.ToString().PadLeft(3, '0')) > 0)
                    {
                        isInMES = true;
                    }

                    if (isInMES)
                    {
                        dgSlotID.Rows[0].Cells[i].Value = "Y";
                        dgSlotID.Rows[0].Cells[i].Style.BackColor = Color.LightBlue;
                    }
                    else
                    {
                        dgSlotID.Rows[0].Cells[i].Value = "/";
                        dgSlotID.Rows[0].Cells[i].Style.BackColor = Color.LightGray;
                    }


                }
                return true;
            }
            else
            {
                labPndn.Visible = false;
                MessageBox.Show(out_data._ErrorMsg);
                return false;
            }


        }

        private bool QueryISPWaferInfo(char c_proc_step, char c_tran_flag)
        {
            ModelRsp<IspLot> in_node = new ModelRsp<IspLot>();
            IspLot in_data = new IspLot();

            in_data.C_PROC_STEP = c_proc_step;
            in_data.C_TRAN_FLAG = c_tran_flag;
            in_data.C_LOT_ID = txtISPLotFilter.Text.Trim();

            in_node.model = in_data;

            var out_data = OQASrv.Call.QryISPLotInfo(in_node);

            if (out_data._success == true)
            {
                DateTime DTsTART = DateTime.Now;

                list_lot = out_data.model.ISPLOTSTS_LIST;
                txtLotID.Text = list_lot[0].LotId;
                txtFoupID.Text = list_lot[0].FoupId;
                txtPartID.Text = list_lot[0].PartId;
                txtLotType.Text = list_lot[0].LotType;
                txtUserID.Text = list_lot[0].RecUser;
                txtRecDate.Text = list_lot[0].RecDate;
                txtName.Text = list_lot[0].RecUserName;
                txtShift.Text = list_lot[0].RecShift.Trim();
                txtPhone.Text = list_lot[0].Phone.Trim();
                txtDept.Text = list_lot[0].Dept.Trim();
                txtStage.Text = list_lot[0].Stage;
                txtLotQty.Text = list_lot[0].Qty.ToString();
                d_tran_seq = list_lot[0].TransSeq;

                labPndn.Visible = true;
                list_ispwafer = out_data.model.ISPWAFSTS_LIST;
                int slotIndex;
                for (int i = 0; i < 25; i++)
                {
                    bool isInMES = false;
                    slotIndex = i + 1;

                    if (list_ispwafer.Count(p => p.SlotId == slotIndex.ToString().PadLeft(3, '0')) > 0)
                    {
                        isInMES = true;
                    }

                    if (isInMES)
                    {
                        dgSlotID.Rows[0].Cells[i].Value = "Y";
                        dgSlotID.Rows[0].Cells[i].Style.BackColor = Color.LightBlue;
                    }
                    else
                    {
                        dgSlotID.Rows[0].Cells[i].Value = "/";
                        dgSlotID.Rows[0].Cells[i].Style.BackColor = Color.LightGray;
                    }


                }

                list_AOI = out_data.model.AOI_LIST;
               
                DataGridViewRow DT = new DataGridViewRow();
                List<string> list_AOIside = new List<string>
                {
                    "F", "B"

                };
                for (int j = 0; j < list_AOIside.Count; j++)
                {
                    int idx = dgAOI.Rows.Add();
                    DT = dgAOI.Rows[idx];
                    DT.Cells[0].Value = list_AOIside[j].ToString();
                    for (int i = 1; i < 26; i++)
                    {
                        bool isInMES = false;
                        bool IsInspect = false;
                        bool haveDefect = false;
                        slotIndex = i;

                        if (list_AOI.Count(p => p.SlotId == slotIndex.ToString().PadLeft(3, '0')) > 0)
                        {
                            isInMES = true;
                        }

                        if (list_AOI.Count(p => p.SlotId == slotIndex.ToString().PadLeft(3, '0') && p.IsInspect == "Y" && p.SideType == list_AOIside[j].ToString()) > 0)
                        {
                            IsInspect = true;
                        }

                        if (list_AOI.Count(p => p.SlotId == slotIndex.ToString().PadLeft(3, '0') && p.InspectResult == "N" && p.SideType == list_AOIside[j].ToString()) > 0)
                        {
                            haveDefect = true;
                        }

                        if (isInMES)
                        {
                            DT.Cells[i].Value = "N";
                            DT.Cells[i].Style.BackColor = Color.LightBlue;
                            if (IsInspect)
                            {
                                DT.Cells[i].Value = "Y";                                
                                DT.Cells[i].Style.BackColor = Color.LightGreen;
                            }
                            if (haveDefect)
                            {
                                DT.Cells[i].Value = "D";
                                DT.Cells[i].Style.BackColor = Color.Red;
                            }

                        }
                        else
                        {
                            DT.Cells[i].Value = "/";
                            DT.Cells[i].Style.BackColor = Color.LightGray;
                        }


                    }

                }


                list_MAC = out_data.model.MAC_LIST;
                
                DT = new DataGridViewRow();

                List<string> list_Macside = new List<string>
                {
                    "F", "B", "E"

                };
                for (int j = 0; j < list_Macside.Count; j++)
                {
                    int idx = dgMacro.Rows.Add();
                    DT = dgMacro.Rows[idx];
                    DT.Cells[0].Value = list_Macside[j].ToString();
                    for (int i = 1; i < 26; i++)
                    {
                        bool isInMES = false;
                        bool IsInspect = false;
                        bool haveDefect = false;
                        slotIndex = i ;

                        if (list_MAC.Count(p => p.SlotId == slotIndex.ToString().PadLeft(3, '0')) > 0)
                        {
                            isInMES = true;
                        }

                        if (list_MAC.Count(p => p.SlotId == slotIndex.ToString().PadLeft(3, '0') && p.IsInspect == "Y" && p.SideType == list_Macside[j].ToString()) > 0)
                        {
                            IsInspect = true;
                        }

                        if (list_MAC.Count(p => p.SlotId == slotIndex.ToString().PadLeft(3, '0') && p.InspectResult == "N" && p.SideType == list_Macside[j].ToString()) > 0)
                        {
                            haveDefect = true;
                        }

                        if (isInMES)
                        {
                            DT.Cells[i].Value = "N";
                            DT.Cells[i].Style.BackColor = Color.LightBlue;
                            if (IsInspect)
                            {
                                DT.Cells[i].Value = "Y";
                                DT.Cells[i].Style.BackColor = Color.LightGreen;
                            }
                            if (haveDefect)
                            {
                                DT.Cells[i].Value = "D";
                                DT.Cells[i].Style.BackColor = Color.Red;
                            }

                        }
                        else
                        {
                            DT.Cells[i].Value = "/";
                            DT.Cells[i].Style.BackColor = Color.LightGray;
                        }


                    }
                    
                }

                list_MIR = out_data.model.MIR_LIST;
                
                DT = new DataGridViewRow();

                List<string> list_MIRside = new List<string>
                {
                    "F"

                };
                for (int j = 0; j < list_MIRside.Count; j++)
                {
                    int idx = dgMIR.Rows.Add();
                    DT = dgMIR.Rows[idx];

                    DT.Cells[0].Value = list_MIRside[j].ToString();
                    for (int i = 1; i < 26; i++)
                    {
                        bool isInMES = false;
                        bool IsInspect = false;
                        bool haveDefect = false;
                        slotIndex = i ;

                        if (list_MIR.Count(p => p.SlotId == slotIndex.ToString().PadLeft(3, '0')) > 0)
                        {
                            isInMES = true;
                        }

                        if (list_MIR.Count(p => p.SlotId == slotIndex.ToString().PadLeft(3, '0') && p.IsInspect == "Y" && p.SideType == list_MIRside[j].ToString()) > 0)
                        {
                            IsInspect = true;
                        }

                        if (list_MIR.Count(p => p.SlotId == slotIndex.ToString().PadLeft(3, '0') && p.InspectResult == "N" && p.SideType == list_MIRside[j].ToString()) > 0)
                        {
                            haveDefect = true;
                        }

                        if (isInMES)
                        {
                            DT.Cells[i].Value = "N";
                            DT.Cells[i].Style.BackColor = Color.LightBlue;
                            if (IsInspect)
                            {
                                DT.Cells[i].Value = "Y";
                                DT.Cells[i].Style.BackColor = Color.LightGreen;
                            }
                            if (haveDefect)
                            {
                                DT.Cells[i].Value = "D";
                                DT.Cells[i].Style.BackColor = Color.Red;
                            }

                        }
                        else
                        {
                            DT.Cells[i].Value = "/";
                            DT.Cells[i].Style.BackColor = Color.LightGray;
                        }


                    }
                
                }
                TimeSpan TS = DateTime.Now - DTsTART;
                lblSucessMsg.Text = out_data._MsgCode;
                return true;
            }
            else
            {
                labPndn.Visible = false;
                MessageBox.Show(out_data._ErrorMsg);
                return false;
            }


        }

        private bool QueryISPLotInfo(char c_proc_step, char c_tran_flag)
        {
            ModelRsp<IspLot> in_node = new ModelRsp<IspLot>();
            IspLot in_data = new IspLot();

            in_data.C_PROC_STEP = c_proc_step;
            in_data.C_TRAN_FLAG = c_tran_flag;
            in_data.C_LOT_ID = txtISPLotFilter.Text.Trim();
            in_data.C_FOUP_ID = txtISPFoupFilter.Text.Trim();

            in_node.model = in_data;

            var out_data = OQASrv.Call.QryISPLotInfo(in_node);

            if (out_data._success == true)
            {
                labPndn.Visible = true;
                ComFunc.InitListView(LstRcvLot, true);
                txtCount.Text = out_data.model.ISPLOTSTS_LIST.Count.ToString();

                List<ISPLOTSTS> SortByTime = out_data.model.ISPLOTSTS_LIST.OrderByDescending(o => o.RecDate).ToList();

                for (int i = 0; i < SortByTime.Count; i++)
                {

                    ListViewItem list_item = new ListViewItem();
                    ISPLOTSTS list = SortByTime[i];
                    list_item.Text = list.LotId;
                    list_item.SubItems.Add(list.FoupId);
                    list_item.SubItems.Add(list.TransSeq.ToString());
                    list_item.SubItems.Add(list.PartId);
                    list_item.SubItems.Add(list.PartDesc);
                    list_item.SubItems.Add(list.ProductDieQty.ToString());
                    list_item.SubItems.Add(list.Qty.ToString());
                    list_item.SubItems.Add(list.LotType);
                    list_item.SubItems.Add(list.Stage);
                    list_item.SubItems.Add(list.Dept);

                    list_item.SubItems.Add(list.CustomerId);
                    list_item.SubItems.Add(list.CustLotId);
                    list_item.SubItems.Add(list.CustPartId);
                    LstRcvLot.Items.Add(list_item);

                }
                lblSucessMsg.Text = out_data._MsgCode;
                return true;
            }
            else
            {
                labPndn.Visible = false;
                MessageBox.Show(out_data._ErrorMsg);
                return false;
            }


        }
        #endregion



        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
              
                //调用事务服务
                char proc_step;
                if (d_tran_seq == 0)
                {
                    proc_step = GlobConst.TRAN_CREATE;
                    //检查数据
                    if (CheckCondition("CREATE") == false) return;

                }
                else
                {
                    proc_step = GlobConst.TRAN_UPDATE;
                    //检查数据
                    if (CheckCondition("UPDATE") == false) return;
                }
                if (SaveISPLotInfo(proc_step, '1') == false) return;

                txtISPLotFilter.Text = txtLotID.Text;
                btnISPLotFilter.PerformClick();


                //ClearData("2");

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

            if (string.IsNullOrWhiteSpace(txtLotID.Text) == false)
            {
                ImgISPLot.UpLoadFlag = UpLoadFlag.ByLot;
                ImageUpload.ImageUpload.ByLot item = new ImageUpload.ImageUpload.ByLot();
                item.LotID = txtLotID.Text.Trim();
                item.ImageType = ImageType.ISP;
                //item.TranSeq = 0;
                //item.ImageId = "test";
                ImgISPLot.UpLoadByLot = item;
            }
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

        private void txtLotFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                if (ComFunc.Trim(txtLotFilter.Text) != "")
                {
                    TxtFoupFilter.Focus();
                }
            }
        }

        private void TxtFoupFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                if (ComFunc.Trim(txtLotFilter.Text) != "")
                {
                    btnFilterView.PerformClick();
                   
                }
            }
        }

        private void txtShift_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {

                txtPhone.Focus();

            }
        }

        private void btnISPLotFilter_Click(object sender, EventArgs e)
        {
            try
            {
                //检查数据
                //if (CheckCondition("ISPVIEW") == false) return;

                //调用事务服务
                if (QueryISPLotInfo(GlobConst.TRAN_VIEW, '1') == false)
                {
                    ClearData("4");

                }
                else
                {
                    if (LstRcvLot.Items.Count > 0)
                    {
                        LstRcvLot.Items[0].Selected = true;
                    }
                    else
                    {
                        ClearData("4");
                    }
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void LstRcvLot_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstRcvLot.SelectedItems.Count > 0)
            {
                txtISPLotFilter.Text = LstRcvLot.SelectedItems[0].Text;

                //检查数据
                if (CheckCondition("ISPVIEW") == false) return;
                 Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                //调用事务服务
                ClearData("2");
                if (QueryISPWaferInfo(GlobConst.TRAN_VIEW, '2') == false) return;
                stopwatch.Stop();

                long time = stopwatch.ElapsedMilliseconds;
                ImgISPLot.Enabled = true;
                QueryImgByLot(txtISPLotFilter.Text.Trim());

                ClearData("3");
            }
        }

        private void dgAOI_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgAOI.Rows.Count > 0)
                {
                    if (dgAOI.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Y" || dgAOI.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "D")
                    {
                        string s_side = dgAOI.Rows[e.RowIndex].Cells[0].Value.ToString();

                        FrmAOIInput AOI = new FrmAOIInput(txtLotID.Text, e.ColumnIndex.ToString().PadLeft(3, '0'), s_side);
                        AOI.FormBorderStyle = FormBorderStyle.FixedDialog;
                        AOI.WindowState = FormWindowState.Normal;
                        AOI.MaximizeBox = false;
                        AOI.MinimizeBox = false;
                        AOI.StartPosition = FormStartPosition.CenterParent;
                        AOI.ShowDialog();

                        btnISPLotFilter.PerformClick();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgMacro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgMacro.Rows.Count > 0)
            {
                if (dgMacro.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Y" || dgMacro.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "D")
                {
                    if (dgMacro.Rows[e.RowIndex].Cells[0].Value.ToString() == "E")
                    {
                        string s_side = dgMacro.Rows[e.RowIndex].Cells[0].Value.ToString();
                        FrmMarcoEdgeInput MAC = new FrmMarcoEdgeInput(txtLotID.Text, e.ColumnIndex.ToString().PadLeft(3, '0'), s_side);
                        MAC.FormBorderStyle = FormBorderStyle.FixedDialog;
                        MAC.WindowState = FormWindowState.Normal;
                        MAC.MaximizeBox = false;
                        MAC.MinimizeBox = false;
                        MAC.StartPosition = FormStartPosition.CenterParent;
                        MAC.ShowDialog();
                    }
                    else
                    {
                        string s_side = dgMacro.Rows[e.RowIndex].Cells[0].Value.ToString();
                        FrmMarcoInput MAC = new FrmMarcoInput(txtLotID.Text, e.ColumnIndex.ToString().PadLeft(3, '0'), s_side);
                        MAC.FormBorderStyle = FormBorderStyle.FixedDialog;
                        MAC.WindowState = FormWindowState.Normal;
                        MAC.MaximizeBox = false;
                        MAC.MinimizeBox = false;
                        MAC.StartPosition = FormStartPosition.CenterParent;
                        MAC.ShowDialog();
                    }

                    btnISPLotFilter.PerformClick();
                }

            }
        }

        private void dgMIR_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgMIR.Rows.Count > 0)
            {
                if (dgMIR.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Y" || dgMIR.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "D")
                {
                    string s_side = dgMIR.Rows[e.RowIndex].Cells[0].Value.ToString();
                    FrmMircoInput MIR = new FrmMircoInput(txtLotID.Text, e.ColumnIndex.ToString().PadLeft(3, '0'), s_side);
                    MIR.FormBorderStyle = FormBorderStyle.FixedDialog;
                    MIR.WindowState = FormWindowState.Normal;
                    MIR.MaximizeBox = false;
                    MIR.MinimizeBox = false;
                    MIR.StartPosition = FormStartPosition.CenterParent;
                    MIR.ShowDialog();
                    btnISPLotFilter.PerformClick();
                }

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearData("1");
        }

        private void txtLotFilter_MouseDown(object sender, MouseEventArgs e)
        {
            btnRefresh.PerformClick();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                btnCreate.PerformClick();
            }
        }

        private void FrmLotInspect_Load(object sender, EventArgs e)
        {
            txtLotFilter.Focus();          
        }

        private void FrmLotInspect_Activated(object sender, EventArgs e)
        {
            if (ComFunc.Trim(txtISPLotFilter.Text) != "")
            {
                btnISPLotFilter.PerformClick();
            }
        }

        private void btnEdite_Click(object sender, EventArgs e)
        {
            //检查数据
            if (CheckCondition("UPDATE") == false) return;
        
                if (SubmitISPLotInfo(GlobConst.TRAN_UPDATE, '2') == false) return;

                txtISPLotFilter.Text = "";
                btnRefresh.PerformClick();
            //btnISPLotFilter.PerformClick();
        }

        private void txtISPLotFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                if (ComFunc.Trim(txtISPLotFilter.Text) != "")
                {
                    btnISPLotFilter.PerformClick();

                }
            }
        }

        private void txtISPFoupFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                if (ComFunc.Trim(txtISPFoupFilter.Text) != "")
                {
                    btnISPLotFilter.PerformClick();

                }
            }
        }
    }
}