using Models.Message;
using Syncfusion.Windows.Forms.Chart;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using WCFModels;
using WCFModels.MESDB.FWTST1;
using WCFModels.Message;
using WcfClient.WcfService;
using Utils;

namespace WcfClient
{
    public partial class EmpForm : BaseForm
    {
        public EmpForm()
        {
            InitializeComponent();
            InitCombox();
            emp_sfDataPager.PageSize = Convert.ToInt32(page_sfComboBox.Text);

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void search_btn_Click(object sender, System.EventArgs e)
        {
            var res = PageQueryEmp(1, System.Convert.ToInt32(page_sfComboBox.Text));
            emp_sfDataGrid.DataSource = res.models;
            emp_sfDataPager.Enabled = true;
            emp_sfDataPager.PageCount = res.TotalPage;

            emp_sfDataPager.Refresh();
            DrawChart();
        }

        private void reset_btn_Click(object sender, System.EventArgs e)
        {
            empId_textBoxExt.ResetText();
            dept_textBoxExt.ResetText();
        }

        private void InitCombox()
        {
            DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn("id");
            DataColumn dc2 = new DataColumn("value");
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);

            DataRow dr1 = dt.NewRow();
            dr1["id"] = "0";
            dr1["value"] = "5";

            DataRow dr2 = dt.NewRow();
            dr2["id"] = "1";
            dr2["value"] = "10";

            DataRow dr3 = dt.NewRow();
            dr3["id"] = "2";
            dr3["value"] = "20";

            DataRow dr4 = dt.NewRow();
            dr4["id"] = "3";
            dr4["value"] = "40";

            dt.Rows.Add(dr1);
            dt.Rows.Add(dr2);
            dt.Rows.Add(dr3);
            dt.Rows.Add(dr4);

            page_sfComboBox.DataSource = dt;
            page_sfComboBox.ValueMember = "id";
            page_sfComboBox.DisplayMember = "value";

            page_sfComboBox.SelectedIndex = 1;    
        }

        private bool TextVaildCheck()
        {
            return true;
        }


        private PageModelRsp<Emp> PageQueryEmp(int index,int pageSize)
        {
            QueryEmpReq queryEmpReq = AllocateQueryEmpReq(index, pageSize);
            return WcfServiceHelper.WcfClient().QueryEmpInfo(queryEmpReq);
        }

        private void DrawChart()
        {
            QueryReq queryReq = new QueryReq();
            var percentRes = SingletonT<WcfContractClient>.Instance.QueryEmpPercent(queryReq).models;
            var sumRes = WcfServiceHelper.WcfClient().QueryEmpSum(queryReq).models;

            if (empChartControl.Visible == false)
            {
                empChartControl.Visible = true;
            }

            if (empPieChartControl.Visible == false)
            {
                empPieChartControl.Visible = true;
            }

            empChartControl.ResetChart();
            empChartControl.AddSeries("Sum", sumRes, ChartSeriesType.Column, true);

            empChartControl.AddSecY(ChartAxesLayoutMode.Stacking,ChartTitleDrawMode.Wrap);
            empChartControl.AddSeries("Percent", percentRes, ChartSeriesType.Line, false);
            empChartControl.SetLegend();
            empChartControl.Skins = Skins.Metro;
            empChartControl.Series3D = true;

            empPieChartControl.ResetChart();
            empPieChartControl.AddSeries("Sum", sumRes, ChartSeriesType.Pie, true);
            
            empPieChartControl.SetLegend();
            empPieChartControl.Skins = Skins.Metro;
            empPieChartControl.Series3D = true;
        }

        private QueryEmpReq AllocateQueryEmpReq(int index, int pageSize)
        {
            string empId = empId_textBoxExt.Text.Trim();
            string dept = dept_textBoxExt.Text.Trim();
            bool isFirstCon = true;

            QueryEmpReq queryEmpReq = new QueryEmpReq()
            {
                queryConditionList = new List<QueryCondition>(),
                sortCondittionList = new List<SortCondition>()
            };

            queryEmpReq.CurrentPage = index;
            queryEmpReq.ItemsPerPage = pageSize;
            if (!string.IsNullOrEmpty(empId))
            {
                QueryCondition queryCon = new QueryCondition()
                {
                    paramName = "Id",
                    compareType = CompareType.Equal,
                    conditionType = LogicCondition.AndAlso,
                    value = empId
                };
                queryEmpReq.queryConditionList.Add(queryCon);
                isFirstCon = false;
            }
            if (!string.IsNullOrEmpty(dept))
            {
                QueryCondition queryCon = new QueryCondition()
                {
                    paramName = "DeptCode",
                    compareType = CompareType.Equal,
                    value = dept
                };

                if (isFirstCon)
                {
                    queryCon.conditionType = LogicCondition.AndAlso;
                }
                else
                {
                    queryCon.conditionType = LogicCondition.AndAlso;
                }
                queryEmpReq.queryConditionList.Add(queryCon);
            }

            SortCondition sortCon = new SortCondition()
            {
                paramName = "Id",
                sortType = SortType.ASC
            };

            queryEmpReq.sortCondittionList.Add(sortCon);

            return queryEmpReq;
        }

        private void empChartControl_ChartRegionClick(object sender, ChartRegionMouseEventArgs e)
        {
            if (empChartControl.Series3D)
            {
                empChartControl.Series3D = false;
            } else
            {                                   
                empChartControl.Series3D = true;
            }
        }

        private void page_sfComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            emp_sfDataPager.PageSize = Convert.ToInt32(page_sfComboBox.Text);
        }

        private void emp_sfDataPager_PageIndexChanged(object sender, Syncfusion.WinForms.DataPager.Events.PageIndexChangedEventArgs e)
        {
            var res = PageQueryEmp(e.NewPageIndex + 1, emp_sfDataPager.PageSize);
            emp_sfDataGrid.DataSource = res.models;
        }

        private void empPieChartControl_ChartRegionClick(object sender, ChartRegionMouseEventArgs e)
        {
            if (empPieChartControl.Series3D)
            {
                empPieChartControl.Series3D = false;
            }
            else
            {
                empPieChartControl.Series3D = true;
            }
        }

        private void EmpForm_Load(object sender, EventArgs e)
        {

        }

        private void UpdateEmp(Emp empInfo ,OperateType operate)
        {
            UpdateModelListReq<Emp> updateReq = new UpdateModelListReq<Emp>();
            updateReq.models.Add(empInfo);
            updateReq.opreateType = operate;

            var res = WcfServiceHelper.WcfClient().UpdateEmpInfo(updateReq);
        }

        private void insert_sfButton_Click(object sender, EventArgs e)
        {
            InsertEmpForm form = new InsertEmpForm();
            form.Show();
        }

        private void update_sfButton_Click(object sender, EventArgs e)
        {
            var record = emp_sfDataGrid.SelectedItem;
            if(record != null)
                UpdateEmp((Emp)record, OperateType.Update);
        }

        private void delete_sfButton_Click(object sender, EventArgs e)
        {
            var record = emp_sfDataGrid.SelectedItem;
            UpdateEmp((Emp)record, OperateType.Delete);
            emp_sfDataGrid.DeleteSelectedRecords();
            emp_sfDataGrid.Refresh();
        }
    }
}
