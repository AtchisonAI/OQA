﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using WCFModels.OQA;
using OQA_Core.Controls;
using OQA_Core;

namespace WaferSf
{
    public partial class WaferSur : UserControl
    {
        #region Variable Definition 
        int i = 0;
        Regex regExp = new Regex(@"^[A-Za-z]+(,[A-Za-z])*$");//可能带逗号的字符串
        String newText;//ccbox新选的值
        public Panel selectPanel;//当前操作的panel
        public string[] defectCode = new string[25];
        public string textValue = "";
        public System.Windows.Forms.TextBox codeBox;
        public System.Windows.Forms.GroupBox groupNode;
        public Boolean nodeMode = false;
        #endregion

        #region Windows Form auto generated code 
        public WaferSur()
        {
            InitializeComponent();
        }
        #endregion

        #region Page Load
        public void WaferSur_Load(object sender, EventArgs e)
        {
            if (nodeMode)
            {
                string[] nineList = { "11", "13", "15", "3", "23", "17", "7", "9", "19"};

                foreach (Control control in tableLayoutPanel1.Controls)
                {
                    if (control is Panel)
                    {
                        Panel p = control as Panel;
                        if (!nineList.Contains(p.Name.Split('_')[1]))
                        {
                            p.Enabled = false;
                        }

                    }
                }
            }
        }
        #endregion

        #region Function Definition 
        //画单个panel
        private void drawPanel(PaintEventArgs e, Panel panelNum)
        {//绘表格
            Graphics g = e.Graphics;
            Brush br = Brushes.Black;
            Color col = Color.Black;
            try
            {
                string code = panelNum.Name.Split('_')[1];
                i = int.Parse(panelNum.Name.Split('_')[1]) - 1;
                if (null != defectCode[i])//非第一次选择
                {
                    code = defectCode[i];
                    col = Color.Blue;
                }

                if (null != newText && !regExp.IsMatch(newText))//回选数字
                {
                    col = Color.Black;
                    code = newText;
                }

                SizeF sizeF = g.MeasureString(code, new Font("微软雅黑", 10));
                Font codeStyle = new Font("微软雅黑", 10, FontStyle.Regular);
                if (!panelNum.Enabled && nodeMode)
                {
                    col = Color.Gray;
                }
                g.DrawString(code, codeStyle,
                    new SolidBrush(col), new PointF((panelNum.Width - sizeF.Width) / 2, (panelNum.Height - sizeF.Height) / 2));
                g.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }

        }
        //清除所有panel
        public void clearPanel()
        {
            defectCode = new string[25];
            this.getDefectCodeValue();
            newText = null;
            try
            {
                foreach (var control in this.tableLayoutPanel1.Controls)
                {
                    if (control is Panel)
                    {
                        Panel p = control as Panel;
                        p.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }

        }
        //画5*5表格框
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {//画圆
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Blue, 3);
            g.DrawEllipse(pen, tableLayoutPanel1.Location.X, tableLayoutPanel1.Location.Y, tableLayoutPanel1.Width, tableLayoutPanel1.Height);
        }
        //panelDoubleClick公用方法
        private void panelDoubleClick(object sender, EventArgs e, Panel panelNum)
        {//双击小格子触发方法
            ComboBox cc = new ComboBox();
            cc.Font = new System.Drawing.Font("宋体", 15);
            cc.Dock = DockStyle.Fill;
            String value = panelNum.Name.Split('_')[1]; ;//panel数
            cc.Items.AddRange(DefectCodeList.code);
            cc.Items.Add(value);
            panelNum.Controls.Add(cc);
            cc.SelectedIndexChanged += cc_SelectedIndexChanged;
            cc.DroppedDown = true;
            cc.MouseLeave += this.panel_MouseLeave;


        }
        //code下拉框indexChange方法
        void cc_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 下拉框获取文本，panel移除控件
            string[] selectList = { };
            try
            {
                newText = (sender as ComboBox).Text;
                if (null != defectCode[i])
                {
                    selectList = defectCode[i].Split(',');
                    if (regExp.IsMatch(defectCode[i]) && regExp.IsMatch(newText))
                    {
                        if (selectList.Length < 3)
                        {
                            if (Array.IndexOf(selectList, newText) == -1)
                            {
                                defectCode[i] += ',' + newText;

                            }
                        }
                        else
                        {
                            selectPanel.Controls.Clear();
                            MessageBox.Show("最多选择3个defect code!");
                        }

                    }
                    else
                    {
                        defectCode[i] = null;
                    }
                }
                else
                {
                    if (regExp.IsMatch(newText))
                    {
                        defectCode[i] = newText;
                    }
                }
                selectPanel.Controls.Clear();
                selectPanel.Refresh();
                this.getDefectCodeValue();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }

        }
        //获取defectCode文本框的数据（外部用）
        public void getDefectCodeValue()
        {//动态获取defectCode文本框值、动态更改勾选框
            string temp = string.Join("", defectCode).Replace(",", "");
            textValue = string.Join(",", temp.Distinct()).Trim(',');
            if (null != codeBox)
            {
                codeBox.Text = textValue;
            }


            if (null != groupNode)
            {
                for (int j = 0; j < 25; j++)
                {
                    CheckBox ok = new CheckBox();
                    CheckBox ng = new CheckBox();
                    foreach (Control control in groupNode.Controls)
                    {
                        if (control is CheckBox)
                        {
                            if (control.Name.Split('_')[1].Equals((j + 1).ToString()))
                            {
                                if (control.Name.Split('_')[0].Equals("okBox"))
                                {
                                    ok = control as CheckBox;
                                }
                                else if (control.Name.Split('_')[0].Equals("ngBox"))
                                {
                                    ng = control as CheckBox;
                                }
                            }
                        }
                        if (control is ImageUpload.ImageUpload)
                        {
                            if (control.Name.Split('_')[1].Equals((j + 1).ToString()))
                            {
                                ImageUpload.ImageUpload img = control as ImageUpload.ImageUpload;
                                if (null != defectCode[j] && !defectCode[j].Equals(""))
                                {
                                    control.Enabled = true;
                                }
                                else
                                {
                                    control.Enabled = false;
                                }
                            }
                        }

                        if (null != defectCode[j] && !defectCode[j].Equals(""))
                        {
                            ng.Checked = true;
                            ok.Checked = false;
                        }
                        else
                        {
                            ok.Checked = true;
                            ng.Checked = false;
                        }
                    }
                }
            }
        }
        //通过MouseLeave关闭下拉框
        private void panel_MouseLeave(object sender, EventArgs e)
        {
            selectPanel.Controls.Clear();
        }
        //展示code
        public void showWaferPanel(string areaId, string code)
        {//单个方格显示
            try
            {
                int i = int.Parse(areaId);
                foreach (Control control in tableLayoutPanel1.Controls)
                {
                    if ((control is Panel) && control.Name.Split('_')[1].Equals(areaId))
                    {
                        if (null != defectCode[i - 1] && !defectCode[i - 1].Equals(""))
                        {
                            defectCode[i - 1] = defectCode[i - 1] + "," + code;
                        }
                        else
                        {
                            defectCode[i - 1] = code;
                        }

                        Panel p = control as Panel;
                        p.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
        //展示wafer
        public void showWafer(List<ISPWAFDFT> valueList)
        {//数据显示
            clearPanel();
            defectCode = new string[25];
            if (null != valueList && valueList.Count > 0)
            {

                foreach (var child in valueList)
                {
                    showWaferPanel(child.AreaId.ToString(), child.DefectCode);
                }
            }
            this.getDefectCodeValue();
        }
        #endregion

        #region Panel DoubleClick
        private void panelF_1_DoubleClick(object sender, EventArgs e)
        {
            selectPanel = panelF_1;
            this.panelDoubleClick(sender, e, panelF_1);

        }
        private void panelF_2_DoubleClick(object sender, EventArgs e)
        {
            selectPanel = panelF_2;
            this.panelDoubleClick(sender, e, panelF_2);

        }
        private void panelF_3_DoubleClick(object sender, EventArgs e)
        {
            selectPanel = panelF_3;
            this.panelDoubleClick(sender, e, panelF_3);

        }
        private void panelF_4_DoubleClick(object sender, EventArgs e)
        {
            selectPanel = panelF_4;
            this.panelDoubleClick(sender, e, panelF_4);

        }
        private void panelF_5_DoubleClick(object sender, EventArgs e)
        {
            selectPanel = panelF_5;
            this.panelDoubleClick(sender, e, panelF_5);

        }
        private void panelF_6_DoubleClick(object sender, EventArgs e)
        {
            selectPanel = panelF_6;
            this.panelDoubleClick(sender, e, panelF_6);

        }
        private void panelF_7_DoubleClick(object sender, EventArgs e)
        {
            selectPanel = panelF_7;
            this.panelDoubleClick(sender, e, panelF_7);

        }
        private void panelF_8_DoubleClick(object sender, EventArgs e)
        {
            selectPanel = panelF_8;
            this.panelDoubleClick(sender, e, panelF_8);

        }
        private void panelF_9_DoubleClick(object sender, EventArgs e)
        {
            selectPanel = panelF_9;
            this.panelDoubleClick(sender, e, panelF_9);

        }
        private void panelF_10_DoubleClick(object sender, EventArgs e)
        {
            selectPanel = panelF_10;
            this.panelDoubleClick(sender, e, panelF_10);

        }
        private void panelF_11_DoubleClick(object sender, EventArgs e)
        {
            selectPanel = panelF_11;
            this.panelDoubleClick(sender, e, panelF_11);

        }
        private void panelF_12_DoubleClick(object sender, EventArgs e)
        {
            selectPanel = panelF_12;
            this.panelDoubleClick(sender, e, panelF_12);

        }
        private void panelF_13_DoubleClick(object sender, EventArgs e)
        {
            selectPanel = panelF_13;
            this.panelDoubleClick(sender, e, panelF_13);

        }
        private void panelF_14_DoubleClick(object sender, EventArgs e)
        {
            selectPanel = panelF_14;
            this.panelDoubleClick(sender, e, panelF_14);

        }
        private void panelF_15_DoubleClick(object sender, EventArgs e)
        {
            selectPanel = panelF_15;
            this.panelDoubleClick(sender, e, panelF_15);

        }
        private void panelF_16_DoubleClick(object sender, EventArgs e)
        {
            selectPanel = panelF_16;
            this.panelDoubleClick(sender, e, panelF_16);

        }
        private void panelF_17_DoubleClick(object sender, EventArgs e)
        {
            selectPanel = panelF_17;
            this.panelDoubleClick(sender, e, panelF_17);

        }
        private void panelF_18_DoubleClick(object sender, EventArgs e)
        {
            selectPanel = panelF_18;
            this.panelDoubleClick(sender, e, panelF_18);

        }
        private void panelF_19_DoubleClick(object sender, EventArgs e)
        {
            selectPanel = panelF_19;
            this.panelDoubleClick(sender, e, panelF_19);

        }
        private void panelF_20_DoubleClick(object sender, EventArgs e)
        {
            selectPanel = panelF_20;
            this.panelDoubleClick(sender, e, panelF_20);

        }
        private void panelF_21_DoubleClick(object sender, EventArgs e)
        {
            selectPanel = panelF_21;
            this.panelDoubleClick(sender, e, panelF_21);

        }
        private void panelF_22_DoubleClick(object sender, EventArgs e)
        {
            selectPanel = panelF_22;
            this.panelDoubleClick(sender, e, panelF_22);

        }
        private void panelF_23_DoubleClick(object sender, EventArgs e)
        {
            selectPanel = panelF_23;
            this.panelDoubleClick(sender, e, panelF_23);

        }
        private void panelF_24_DoubleClick(object sender, EventArgs e)
        {
            selectPanel = panelF_24;
            this.panelDoubleClick(sender, e, panelF_24);
        }
        private void panelF_25_DoubleClick(object sender, EventArgs e)
        {
            selectPanel = panelF_25;
            this.panelDoubleClick(sender, e, panelF_25);

        }
        #endregion

        #region  Panel Paint
        private void panelF_1_Paint(object sender, PaintEventArgs e)
        {
            this.drawPanel(e, panelF_1);
        }

        private void panelF_2_Paint(object sender, PaintEventArgs e)
        {
            this.drawPanel(e, panelF_2);
        }

        private void panelF_3_Paint(object sender, PaintEventArgs e)
        {
            this.drawPanel(e, panelF_3);
        }

        private void panelF_4_Paint(object sender, PaintEventArgs e)
        {
            this.drawPanel(e, panelF_4);
        }

        private void panelF_5_Paint(object sender, PaintEventArgs e)
        {
            this.drawPanel(e, panelF_5);
        }

        private void panelF_6_Paint(object sender, PaintEventArgs e)
        {
            this.drawPanel(e, panelF_6);
        }

        private void panelF_7_Paint(object sender, PaintEventArgs e)
        {
            this.drawPanel(e, panelF_7);
        }

        private void panelF_8_Paint(object sender, PaintEventArgs e)
        {
            this.drawPanel(e, panelF_8);
        }

        private void panelF_9_Paint(object sender, PaintEventArgs e)
        {
            this.drawPanel(e, panelF_9);
        }

        private void panelF_10_Paint(object sender, PaintEventArgs e)
        {
            this.drawPanel(e, panelF_10);
        }

        private void panelF_11_Paint(object sender, PaintEventArgs e)
        {
            this.drawPanel(e, panelF_11);
        }

        private void panelF_12_Paint(object sender, PaintEventArgs e)
        {
            this.drawPanel(e, panelF_12);
        }

        private void panelF_13_Paint(object sender, PaintEventArgs e)
        {
            this.drawPanel(e, panelF_13);
        }

        private void panelF_14_Paint(object sender, PaintEventArgs e)
        {
            this.drawPanel(e, panelF_14);
        }

        private void panelF_15_Paint(object sender, PaintEventArgs e)
        {
            this.drawPanel(e, panelF_15);
        }

        private void panelF_16_Paint(object sender, PaintEventArgs e)
        {
            this.drawPanel(e, panelF_16);
        }

        private void panelF_17_Paint(object sender, PaintEventArgs e)
        {
            this.drawPanel(e, panelF_17);
        }

        private void panelF_18_Paint(object sender, PaintEventArgs e)
        {
            this.drawPanel(e, panelF_18);
        }

        private void panelF_19_Paint(object sender, PaintEventArgs e)
        {
            this.drawPanel(e, panelF_19);
        }

        private void panelF_20_Paint(object sender, PaintEventArgs e)
        {
            this.drawPanel(e, panelF_20);
        }

        private void panelF_21_Paint(object sender, PaintEventArgs e)
        {
            this.drawPanel(e, panelF_21);
        }

        private void panelF_22_Paint(object sender, PaintEventArgs e)
        {
            this.drawPanel(e, panelF_22);
        }

        private void panelF_23_Paint(object sender, PaintEventArgs e)
        {
            this.drawPanel(e, panelF_23);
        }

        private void panelF_24_Paint(object sender, PaintEventArgs e)
        {
            this.drawPanel(e, panelF_24);
        }

        private void panelF_25_Paint(object sender, PaintEventArgs e)
        {
            this.drawPanel(e, panelF_25);
        }





        #endregion


    }
}
