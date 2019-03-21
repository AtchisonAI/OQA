using OQA_Core;
using Syncfusion.Windows.Forms.Chart;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WcfClientCore.Form;
using WcfClientCore.Utils.Chart;
using WCFModels;
using WCFModels.MESDB.FWTST1;
using WCFModels.Message;

namespace OQAMain
{
    public partial class EmpForm :BaseForm
    {
        public EmpForm()
        {
            InitializeComponent();
            emp_sfDataPager.PageSize = Convert.ToInt32(page_sfComboBox.Text);
        }

        private void insert_button_Click(object sender, EventArgs e)
        {
            InsertEmpForm form = new InsertEmpForm();
            form.Show();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            var record = emp_sfDataGrid.SelectedItem;
            UpdateEmp((Emp)record, OperateType.Update);
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            var record = emp_sfDataGrid.SelectedItem;
            UpdateEmp((Emp)record, OperateType.Delete);
            emp_sfDataGrid.DeleteSelectedRecords();
            emp_sfDataGrid.Refresh();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            var res = PageQueryEmp(1, System.Convert.ToInt32(page_sfComboBox.Text));
            emp_sfDataGrid.DataSource = res.models;
            emp_sfDataPager.Enabled = true;
            emp_sfDataPager.PageCount = res.TotalPage;

            emp_sfDataPager.Refresh();

            DrawChart();
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            empId_textBoxExt.ResetText();
            dept_textBoxExt.ResetText();
        }

        private void empChartControl_Click(object sender, EventArgs e)
        {
            if (empChartControl.Series3D)
            {
                empChartControl.Series3D = false;
            }
            else
            {
                empChartControl.Series3D = true;
            }
        }

        private void empPieChartControl_Click(object sender, EventArgs e)
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

        private void DrawChart()
        {
            QueryReq queryReq = new QueryReq();
            var percentRes = OQASrv.Call.QueryEmpPercent(queryReq).models;
            var sumRes = OQASrv.Call.QueryEmpSum(queryReq).models;

            if (empChartControl.Visible == false)
            {
                empChartControl.Visible = true;
            }

            if (empPieChartControl.Visible == false)
            {
                empPieChartControl.Visible = true;
            }

            empChartControl.ResetChart();
            empChartControl.AddSeries("Percent", percentRes, ChartSeriesType.Line, true);
            

            empChartControl.AddSecY(ChartAxesLayoutMode.Stacking, ChartTitleDrawMode.Wrap);
            empChartControl.AddSeries("Sum", sumRes, ChartSeriesType.Column, false);
            empChartControl.SetLegend();
            empChartControl.Skins = Skins.Metro;
            empChartControl.Series3D = true;

            empPieChartControl.ResetChart();
            empPieChartControl.AddSeries("Sum", sumRes, ChartSeriesType.Pie, true);

            empPieChartControl.SetLegend();
            empPieChartControl.Skins = Skins.Metro;
            empPieChartControl.Series3D = true;
        }

        private void sfDataPager_PageIndexChanged(object sender, Syncfusion.WinForms.DataPager.Events.PageIndexChangedEventArgs e)
        {
            var res = PageQueryEmp(e.NewPageIndex + 1, emp_sfDataPager.PageSize);
            emp_sfDataGrid.DataSource = res.models;
        }

        private PageModelRsp<Emp> PageQueryEmp(int index, int pageSize)
        {
            QueryEmpReq queryEmpReq = AllocateQueryEmpReq(index, pageSize);
            return OQASrv.Call.QueryEmpInfo(queryEmpReq);
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

        private void UpdateEmp(Emp empInfo, OperateType operate)
        {
            UpdateModelListReq<Emp> updateReq = new UpdateModelListReq<Emp>();
            updateReq.models.Add(empInfo);
            updateReq.operateType = operate;

            var res = OQASrv.Call.UpdateEmpInfo(updateReq);
        }

        private void page_sfComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            emp_sfDataPager.PageSize = Convert.ToInt32(page_sfComboBox.Text);
        }
    }
}
