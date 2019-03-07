using System;
using System.Collections.Generic;
using WcfClientCore.Form;
using WcfClientCore.WcfSrv;
using WCFModels;
using WCFModels.MESDB.FWTST1;
using WCFModels.Message;

namespace WcfClient.Forms
{
    public partial class ControlAuthorityForm : BaseForm
    {
        public ControlAuthorityForm()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            ControlAccessString controlAcc = new ControlAccessString()
            {
                ControlID = contrlPath_textBox.Text.Trim(),
                AccessString = accessString_textBox.Text.Trim()
            };

            WcfSrv.UpdateControlAccessString(controlAcc, OperateType.Insert);
            List<ControlAccessString> contrlList = new List<ControlAccessString>();
            contrlList.Add(controlAcc);

            sfDataGrid.DataSource = contrlList;
            sfDataPager.PageCount = 1;
            sfDataPager.Refresh();
        }

        private void modify_button_Click(object sender, EventArgs e)
        {
            var recoder = sfDataGrid.SelectedItem;
            if ( recoder != null)
            {
                WcfSrv.UpdateControlAccessString((ControlAccessString)recoder, OperateType.Update);
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            var recoder = sfDataGrid.SelectedItem;
            if (recoder != null)
            {
                WcfSrv.UpdateControlAccessString((ControlAccessString)recoder,OperateType.Delete);
            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            var res = PageQueryContrlAccstring(1, 20);
            sfDataGrid.DataSource = res.models;
            sfDataPager.PageCount = res.TotalPage;
            sfDataPager.Refresh();
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            contrlPath_textBox.ResetText();
            accessString_textBox.ResetText();
        }

        private void sfDataPager_PageIndexChanged(object sender, Syncfusion.WinForms.DataPager.Events.PageIndexChangedEventArgs e)
        {
            var res = PageQueryContrlAccstring(e.NewPageIndex + 1, sfDataPager.PageSize);
            sfDataGrid.DataSource = res.models;
        }

        private PageModelRsp<ControlAccessString> PageQueryContrlAccstring(int pageIndex,int pageSize)
        {
            string contrlId = contrlPath_textBox.Text.Trim();
            string accstring = accessString_textBox.Text.Trim();
            PageQueryReq queryReq = new PageQueryReq();

            if (!string.IsNullOrEmpty(contrlId))
            {
                QueryCondition querycon = new QueryCondition()
                {
                    paramName = "ControlID",
                    value = contrlId,
                    compareType = CompareType.Equal,
                    conditionType = LogicCondition.AndAlso
                };
                queryReq.queryConditionList.Add(querycon);
            }
            if (!string.IsNullOrEmpty(accstring))
            {
                QueryCondition querycon = new QueryCondition()
                {
                    paramName = "AccessString",
                    value = accstring,
                    compareType = CompareType.Equal,
                    conditionType = LogicCondition.AndAlso
                };
                queryReq.queryConditionList.Add(querycon);
            }

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