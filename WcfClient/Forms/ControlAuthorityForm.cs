using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WcfClientCore.Form;
using WcfClientCore.WcfSrv;
using WCFModels;
using WCFModels.Frame;
using WCFModels.Message;

namespace WcfClient.Forms
{
    public partial class ControlAuthorityForm : ChildFormBase
    {
        public ControlAuthorityForm()
        {
            InitializeComponent();
            InitSfDataGrid();
        }

        private void InitSfDataGrid()
        {
            sfDataGrid.AutoGenerateColumns = false;

            GridTextColumn ControlID = new GridTextColumn();
            ControlID.MappingName = "ControlID";
            ControlID.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCellsWithLastColumnFill;
            sfDataGrid.Columns.Add(ControlID);

            GridTextColumn AccessString = new GridTextColumn();
            AccessString.MappingName = "AccessString";
            AccessString.MinimumWidth = 750;
            AccessString.MaximumWidth = 850;
            sfDataGrid.Columns.Add(AccessString);

            GridTextColumn SysName = new GridTextColumn();
            SysName.MinimumWidth = 350;
            SysName.MaximumWidth = 450;
            SysName.MappingName = "SysName";
            SysName.AllowEditing = false;
            sfDataGrid.Columns.Add(SysName);

            GridTextColumn CreateTime = new GridTextColumn();
            CreateTime.MappingName = "CreateTime";
            CreateTime.Visible = false;
            sfDataGrid.Columns.Add(CreateTime);

            GridTextColumn CreateUserId = new GridTextColumn();
            CreateUserId.MappingName = "CreateUserId";
            CreateUserId.Visible = false;
            sfDataGrid.Columns.Add(CreateUserId);

            GridTextColumn UpdateTime = new GridTextColumn();
            UpdateTime.MappingName = "UpdateTime";
            UpdateTime.Visible = false;
            sfDataGrid.Columns.Add(UpdateTime);

            GridTextColumn UpdateUserId = new GridTextColumn();
            UpdateUserId.MappingName = "UpdateUserId";
            UpdateUserId.Visible = false;
            sfDataGrid.Columns.Add(UpdateUserId);
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            ControlAccessString controlAcc = new ControlAccessString()
            {
                ControlID = contrlPath_textBox.Text.Trim(),
                AccessString = accessString_textBox.Text.Trim(),
                SysName = "OQA"
            };

            var rsp = WcfSrv.UpdateControlAccessString(controlAcc, OperateType.Insert);
            if(rsp._success)
            {
                
                if (null != sfDataGrid.DataSource)
                {
                    sfDataGrid.View.Records.Add(controlAcc);
                } else
                {
                    List<ControlAccessString> contrlList = new List<ControlAccessString>();
                    contrlList.Add(controlAcc);
                    sfDataGrid.DataSource = contrlList;
                }

                MessageBox.Show("Insert successed!");
            }
        }

        private void modify_button_Click(object sender, EventArgs e)
        {
            var recoders = sfDataGrid.SelectedItems;
            if ( recoders != null)
            {
                List<ControlAccessString> recs = new List<ControlAccessString>();
                foreach (ControlAccessString ca in sfDataGrid.SelectedItems)
                {
                    recs.Add(ca);
                }
                var res = WcfSrv.UpdateControlAccessStringList(recs, OperateType.Update);
                if(res._success)
                {
                    MessageBox.Show("Modify successed!");
                }
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            var recoders = sfDataGrid.SelectedItems;
            if (recoders != null)
            {
                List<ControlAccessString> recs = new List<ControlAccessString>();
                foreach (ControlAccessString ca in sfDataGrid.SelectedItems)
                {
                    recs.Add(ca);          
                }
                var res = WcfSrv.UpdateControlAccessStringList(recs, OperateType.Delete);
                sfDataGrid.DeleteSelectedRecords();

                foreach (ControlAccessString ca in recs)
                {
                    sfDataGrid.SelectedItems.Remove(ca);
                }
            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            var res = PageQueryContrlAccstring(1, 20);
            if(res._success)
            {
                sfDataGrid.DataSource = res.models;
                sfDataPager.PageCount = res.TotalPage;
                sfDataPager.Refresh();
            } else
            {
                MessageBox.Show("查询出错!");
            }
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            contrlPath_textBox.ResetText();
            accessString_textBox.ResetText();
            ((List<ControlAccessString>)sfDataGrid.DataSource).Clear();
            sfDataGrid.View.Records.Clear();
            sfDataPager.PageCount = 0;
        }

        private void sfDataPager_PageIndexChanged(object sender, Syncfusion.WinForms.DataPager.Events.PageIndexChangedEventArgs e)
        {
            var res = PageQueryContrlAccstring(e.NewPageIndex + 1, sfDataPager.PageSize);
            if(res._success)
                sfDataGrid.DataSource = res.models;
            else
                MessageBox.Show("查询出错!");
        }

        private PageModelRsp<ControlAccessString> PageQueryContrlAccstring(int pageIndex,int pageSize)
        {
            string contrlId = contrlPath_textBox.Text.Trim();
            string accstring = accessString_textBox.Text.Trim();
            PageQueryReq queryReq = new PageQueryReq();
            queryReq.ItemsPerPage = pageSize;
            queryReq.CurrentPage = pageIndex;

            QueryCondition querycon = null;
            if (!string.IsNullOrEmpty(contrlId))
            {
                querycon = new QueryCondition();
                querycon.paramName = "ControlID";
                querycon.value = contrlId;
                querycon.compareType = CompareType.Equal;
                querycon.conditionType = LogicCondition.AndAlso;
                queryReq.queryConditionList.Add(querycon);
            }
            if (!string.IsNullOrEmpty(accstring))
            {
                querycon = new QueryCondition();
                querycon.paramName = "AccessString";
                querycon.value = accstring;
                querycon.compareType = CompareType.Equal;
                querycon.conditionType = LogicCondition.AndAlso;
                queryReq.queryConditionList.Add(querycon);
            }

            querycon = new QueryCondition();
            querycon.paramName = "SYSNAME";
            querycon.value = "OQA";
            querycon.compareType = CompareType.Equal;
            querycon.conditionType = LogicCondition.AndAlso;
            queryReq.queryConditionList.Add(querycon);

            SortCondition sortCon = new SortCondition()
            {
                paramName = "ControlID",
                sortType = SortType.ASC
            };

            queryReq.sortCondittionList.Add(sortCon);
            return WcfSrv.WcfClient.PageQueryControlAccessString(queryReq);
        }
    }
}