using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace OQA_Core
{
    #region " 通用方法 "   
    /// <summary>
    /// 通用方法.
    /// </summary>
    public class ComFunc
    {

        /// <summary>

        /// 将图片数据转换为Base64字符串

        /// </summary>

        /// <param name="sender"></param>

        /// <param name="e"></param>
        public static  string ImageToBase64(MemoryStream img)

        {

            byte[] bytes = img.GetBuffer();

            string base64 = Convert.ToBase64String(bytes);

            return base64;

        }


        /// <summary>
        /// 初始化控件.
        /// </summary>
        /// <param name="ctrl">控件及控件集合</param>
        /// <param name="ExceptCtl1">例外控件</param>
        /// <returns>True or False</returns>
        public static bool FieldClear(object ctrl)
        {
            return FieldClear(ctrl, null, null, null, null, null, false);
        }
        public static bool FieldClear(object ctrl, bool bItemsClear)
        {
            return FieldClear(ctrl, null, null, null, null, null, bItemsClear);
        }
        public static bool FieldClear(object ctrl, object ExceptCtl1)
        {
            return FieldClear(ctrl, ExceptCtl1, null, null, null, null, false);
        }

        public static bool CheckValue(string v1, int v2)
        {
            throw new NotImplementedException();
        }

        public static bool FieldClear(object ctrl, object ExceptCtl1, bool bItemsClear)
        {
            return FieldClear(ctrl, ExceptCtl1, null, null, null, null, bItemsClear);
        }
        public static bool FieldClear(object ctrl, object ExceptCtl1, object ExceptCtl2)
        {
            return FieldClear(ctrl, ExceptCtl1, ExceptCtl2, null, null, null, false);
        }
        public static bool FieldClear(object ctrl, object ExceptCtl1, object ExceptCtl2, object ExceptCtl3)
        {
            return FieldClear(ctrl, ExceptCtl1, ExceptCtl2, ExceptCtl3, null, null, false);
        }
        public static bool FieldClear(object ctrl, object ExceptCtl1, object ExceptCtl2, object ExceptCtl3, object ExceptCtl4)
        {
            return FieldClear(ctrl, ExceptCtl1, ExceptCtl2, ExceptCtl3, ExceptCtl4, null, false);
        }
        public static bool FieldClear(object ctrl, object ExceptCtl1, object ExceptCtl2, object ExceptCtl3, object ExceptCtl4, object ExceptCtl5, bool bItemsClear)
        {
            object control;
            int i;
            bool b_except;

            control = null;

            System.Windows.Forms.Control f = (System.Windows.Forms.Control)ctrl;

            for (i = 0; i < f.Controls.Count; i++)
            {
                b_except = false;

                control = f.Controls[i];

                if (ExceptCtl1 != null)
                {
                    if (ExceptCtl1 == control)
                    {
                        b_except = true;
                    }
                    else
                    {
                        b_except = false;
                    }
                }
                if (b_except == false && ExceptCtl2 != null)
                {
                    if (ExceptCtl2 == control)
                    {
                        b_except = true;
                    }
                    else
                    {
                        b_except = false;
                    }
                }
                if (b_except == false && ExceptCtl3 != null)
                {
                    if (ExceptCtl3 == control)
                    {
                        b_except = true;
                    }
                    else
                    {
                        b_except = false;
                    }
                }

                if (b_except == false && ExceptCtl4 != null)
                {
                    if (ExceptCtl4 == control)
                    {
                        b_except = true;
                    }
                    else
                    {
                        b_except = false;
                    }
                }

                if (b_except == false && ExceptCtl5 != null)
                {
                    if (ExceptCtl5 == control)
                    {
                        b_except = true;
                    }
                    else
                    {
                        b_except = false;
                    }
                }

                if (b_except == true)
                {
                    continue;
                }

                if (control is Panel || control is System.Windows.Forms.GroupBox || control is TabControl || control is TabPage)
                {
                    FieldClear(control, ExceptCtl1, ExceptCtl2, ExceptCtl3, ExceptCtl4, ExceptCtl5, false);
                }
                else
                {
                    if (control is System.Windows.Forms.TextBox)
                    {
                        ((System.Windows.Forms.TextBox)control).Text = "";
                    }
                    else if (control is System.Windows.Forms.CheckBox)
                    {
                        ((System.Windows.Forms.CheckBox)control).Checked = false;
                    }
                    else if (control is ComboBox)
                    {
                        ((ComboBox)control).SelectedIndex = -1;
                        if (bItemsClear == true)
                        {
                            ((ComboBox)control).Items.Clear();
                        }
                    }
                    else if (control is RadioButton)
                    {
                        ((RadioButton)control).Checked = false;
                    }
                    else if (control is NumericUpDown)
                    {
                        try
                        {
                            ((NumericUpDown)control).Value = 0;
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            //MPCF.ShowMsgBox(argEx.Message);
                            ((NumericUpDown)control).Value = ((NumericUpDown)control).Minimum;
                        }
                    }
                }
            }

            return true;
        }


        public static void ClearList(Control ListControl)
        {
            ClearList(ListControl, false);
        }

        // ClearList()
        //       - Clear List Control
        // Return Value
        //       -
        // Arguments
        //       - ByVal ListControl As Control
        //
        public static void ClearList(Control ListControl, bool ComboBoxSpaceAddFlag)
        {
            if (ListControl == null) return;

            if (ListControl is ListView)
            {
                if (((ListView)ListControl).Items.Count == 0) return;
                ((ListView)ListControl).Items.Clear();
            }
            else if (ListControl is ComboBox)
            {
                if (((ComboBox)ListControl).Items.Count == 0) return;
                ((ComboBox)ListControl).Items.Clear();
                if (ComboBoxSpaceAddFlag == true)
                {
                    ((ComboBox)ListControl).Items.Add("");
                }
            }
            else if (ListControl is TreeView)
            {
                if (((TreeView)ListControl).Nodes.Count == 0) return;
                ((TreeView)ListControl).Nodes.Clear();
            }

        }
        //public static System.Windows.Forms.DialogResult ShowMsgBox(string S)
        //{
        //    MessageBox.Show("请选择正确的图片格式！");
        //    return ShowMsgBox(S,MPGV.gfrmMDI, Application.ProductName, MessageBoxButtons.OK, 1);
        //}
        /// <summary>
        /// trim方法.
        /// </summary>
        public static string Trim(object str)
        {
            try
            {
                if (str == null)
                    return "";


                if (str is System.Windows.Forms.Form)
                {
                    System.Windows.Forms.Form f = (System.Windows.Forms.Form)str;

                    MessageBox.Show(f.Name + " Trim失败.");

                    if (f.Tag == null)
                    {
                        return "";
                    }
                    else
                    {
                        return f.Tag.ToString().Trim();
                    }
                }
                else
                {
                    string sTemp = Convert.ToString(str);

                    if (string.IsNullOrEmpty(sTemp) == true)
                    {
                        return "";
                    }
                    else
                    {
                        return sTemp.Trim();
                    }
                }
            }
            catch (Exception Ex)
            {
                Debug.Print(Ex.Message + " Trim");
                return "";
            }
        }

        public static bool CheckNumeric(object val)
        {
            double result;
            object obj;

            try
            {
                if (val == null) return false;

                if (val is Char)
                {
                    obj = Convert.ToString(val);
                }
                else
                {
                    obj = val;
                }

                result = Convert.ToDouble(obj);
                return true;
            }

            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 检查控件输入是否合法.
        /// </summary>
        /// <param name="ctrl">控件</param>
        /// <param name="Step">1 : Check Space 2 : Check Number 3 : Check Integral Number</param>
        /// <returns>True or False</returns>
        public static bool CheckValue(Control Form_control, int _Step)
        {
            bool b_valid_flag;
            b_valid_flag = false;

            if ((Form_control is System.Windows.Forms.TextBox) || (Form_control is System.Windows.Forms.Label))
            {
                if (_Step == 1)
                {
                    if (Trim(Form_control.Text) != "")
                    {
                        b_valid_flag = true;
                    }
                }
                else if (_Step == 2)
                {
                    if (CheckNumeric(Form_control.Text) == true)
                    {
                        b_valid_flag = true;
                    }
                }
                else if (_Step == 3)
                {
                    if (CheckNumeric(Form_control.Text) == true)
                    {
                        if (Form_control.Text.Contains(".") == false)
                        {
                            b_valid_flag = true;
                        }
                    }
                }
            }
            else if (Form_control is ComboBox)
            {
                if (_Step == 1)
                {
                    if (Trim(Form_control.Text) != "")
                    {
                        b_valid_flag = true;
                    }
                }
                else if (_Step == 2)
                {
                    if (CheckNumeric(Form_control.Text) == true)
                    {
                        b_valid_flag = true;
                    }
                }
                else if (_Step == 3)
                {
                    if (CheckNumeric(Form_control.Text) == true)
                    {
                        if (Form_control.Text.IndexOf(".") < 0)
                        {
                            b_valid_flag = true;
                        }
                    }
                }
            }
            return b_valid_flag;
        }


        public static void InitListView(ListView MyListView,bool GridLines)
        {
            MyListView.Items.Clear();
            MyListView.View = System.Windows.Forms.View.Details;
            MyListView.FullRowSelect = true;
            MyListView.HideSelection = false;
            MyListView.GridLines = GridLines;
            //if (MPGV.gIMdiForm != null && MPGV.gIMdiForm.GetSmallIconList() != null)
            //{
            //    if (MyListView.SmallImageList == null)
            //    {
            //        MyListView.SmallImageList = MPGV.gIMdiForm.GetSmallIconList();
            //        MyListView.SmallImageList.Tag = "LOADED";
            //    }
            //    else if (MPCF.Trim(MyListView.SmallImageList.Tag) != "LOADED")
            //    {
            //        MyListView.SmallImageList = MPGV.gIMdiForm.GetSmallIconList();
            //        MyListView.SmallImageList.Tag = "LOADED";
            //    }
            //}
            //else
            //{
            //    MyListView.SmallImageList = null;
            //}
        }

        public static void ClearBoxValue(Control parentCon)
        {
            foreach (Control control in parentCon.Controls)
            {
                if (control is TextBox || control is RichTextBox)
                {
                    control.Text = "";
                }
            }
        }

        //文本框输入控制
        public static void CheckKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))//除退格以外的非数字输入
            {//如果不是输入数字就不让输入
                e.Handled = true;
            }
        }

        //判断是否为tab键
        public static bool CheckTabKey(KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
            return e.KeyChar == (char)9 ? true:false;
        }

        //判断是否为Enter键
        public static bool CheckEnterKey(KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
            return e.KeyChar == (char)13 ? true : false;
        }
    }
    #endregion



  
}
