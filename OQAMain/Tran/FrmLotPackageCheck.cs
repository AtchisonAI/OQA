using OQA_Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using WcfClientCore.Utils.Authority;
using WCFModels.Message;
using WCFModels.OQA;

namespace OQAMain
{
    public partial class FrmLotPackageCheck : OQABaseForm
    {
        private LotPackageView lotPackageInfo;

        public FrmLotPackageCheck()
        {
            InitializeComponent();
            SetCheckBoxEnabled(false);
            SetCheckItemStatus(false);
        }

        public void SetCheckBoxEnabled(bool b_Enable)
        {
            FieldInfo[] fieldInfo = this.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (FieldInfo fi in fieldInfo)
            {
                switch (fi.FieldType.Name)
                {
                    case "CheckBox":
                        CheckBox Item = (CheckBox)fi.GetValue(this);
                        if(null != Item)
                            Item.Enabled = b_Enable;
                        break;
                }
            }
        }

        public void SetCheckItemStatus(bool b_status)
        {
            FieldInfo[] fieldInfo = this.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (FieldInfo fi in fieldInfo)
            {
                switch (fi.FieldType.Name)
                {
                    case "CheckBox":
                        CheckBox Item = (CheckBox)fi.GetValue(this);
                        if (null != Item) 
                            Item.Checked = b_status;
                        break;
                }
            }
        }

        private void lotId_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ComFunc.CheckEnterKey(e))
            {
                //查询当前输入的lot
                QueryCurrentLotPackInfo();
            }
        }

        private void QueryCurrentLotPackInfo()
        {
            string lotId = lotId_textBox.Text.Trim();
            if (string.IsNullOrEmpty(lotId))
            {
                MessageBox.Show("请输入lotID");
                lotId_textBox.Focus();
                return;
            }

            var res = QueryLotPackageInfo(lotId);
            if (res._success)
            {
                lotPackageInfo = res.model;
                InitCheckBox(lotPackageInfo.packageCheckList);
                fosb_checkBox.Focus();
            }
            else
            {
                MessageBox.Show(res._ErrorMsg);
                lotId_textBox.Focus();
            }
        }

        private ModelRsp<LotPackageView> QueryLotPackageInfo(string lotIdInput)
        {
            LotPackageInput input = new LotPackageInput()
            {
                lotId = lotIdInput
            };
            try
            {
                return OQASrv.Call.QueryLotPackageInfo(input);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw e;
            }
        }

        private void InitCheckBox(List<PKGCHKRST> checkList)
        {
            foreach (PKGCHKRST check in checkList)
            {
                GetChildControlByName<CheckBox>(this, check.ChkType.ToLower().Replace("_c", "_checkBox")).Checked = check.ChkResult.Equals(CheckItemSts.OK) ? true : false;
                GetChildControlByName<ComboBox>(this, check.ChkType.ToLower().Replace("_c", "_comboBox")).Text = check.ChkMethod;
                //switch (check.ChkType)
                //{
                //    case CheckType.FOREIGN_C:
                //        foreign_checkBox.Checked = check.ChkResult.Equals("OK") ? true : false;
                //        break;
                //    case CheckType.SEAL_C:
                //        seal_checkBox.Checked = check.ChkResult.Equals("OK") ? true : false;
                //        break;
                //    case CheckType.PEEL_C:
                //        peel_checkBox.Checked = check.ChkResult.Equals("OK") ? true : false;
                //        break;
                //    case CheckType.PACKING_C:
                //        packing_checkBox.Checked = check.ChkResult.Equals("OK") ? true : false;
                //        break;
                //    case CheckType.SURFACE_C:
                //        surface_checkBox.Checked = check.ChkResult.Equals("OK") ? true : false;
                //        break;
                //    case CheckType.SHIP_C:
                //        ship_checkBox.Checked = check.ChkResult.Equals("OK") ? true : false;
                //        break;
                //    case CheckType.PIN_C:
                //        pin_checkBox.Checked = check.ChkResult.Equals("OK") ? true : false;
                //        break;
                //    case CheckType.FOSB_C:
                //        fosb_checkBox.Checked = check.ChkResult.Equals("OK") ? true : false;
                //        break;
                //}
            }

            SetCheckBoxEnabled(true);
        }

        private bool CheckCondition(string FuncName)
        {
            switch (ComFunc.Trim(FuncName))
            {
                case "CREATE":
                case "UPDATE":
                    // TODO
                    return ValidateLotInfo();

                case "DELETE":
                    // TODO
                    break;
            }

            return true;

        }

        private bool ValidateLotInfo()
        {
            if (null == lotPackageInfo || string.IsNullOrEmpty(lotId_textBox.Text.Trim()))
            {
                MessageBox.Show("无Lot信息！");
                lotId_textBox.Focus();
                return false;
            }
            return true;
        }

        private List<PKGCHKRST> GetLotCheckResList(OperateType operateType)
        {
            if (operateType == OperateType.Insert)
            {
                FieldInfo[] fieldInfo = this.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
                foreach (FieldInfo fi in fieldInfo)
                {
                    switch (fi.FieldType.Name)
                    {
                        case "CheckBox":
                            CheckBox Item = (CheckBox)fi.GetValue(this);
                            if(null != Item)
                            {
                                PKGCHKRST check = new PKGCHKRST();
                                check.ChkDesc = Item.Text;
                                check.ChkMethod = GetChildControlByName<ComboBox>(this, Item.Name.Replace("checkBox", "comboBox")).Text;
                                check.ChkResult = Item.Checked ? CheckItemSts.OK : CheckItemSts.NO;
                                check.ChkType = Item.Name.Replace("checkBox", "c").ToUpper();
                                check.CreateUserId = AuthorityControl.GetUserProfile().userId;
                                check.FoupId = lotPackageInfo.lotInfo.FoupId;
                                check.LotId = lotPackageInfo.lotInfo.LotId;

                                lotPackageInfo.packageCheckList.Add(check);
                            }
                            break;
                    }
                }
            }
            else
            {
                foreach (PKGCHKRST q in lotPackageInfo.packageCheckList)
                {
                    q.ChkResult = GetChildControlByName<CheckBox>(this, q.ChkType.ToLower().Replace("_c", "_checkBox")).Checked ? CheckItemSts.OK : CheckItemSts.NO;
                    q.ChkMethod = GetChildControlByName<ComboBox>(this, q.ChkType.ToLower().Replace("_c", "_comboBox")).Text;
                    q.UpdateUserId = AuthorityControl.GetUserProfile().userId;
                }
            }

            return lotPackageInfo.packageCheckList;
        }


        private T GetChildControlByName<T>(Form obj, string name) where T : Control
        {
            FieldInfo[] fieldInfo = this.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (FieldInfo fi in fieldInfo)
            {
                if (fi.Name.Equals(name))
                    return (T)fi.GetValue(this);
            }

            return null;
        }

        private void ClearForm()
        {
            lotId_textBox.Text = string.Empty;
            lotPackageInfo = null;
            SetCheckBoxEnabled(false);
            SetCheckItemStatus(false);
        }

        private void btnEdite_Click(object sender, EventArgs e)
        {
            if (!CheckCondition("UPDATE")) return;

            lotPackageInfo.lotInfo.Status = LotSts.PackageOut;
            lotPackageInfo.lotInfo.UpdateUserId = AuthorityControl.GetUserProfile().userId;
            UpdateModelReq<LotPackageView> updateReq = new UpdateModelReq<LotPackageView>();
            updateReq.userId = AuthorityControl.GetUserProfile().userId;
            updateReq.operateType = lotPackageInfo.packageCheckList.Count == 0 ?OperateType.Insert:OperateType.Update;
            GetLotCheckResList(updateReq.operateType);
            updateReq.model = lotPackageInfo;
            try
            {
                var res = OQASrv.Call.UpdateLotPackageSts(updateReq);
                print_button.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }

            MessageBox.Show("Lot package submitted!");
            ClearForm();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!CheckCondition("CREATE")) return;
            UpdateModelListReq<PKGCHKRST> updateReq = new UpdateModelListReq<PKGCHKRST>();
            updateReq.userId = AuthorityControl.GetUserProfile().userId;
            updateReq.operateType = lotPackageInfo.packageCheckList.Count == 0 ? OperateType.Insert : OperateType.Update;
            updateReq.models = GetLotCheckResList(updateReq.operateType);
            updateReq.userId = AuthorityControl.GetUserProfile().userId;

            try
            {
                var res = OQASrv.Call.UpdateLotCheckList(updateReq);
                lotPackageInfo.packageCheckList = res.models;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }

            MessageBox.Show("Lot package checkinfo saved!");
        }

        private void lotId_textBox_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}