using OQA_Core;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WcfClientCore.Utils.Authority;
using WCFModels.Message;
using WCFModels.OQA;

namespace OQAMain
{
    public partial class FrmLotPackageCheck : OQABaseForm
    {
        private LotPackageView lotPackageInfo;
        private OperateType operateType;

        public FrmLotPackageCheck()
        {
            InitializeComponent();
            InitsfDataGrid();
        }

        private List<PKGCHKRST> GetDefaultCheckList()
        {
            List<PKGCHKRST> defaultChecklist = new List<PKGCHKRST>();
            if (null == lotPackageInfo) return defaultChecklist;

            string uId = AuthorityControl.GetUserProfile().userId;

            PKGCHKRST checkItemF = new PKGCHKRST
            {
                ChkDesc = "No chipping,crack and cross in FOSB",
                ChkMethod = "Visual",
                ChkResult = "OK",
                ChkType = CheckType.FOSB_C,
                LotId = lotPackageInfo.lotInfo.LotId,
                FoupId = lotPackageInfo.lotInfo.FoupId,
                CreateUserId = uId,
                CreateTime = " ",
                UpdateTime = " ",
                UpdateUserId = " ",
                Cmf1 = " ",
                Cmf2 = " ",
                Cmf3 = " ",
                Cmf4 = " ",
                Cmf5 = " ",
                Cmf6 = " ",
                Cmf7 = " ",
                Cmf8 = " ",
                Cmf9 = " ",
                Cmf10 = " "
            };
            PKGCHKRST checkItemSP = new PKGCHKRST
            {
                ChkDesc = "Shipping label correctly sticked on FOSB and anti-static bag",
                ChkMethod = "Visual",
                ChkResult = "OK",
                ChkType = CheckType.SHIP_C,
                LotId = lotPackageInfo.lotInfo.LotId,
                FoupId = lotPackageInfo.lotInfo.FoupId,
                CreateUserId = uId,
                CreateTime = " ",
                UpdateTime = " ",
                UpdateUserId = " ",
                Cmf1 = " ",
                Cmf2 = " ",
                Cmf3 = " ",
                Cmf4 = " ",
                Cmf5 = " ",
                Cmf6 = " ",
                Cmf7 = " ",
                Cmf8 = " ",
                Cmf9 = " ",
                Cmf10 = " "
            };
            PKGCHKRST checkItemSur = new PKGCHKRST
            {
                ChkDesc = "Clear handwriting,no dirt and damage on the surface of shipping label",
                ChkMethod = "Visual",
                ChkResult = "OK",
                ChkType = CheckType.SURFACE_C,
                LotId = lotPackageInfo.lotInfo.LotId,
                FoupId = lotPackageInfo.lotInfo.FoupId,
                CreateUserId = uId,
                CreateTime = " ",
                UpdateTime = " ",
                UpdateUserId = " ",
                Cmf1 = " ",
                Cmf2 = " ",
                Cmf3 = " ",
                Cmf4 = " ",
                Cmf5 = " ",
                Cmf6 = " ",
                Cmf7 = " ",
                Cmf8 = " ",
                Cmf9 = " ",
                Cmf10 = " "
            };
            PKGCHKRST checkItemPac = new PKGCHKRST
            {
                ChkDesc = "Smooth,flat and no bubble in sealing of packaging",
                ChkMethod = "Visual",
                ChkResult = "OK",
                ChkType = CheckType.PACKING_C,
                LotId = lotPackageInfo.lotInfo.LotId,
                FoupId = lotPackageInfo.lotInfo.FoupId,
                CreateUserId = uId,
                CreateTime = " ",
                UpdateTime = " ",
                UpdateUserId = " ",
                Cmf1 = " ",
                Cmf2 = " ",
                Cmf3 = " ",
                Cmf4 = " ",
                Cmf5 = " ",
                Cmf6 = " ",
                Cmf7 = " ",
                Cmf8 = " ",
                Cmf9 = " ",
                Cmf10 = " "
            };
            PKGCHKRST checkItemPin = new PKGCHKRST
            {
                ChkDesc = "No pin hole,damage and bump in sealing of packaging",
                ChkMethod = "Visual",
                ChkResult = "OK",
                ChkType = CheckType.PIN_C,
                LotId = lotPackageInfo.lotInfo.LotId,
                FoupId = lotPackageInfo.lotInfo.FoupId,
                CreateUserId = uId,
                CreateTime = " ",
                UpdateTime = " ",
                UpdateUserId = " ",
                Cmf1 = " ",
                Cmf2 = " ",
                Cmf3 = " ",
                Cmf4 = " ",
                Cmf5 = " ",
                Cmf6 = " ",
                Cmf7 = " ",
                Cmf8 = " ",
                Cmf9 = " ",
                Cmf10 = " "
            };

            PKGCHKRST checkItemPeel = new PKGCHKRST
            {
                ChkDesc = "No peel off phenomenon in material interface after packaging",
                ChkMethod = "Visual",
                ChkResult = "OK",
                ChkType = CheckType.PEEL_C,
                LotId = lotPackageInfo.lotInfo.LotId,
                FoupId = lotPackageInfo.lotInfo.FoupId,
                CreateUserId = uId,
                CreateTime = " ",
                UpdateTime = " ",
                UpdateUserId = " ",
                Cmf1 = " ",
                Cmf2 = " ",
                Cmf3 = " ",
                Cmf4 = " ",
                Cmf5 = " ",
                Cmf6 = " ",
                Cmf7 = " ",
                Cmf8 = " ",
                Cmf9 = " ",
                Cmf10 = " "
            };

            PKGCHKRST checkItemSeal = new PKGCHKRST
            {
                ChkDesc = "No fuse infirm in sealing interface (pull the fuse sealing to flat by manual)",
                ChkMethod = "Manual",
                ChkResult = "OK",
                ChkType = CheckType.SEAL_C,
                LotId = lotPackageInfo.lotInfo.LotId,
                FoupId = lotPackageInfo.lotInfo.FoupId,
                CreateUserId = uId,
                CreateTime = " ",
                UpdateTime = " ",
                UpdateUserId = " ",
                Cmf1 = " ",
                Cmf2 = " ",
                Cmf3 = " ",
                Cmf4 = " ",
                Cmf5 = " ",
                Cmf6 = " ",
                Cmf7 = " ",
                Cmf8 = " ",
                Cmf9 = " ",
                Cmf10 = " "
            };

            PKGCHKRST checkItemFore = new PKGCHKRST
            {
                ChkDesc = "No foreign material residues in the sealing of packaging",
                ChkMethod = "Visual",
                ChkResult = "OK",
                ChkType = CheckType.FOREIGN_C,
                LotId = lotPackageInfo.lotInfo.LotId,
                FoupId = lotPackageInfo.lotInfo.FoupId,
                CreateUserId = uId,
                CreateTime = " ",
                UpdateTime = " ",
                UpdateUserId = " ",
                Cmf1 = " ",
                Cmf2 = " ",
                Cmf3 = " ",
                Cmf4 = " ",
                Cmf5 = " ",
                Cmf6 = " ",
                Cmf7 = " ",
                Cmf8 = " ",
                Cmf9 = " ",
                Cmf10 = " "
            };

            defaultChecklist.Add(checkItemF);
            defaultChecklist.Add(checkItemSP);
            defaultChecklist.Add(checkItemSur);
            defaultChecklist.Add(checkItemPac);
            defaultChecklist.Add(checkItemPin);
            defaultChecklist.Add(checkItemPeel);
            defaultChecklist.Add(checkItemSeal);
            defaultChecklist.Add(checkItemFore);

            lotPackageInfo.packageCheckList = defaultChecklist;
            return defaultChecklist;
        }

        private void InitsfDataGrid()
        {
            check_sfDataGrid.AutoGenerateColumns = false;

            GridTextColumn checkDesc = new GridTextColumn();
            checkDesc.MappingName = "ChkDesc";
            checkDesc.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCellsWithLastColumnFill;
            check_sfDataGrid.Columns.Add(checkDesc);

            GridComboBoxColumn checkMethodCol = new GridComboBoxColumn();
            List<string> methodList = new List<string>();
            methodList.Add("Visual");
            methodList.Add("Manual");
            checkMethodCol.DataSource = methodList;
            checkMethodCol.MappingName = "ChkMethod";
            checkMethodCol.MinimumWidth = 350;
            checkMethodCol.MaximumWidth = 450;
            check_sfDataGrid.Columns.Add(checkMethodCol);


            List<string> resultList = new List<string>();
            resultList.Add("OK");
            resultList.Add("NG");
            GridComboBoxColumn checkResultCol = new GridComboBoxColumn();
            checkResultCol.DataSource = resultList;
            checkResultCol.MappingName = "ChkResult";
            checkResultCol.MinimumWidth = 350;
            checkResultCol.MaximumWidth = 450;
            check_sfDataGrid.Columns.Add(checkResultCol);

            GridTextColumn LotIdCol = new GridTextColumn();
            LotIdCol.MappingName = "LotId";
            LotIdCol.Visible = false;
            check_sfDataGrid.Columns.Add(LotIdCol);

            GridTextColumn FoupIdCol = new GridTextColumn();
            FoupIdCol.MappingName = "FoupId";
            FoupIdCol.Visible = false;
            check_sfDataGrid.Columns.Add(FoupIdCol);

            GridTextColumn ChkTypeCol = new GridTextColumn();
            ChkTypeCol.MappingName = "ChkType";
            ChkTypeCol.Visible = false;
            check_sfDataGrid.Columns.Add(ChkTypeCol);

            GridTextColumn Cmf1Col = new GridTextColumn();
            Cmf1Col.MappingName = "Cmf1";
            Cmf1Col.Visible = false;
            check_sfDataGrid.Columns.Add(Cmf1Col);

            GridTextColumn Cmf2Col = new GridTextColumn();
            Cmf2Col.MappingName = "Cmf2";
            Cmf2Col.Visible = false;
            check_sfDataGrid.Columns.Add(Cmf2Col);

            GridTextColumn Cmf3Col = new GridTextColumn();
            Cmf3Col.MappingName = "Cmf3";
            Cmf3Col.Visible = false;
            check_sfDataGrid.Columns.Add(Cmf3Col);

            GridTextColumn Cmf4Col = new GridTextColumn();
            Cmf4Col.MappingName = "Cmf4";
            Cmf4Col.Visible = false;
            check_sfDataGrid.Columns.Add(Cmf4Col);

            GridTextColumn Cmf5Col = new GridTextColumn();
            Cmf5Col.MappingName = "Cmf5";
            Cmf5Col.Visible = false;
            check_sfDataGrid.Columns.Add(Cmf5Col);

            GridTextColumn Cmf6Col = new GridTextColumn();
            Cmf6Col.MappingName = "Cmf6";
            Cmf6Col.Visible = false;
            check_sfDataGrid.Columns.Add(Cmf6Col);

            GridTextColumn Cmf7Col = new GridTextColumn();
            Cmf7Col.MappingName = "Cmf7";
            Cmf7Col.Visible = false;
            check_sfDataGrid.Columns.Add(Cmf7Col);

            GridTextColumn Cmf8Col = new GridTextColumn();
            Cmf8Col.MappingName = "Cmf8";
            Cmf8Col.Visible = false;
            check_sfDataGrid.Columns.Add(Cmf8Col);

            GridTextColumn Cmf9Col = new GridTextColumn();
            Cmf9Col.MappingName = "Cmf9";
            Cmf9Col.Visible = false;
            check_sfDataGrid.Columns.Add(Cmf9Col);

            GridTextColumn Cmf10Col = new GridTextColumn();
            Cmf10Col.MappingName = "Cmf10";
            Cmf10Col.Visible = false;
            check_sfDataGrid.Columns.Add(Cmf10Col);

            GridTextColumn TransSeqCol = new GridTextColumn();
            TransSeqCol.MappingName = "TransSeq";
            TransSeqCol.Visible = false;
            check_sfDataGrid.Columns.Add(TransSeqCol);

            GridTextColumn CreateTimeCol = new GridTextColumn();
            CreateTimeCol.MappingName = "CreateTime";
            CreateTimeCol.Visible = false;
            check_sfDataGrid.Columns.Add(CreateTimeCol);

            GridTextColumn CreateUserIdCol = new GridTextColumn();
            CreateUserIdCol.MappingName = "CreateUserId";
            CreateUserIdCol.Visible = false;
            check_sfDataGrid.Columns.Add(CreateUserIdCol);

            GridTextColumn UpdateTimeCol = new GridTextColumn();
            UpdateTimeCol.MappingName = "UpdateTime";
            UpdateTimeCol.Visible = false;
            check_sfDataGrid.Columns.Add(UpdateTimeCol);

            GridTextColumn UpdateUserIdCol = new GridTextColumn();
            UpdateUserIdCol.MappingName = "UpdateUserId";
            UpdateUserIdCol.Visible = false;
            check_sfDataGrid.Columns.Add(UpdateUserIdCol);
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
                FillSfDataGrid();
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


        private void FillSfDataGrid()
        {
            if (null == lotPackageInfo) return;
            if(lotPackageInfo.packageCheckList.Count > 0)
            {
                operateType = OperateType.Update;
                check_sfDataGrid.DataSource = lotPackageInfo.packageCheckList;
            }
            else
            {
                operateType = OperateType.Insert;
                check_sfDataGrid.DataSource = GetDefaultCheckList();
            }

        }

        private List<PKGCHKRST> lst_pkg;

        private bool CheckCondition(string FuncName)
        {
            switch (ComFunc.Trim(FuncName))
            {
                case "CREATE":
                    break;
                case "UPDATE":
                    // TODO
                    if (check_sfDataGrid.RowCount > 0)
                    {
                        lst_pkg = (List<PKGCHKRST>)check_sfDataGrid.DataSource;

                        if (lst_pkg.Count(p => p.ChkResult=="NG") > 0)
                        {
                            MessageBox.Show("Please check 'NG' item！");
                            return false;
                        }

                    }
                    return ValidateLotInfo();
                    break;

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

        private void ClearForm()
        {
            lotId_textBox.Text = string.Empty;
            lotPackageInfo = null;
            check_sfDataGrid.DataSource = null;
        }

        private void btnEdite_Click(object sender, EventArgs e)
        {
            if (!CheckCondition("UPDATE")) return;

            lotPackageInfo.lotInfo.Status = LotSts.PackageOut;
            lotPackageInfo.lotInfo.UpdateUserId = AuthorityControl.GetUserProfile().userId;
            UpdateModelReq<LotPackageView> updateReq = new UpdateModelReq<LotPackageView>();
            updateReq.userId = AuthorityControl.GetUserProfile().userId;
            updateReq.operateType = operateType;
            updateReq.model.lotInfo = lotPackageInfo.lotInfo;
            updateReq.model.packageCheckList = (List<PKGCHKRST>)check_sfDataGrid.DataSource;
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
            updateReq.operateType = operateType;
            updateReq.models = (List<PKGCHKRST>)check_sfDataGrid.DataSource;
            updateReq.userId = AuthorityControl.GetUserProfile().userId;

            try
            {
                var res = OQASrv.Call.UpdateLotCheckList(updateReq);
                lotPackageInfo.packageCheckList = res.models;
                check_sfDataGrid.DataSource = res.models;
                operateType = OperateType.Update;
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

        private void print_button_Click(object sender, EventArgs e)
        {
            if (!ValidateLotInfo()) return;
            FrmWaferInspectRecordPrint printForm = new FrmWaferInspectRecordPrint(lotPackageInfo.lotInfo.LotId);

            AddNewFormToMdi(printForm);
        }
    }
}