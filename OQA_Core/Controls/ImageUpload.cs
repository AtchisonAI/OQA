using System;
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
using System.IO;
using OQA_Core;
using WCFModels.Message;

namespace ImageUpload
{
    public partial class ImageUpload : UserControl
    {



        #region "Variable Definition "
        Regex regExp = new Regex(@"^[A-Za-z]+(,[A-Za-z])*$");//可能带逗号的字符串
        public Panel selectPanel;//当前操作的panel
        public string[] defectCode = new string[25];
        public string textValue = "";
        public System.Windows.Forms.TextBox box;
        public System.Windows.Forms.GroupBox groupNode;
        #endregion

        public ImageUpload()
        {
            InitializeComponent();
        }
        [DefaultValue(" "), Description("By Lot上传(2个属性必输)：重新上传需要TranSeq和ImageId"), Category("自定义属性")]
        public List<ByLot> UpLoadByLot
        {
            get;
        } = new List<ByLot>();
        [Serializable()]
        public class ByLot
        {
            public string LotID { get; set; }
            public string ImageType { get; set; }
            public decimal TranSeq { get; set; }
            public string ImageId { get; set; }
        }

        [DefaultValue(" "), Description("By wafer上传(4个属性必输)：重新上传需要TranSeq和ImageId"), Category("自定义属性")]//属性窗口中的相关说明
        public List<ByWafer> UpLoadByWafer
        {
            get;
        } = new List<ByWafer>();

        [Serializable()]
        public class ByWafer
        {
            public string LotID { get; set; }
            public string Slot_ID { get; set; }
            public string Wafer_ID { get; set; }
            public string ImageType { get; set; }
            public decimal TranSeq { get; set; }
            public string ImageId { get; set; }
        }


        [DefaultValue(" "), Description("By Side上传(6个属性必输)：重新上传需要TranSeq和ImageId"), Category("自定义属性")]//属性窗口中的相关说明
        public List<BySide> UpLoadBySide
        {
            get;
        } = new List<BySide>();

        [Serializable()]
        public class BySide
        {
            public string LotID { get; set; }
            public string Slot_ID { get; set; }
            public string Wafer_ID { get; set; }
            public string Inspect_Type { get; set; }
            public string Side_Type { get; set; }
            public string ImageType { get; set; }
            public decimal TranSeq { get; set; }
            public string ImageId { get; set; }
        }

        [DefaultValue(" "), Description("By Area上传(7个属性必输)：重新上传需要TranSeq和ImageId"), Category("自定义属性")]//属性窗口中的相关说明
        public List<ByArea> UpLoadByArea
        {
            get;
        } = new List<ByArea>();

        [Serializable()]
        public class ByArea
        {
            public string LotID { get; set; }
            public string Slot_ID { get; set; }
            public string Wafer_ID { get; set; }
            public string Inspect_Type { get; set; }
            public string Side_Type { get; set; }
            public decimal Area_ID { get; set; }
            public string ImageType { get; set; }
            public decimal TranSeq { get; set; }
            public string ImageId { get; set; }
        }

        #region "定义上传图片属性"
        /// <summary>
        /// 定义上传图片所属级别
        /// </summary>
        [DefaultValue(0), Description("上传图片所属级别:1 by lot;2 by wafer;3 by side;4 by point"), Category("自定义属性")]//属性窗口中的相关说明
        public int UpLoadFlag
        {
            get { return uploadflag; }
            set { uploadflag = value; }
        }

        private int uploadflag;
        /// <summary>
        /// 定义上传参数
        /// </summary>
 


        #endregion
        /// <summary>
        /// 选中的图片文件流
        /// </summary>
        [DefaultValue(" "), Description("选中的图片文件流"), Category("自定义属性")]//属性窗口中的相关说明
        public MemoryStream PicStream
        {
            get { return picstream; }
            set { picstream = value; }
        }

        private MemoryStream picstream;

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = "";//定义一个字段用于获取上传的文件名；
                OpenFileDialog openFileDialog = new OpenFileDialog();//创建一个OpenFileDialog对象专门用于打开文件
                openFileDialog.Filter = ".jpeg|*.jpg;*.jpeg;*.png;*.gif;*.png";//*.jpg;*.jpeg;*.png;*.gif
                if (openFileDialog.ShowDialog() == DialogResult.OK)//打开的文件对话框如果选择了OK按钮（确定），则为真，执行大括号中的内容
                {
                    fileName = openFileDialog.FileName;
                    string fileEx = fileName.Substring(fileName.LastIndexOf(".") + 1);//从.开始截至最后得到图片格式
                    if (fileEx == "jpg" || fileEx == "jpeg" || fileEx == "bmp" || fileEx == "gif" || fileEx == "png")
                    {
                        btnUpload.Enabled = true;
                        txtPicName.Text = fileName;//在textBox中显示文件名
                       // pictureBox1.Load(fileName);//使该图片在客户端pictuBox中显示
                    }
                    else
                    {
                        btnUpload.Enabled = false;
                        MessageBox.Show("请选择正确的图片格式！");
                    }

                }
                else
                    return;//未选中文件则返回；
            }
            catch (Exception ex)
            {
                btnUpload.Enabled = false;
                MessageBox.Show(ex.Message.ToString());
            }
        }


        //定义委托
        public delegate void BtnClickHandle(object sender, EventArgs e);
        //定义事件
        public event BtnClickHandle btnUploadClicked;
        public void btnUpload_Click(object sender, EventArgs e)
        {
            
            if (btnUploadClicked != null)
                btnUploadClicked(sender, new EventArgs());//把按钮自身作为参数传递

            char cTranFlag;
            ModelRsp<ImageSave> in_node = new ModelRsp<ImageSave>();
            ImageSave in_data = new ImageSave();
            ISPIMGDEF item = new ISPIMGDEF();

            switch (UpLoadFlag)
            {
                //UpLoad By Lot
                case 1:
                if (UpLoadByLot[0].LotID != null && UpLoadByLot[0].ImageType != null)
                {
                        if (UpLoadByLot[0].ImageId != null)
                        {
                            cTranFlag = GlobConst.TRAN_UPDATE;
                            in_data.C_PROC_STEP = cTranFlag;
                            in_data.C_TRAN_FLAG = '1';

                            item.ImageId = UpLoadByLot[0].ImageId;
                            item.TransSeq = UpLoadByLot[0].TranSeq;
                        }
                        else
                        {
                            cTranFlag = GlobConst.TRAN_CREATE;
                            in_data.C_PROC_STEP = cTranFlag;
                            in_data.C_TRAN_FLAG = '1';
                        }
                        item.LotId = UpLoadByLot[0].LotID;
                        item.ImageType = UpLoadByLot[0].ImageType;
                        in_data.ISPIMGDEF_List.Add(item);
                    }
                else
                {
                    MessageBox.Show("请检查UpLoadByLot属性LotID与ImageType是否赋值");
                    return;
                }
                break;
                //UpLoad By wafer
                case 2:
                    if (UpLoadByWafer[0].LotID != null && UpLoadByWafer[0].Slot_ID != null && UpLoadByWafer[0].Wafer_ID != null && UpLoadByWafer[0].ImageType != null)
                    {
                        if (UpLoadByWafer[0].ImageId != null)
                        {
                            cTranFlag = GlobConst.TRAN_UPDATE;
                            in_data.C_PROC_STEP = cTranFlag;
                            in_data.C_TRAN_FLAG = '1';

                            item.ImageId = UpLoadByWafer[0].ImageId;
                            item.TransSeq = UpLoadByWafer[0].TranSeq;
                        }
                        else
                        {
                            cTranFlag = GlobConst.TRAN_CREATE;
                            in_data.C_PROC_STEP = cTranFlag;
                            in_data.C_TRAN_FLAG = '1';

                        }

                        item.LotId = UpLoadByWafer[0].LotID;
                        item.SlotId = UpLoadByWafer[0].Slot_ID;
                        item.WaferId = UpLoadByWafer[0].Wafer_ID;
                        item.ImageType = UpLoadByWafer[0].ImageType;
                        in_data.ISPIMGDEF_List.Add(item);
                    }
                    else
                    {
                        MessageBox.Show("请检查UpLoadByWafer属性LotID,slotID,waferID与ImageType是否赋值");
                        return;
                    }

                    break;

                case 3:
                    if (UpLoadBySide[0].LotID != null && UpLoadBySide[0].Slot_ID != null && UpLoadBySide[0].Wafer_ID != null && UpLoadBySide[0].Inspect_Type != null && UpLoadBySide[0].Side_Type != null && UpLoadBySide[0].ImageType != null)
                    {
                        if (UpLoadBySide[0].ImageId != null)
                        {
                            cTranFlag = GlobConst.TRAN_UPDATE;
                            in_data.C_PROC_STEP = cTranFlag;
                            in_data.C_TRAN_FLAG = '1';

                            item.ImageId = UpLoadBySide[0].ImageId;
                            item.TransSeq = UpLoadBySide[0].TranSeq;
                        }
                        else
                        {
                            cTranFlag = GlobConst.TRAN_CREATE;
                            in_data.C_PROC_STEP = cTranFlag;
                            in_data.C_TRAN_FLAG = '1';

                        }
                        item.LotId = UpLoadBySide[0].LotID;
                        item.SlotId = UpLoadBySide[0].Slot_ID;
                        item.WaferId = UpLoadBySide[0].Wafer_ID;
                        item.InspectType = UpLoadBySide[0].Inspect_Type;
                        item.SideType = UpLoadBySide[0].Side_Type;
                        item.ImageType = UpLoadBySide[0].ImageType;
                        in_data.ISPIMGDEF_List.Add(item);
                    }
                    else
                    {
                        MessageBox.Show("请检查UpLoadBySide属性LotID,slotID,waferID,InspectType,SideType与ImageType是否赋值");
                        return;
                    }

                    break;

                case 4:
                    if (UpLoadByArea[0].LotID != null && UpLoadByArea[0].Slot_ID != null && UpLoadByArea[0].Wafer_ID != null && UpLoadByArea[0].Inspect_Type != null && UpLoadByArea[0].Side_Type != null && UpLoadByArea[0].Area_ID != 0 && UpLoadByArea[0].ImageType != null)
                    {
                        if (UpLoadByArea[0].ImageId != null)
                        {
                            cTranFlag = GlobConst.TRAN_UPDATE;
                            in_data.C_PROC_STEP = cTranFlag;
                            in_data.C_TRAN_FLAG = '1';

                            item.ImageId = UpLoadByArea[0].ImageId;
                            item.TransSeq = UpLoadByArea[0].TranSeq;
                        }
                        else
                        {
                            cTranFlag = GlobConst.TRAN_CREATE;
                            in_data.C_PROC_STEP = cTranFlag;
                            in_data.C_TRAN_FLAG = '1';

                        }
                        item.LotId = UpLoadByArea[0].LotID;
                        item.SlotId = UpLoadByArea[0].Slot_ID;
                        item.WaferId = UpLoadByArea[0].Wafer_ID;
                        item.InspectType = UpLoadByArea[0].Inspect_Type;
                        item.SideType = UpLoadByArea[0].Side_Type;
                        item.AreaId = UpLoadByArea[0].Area_ID;
                        item.ImageType = UpLoadBySide[0].ImageType;
                        in_data.ISPIMGDEF_List.Add(item);
                    }
                    else
                    {
                        MessageBox.Show("请检查UpLoadByArea属性LotID,slotID,waferID,InspectType,SideType,Area_ID与ImageType是否赋值");
                        return;
                    }

                    break;
            }

            //上传图片
            FileStream fs = new FileStream(txtPicName.Text, FileMode.Open, FileAccess.Read);
            MemoryStream sm = new MemoryStream();
            fs.Position = 0;
            fs.CopyTo(sm);
            sm.Position = 0;

            string ImageBase64 = ComFunc.ImageToBase64(sm);

            in_data.PicStreamBase64 = ImageBase64;
            in_node.model = in_data;

            var out_data = OQASrv.Call.SaveImageInfo(in_node);
            if (out_data._success == true)
            {
                lblSts.Text = "已传";
                //MessageBox.Show(out_data._MsgCode);
                
            }
            else
            {
                MessageBox.Show(out_data._ErrorMsg);
                
            }


        }





    }
}
