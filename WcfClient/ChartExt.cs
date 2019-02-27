using Syncfusion.Windows.Forms.Chart;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using WCFModels.MESDB.FWTST1;

namespace WcfClient
{
    public static class ChartExt
    {
        public static void AddSeries<T>(this ChartControl chartControl, string SeriesName, IList<T> SeriesDataList, ChartSeriesType seriesChartType,bool isPrimary) where T : CBaseView
        {
            ChartSeries empSumSeries = new ChartSeries(SeriesName);
            empSumSeries.Type = seriesChartType;

            switch (seriesChartType)
            {
                case ChartSeriesType.Spline:
                case ChartSeriesType.StepLine:
                case ChartSeriesType.Line:
                case ChartSeriesType.Column:
                    //Config X,Y axes
                    CategoryAxisDataBindModel empSumSeriesModel = new CategoryAxisDataBindModel(SeriesDataList);
                    empSumSeriesModel.CategoryName = "name";
                    empSumSeriesModel.YNames = new string[] { "value" };
                    empSumSeries.CategoryModel = empSumSeriesModel;

                    if(seriesChartType != ChartSeriesType.Column)
                    {
                        empSumSeries.Style.Symbol.Shape = ChartSymbolShape.Diamond;
                    }

                    if (!isPrimary)
                    {
                        empSumSeries.YAxis = chartControl.Axes[2];
                    }
                    chartControl.PrimaryXAxis.ValueType = ChartValueType.Category;
                    break;

                case ChartSeriesType.Pie:
                    foreach (T q in SeriesDataList)
                    {
                        empSumSeries.Points.Add(q.name, Convert.ToDouble(q.value));
                    }

                    break;
            }
            chartControl.Series.Add(empSumSeries);
        }

        public static void AddSecY(this ChartControl chartControl, ChartAxesLayoutMode chartAxesLayoutMode,ChartTitleDrawMode chartTitleDrawMode)
        {
            ChartAxis secYAxis = new ChartAxis();
            secYAxis.DrawGrid = false;
            secYAxis.HidePartialLabels = true;
            secYAxis.OpposedPosition = true;
            secYAxis.LabelIntersectAction = ChartLabelIntersectAction.Rotate;
            //secYAxis.LineType.ForeColor = Color.FromArgb(213, 219, 204);
            //secYAxis.ValueType = ChartValueType.Double;
            secYAxis.Orientation = ChartOrientation.Vertical;
            //secYAxis.GridLineType.BackColor = Color.FromArgb(250, 209, 150, 150);
            //secYAxis.GridLineType.ForeColor = Color.FromArgb(250, 230, 193, 193);
            secYAxis.GridLineType.PenType = System.Drawing.Drawing2D.PenType.LinearGradient;
            secYAxis.GridLineType.Width = 0;
            secYAxis.TitleDrawMode = chartTitleDrawMode;
            //secYAxis.LineType.ForeColor = Color.FromArgb(213, 219, 204);

            chartControl.Axes.Add(secYAxis);
            chartControl.ChartArea.YAxesLayoutMode = chartAxesLayoutMode;
            //axisDic.Add("secondyAxis", secYAxis);
        }

        public static void SetLegend (this ChartControl chartControl)
        {
            for (int i = 0; i < chartControl.Legend.Items.Length; ++i)
            {
               // chartControl.Legend.Items[i].Spacing = 4;
               // chartControl.Legend.ItemsSize = new Size(13, 13);
                chartControl.Legend.Items[i].TextAligment = VerticalAlignment.Bottom;
                chartControl.Legend.Alignment = ChartAlignment.Center;
                chartControl.Legend.Position = ChartDock.Bottom;
                chartControl.LegendsPlacement = ChartPlacement.Outside;
                chartControl.Legend.RepresentationType = ChartLegendRepresentationType.Rectangle;
            }
        }

        public static void ResetChart (this ChartControl chartControl)
        {
            chartControl.Series.Clear();
            for (int i = 2;i< chartControl.Axes.Count;++i)
            {
                //保留primay x,y
                chartControl.Axes.RemoveAt(i);
            }
        }
    }
}