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
        private bool b_Upload = true;
        private ISPIMGDEF item;
        #endregion

        public ImageUpload()
        {
            InitializeComponent();
        }
        [DefaultValue(" "), Description("By Lot上传(2个属性必输)：重新上传需要TranSeq和ImageId"), Category("自定义属性")]
        public ByLot UpLoadByLot{get;set;} 
        [Serializable()]
        public class ByLot
        {
            public string LotID { get; set; }
            public string ImageType { get; set; }
            public decimal TranSeq { get; set; }
            public string ImageId { get; set; }
        }

        [DefaultValue(" "), Description("By wafer上传(4个属性必输)：重新上传需要TranSeq和ImageId"), Category("自定义属性")]//属性窗口中的相关说明
        public ByWafer UpLoadByWafer{ get; set;} 

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
        public BySide UpLoadBySide{get;set;} 

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
        public ByArea UpLoadByArea{   get;set;} 

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
            ModelRsp<ImageSave> in_node = new ModelRsp<ImageSave>();
            ImageSave in_data = new ImageSave();
            char cTranFlag;

            if (b_Upload)
            {
                try
                {
                    if (btnUploadClicked != null)
                        btnUploadClicked(sender, new EventArgs());//把按钮自身作为参数传递

                    item = new ISPIMGDEF();

                    switch (UpLoadFlag)
                    {
                        //UpLoad By Lot
                        case 1:
                            if (!string.IsNullOrWhiteSpace(UpLoadByLot.LotID) && !string.IsNullOrWhiteSpace(UpLoadByLot.ImageType))
                            {
                                if (UpLoadByLot.ImageId != null)
                                {
                                    cTranFlag = GlobConst.TRAN_UPDATE;
                                    in_data.C_PROC_STEP = cTranFlag;
                                    in_data.C_TRAN_FLAG = '1';

                                    item.ImageId = UpLoadByLot.ImageId;
                                    item.TransSeq = UpLoadByLot.TranSeq;
                                }
                                else
                                {
                                    cTranFlag = GlobConst.TRAN_CREATE;
                                    in_data.C_PROC_STEP = cTranFlag;
                                    in_data.C_TRAN_FLAG = '1';
                                }
                                item.LotId = UpLoadByLot.LotID;
                                item.ImageType = UpLoadByLot.ImageType;
                                in_data.IspImgeDef = item;
                            }
                            else
                            {
                                MessageBox.Show("请检查UpLoadByLot属性LotID与ImageType是否赋值");
                                return;
                            }
                            break;
                        //UpLoad By wafer
                        case 2:
                            if (!string.IsNullOrWhiteSpace(UpLoadByWafer.LotID) && !string.IsNullOrWhiteSpace(UpLoadByWafer.Slot_ID) && !string.IsNullOrWhiteSpace(UpLoadByWafer.Wafer_ID)
                                && !string.IsNullOrWhiteSpace(UpLoadByWafer.ImageType))
                            {
                                if (UpLoadByWafer.ImageId != null)
                                {
                                    cTranFlag = GlobConst.TRAN_UPDATE;
                                    in_data.C_PROC_STEP = cTranFlag;
                                    in_data.C_TRAN_FLAG = '1';

                                    item.ImageId = UpLoadByWafer.ImageId;
                                    item.TransSeq = UpLoadByWafer.TranSeq;
                                }
                                else
                                {
                                    cTranFlag = GlobConst.TRAN_CREATE;
                                    in_data.C_PROC_STEP = cTranFlag;
                                    in_data.C_TRAN_FLAG = '1';

                                }

                                item.LotId = UpLoadByWafer.LotID;
                                item.SlotId = UpLoadByWafer.Slot_ID;
                                item.WaferId = UpLoadByWafer.Wafer_ID;
                                item.ImageType = UpLoadByWafer.ImageType;
                                in_data.IspImgeDef = item;
                            }
                            else
                            {
                                MessageBox.Show("请检查UpLoadByWafer属性LotID,slotID,waferID与ImageType是否赋值");
                                return;
                            }

                            break;

                        case 3:
                            if (!string.IsNullOrWhiteSpace(UpLoadBySide.LotID)&& !string.IsNullOrWhiteSpace(UpLoadBySide.Slot_ID) && !string.IsNullOrWhiteSpace(UpLoadBySide.Wafer_ID)
                                && !string.IsNullOrWhiteSpace(UpLoadBySide.Inspect_Type) && !string.IsNullOrWhiteSpace(UpLoadBySide.Side_Type) && !string.IsNullOrWhiteSpace(UpLoadBySide.ImageType))
                            {
                                if (UpLoadBySide.ImageId != null)
                                {
                                    cTranFlag = GlobConst.TRAN_UPDATE;
                                    in_data.C_PROC_STEP = cTranFlag;
                                    in_data.C_TRAN_FLAG = '1';

                                    item.ImageId = UpLoadBySide.ImageId;
                                    item.TransSeq = UpLoadBySide.TranSeq;
                                }
                                else
                                {
                                    cTranFlag = GlobConst.TRAN_CREATE;
                                    in_data.C_PROC_STEP = cTranFlag;
                                    in_data.C_TRAN_FLAG = '1';

                                }
                                item.LotId = UpLoadBySide.LotID;
                                item.SlotId = UpLoadBySide.Slot_ID;
                                item.WaferId = UpLoadBySide.Wafer_ID;
                                item.InspectType = UpLoadBySide.Inspect_Type;
                                item.SideType = UpLoadBySide.Side_Type;
                                item.ImageType = UpLoadBySide.ImageType;
                                in_data.IspImgeDef = item;
                            }
                            else
                            {
                                MessageBox.Show("请检查UpLoadBySide属性LotID,slotID,waferID,InspectType,SideType与ImageType是否赋值");
                                return;
                            }

                            break;

                        case 4:
                            if (!string.IsNullOrWhiteSpace(UpLoadByArea.LotID) && !string.IsNullOrWhiteSpace(UpLoadByArea.Slot_ID) && !string.IsNullOrWhiteSpace(UpLoadByArea.Wafer_ID)
                                && !string.IsNullOrWhiteSpace(UpLoadByArea.Inspect_Type) && !string.IsNullOrWhiteSpace(UpLoadByArea.Side_Type) && UpLoadByArea.Area_ID != 0 &&
                                !string.IsNullOrWhiteSpace(UpLoadByArea.ImageType))
                            {
                                if (UpLoadByArea.ImageId != null)
                                {
                                    cTranFlag = GlobConst.TRAN_UPDATE;
                                    in_data.C_PROC_STEP = cTranFlag;
                                    in_data.C_TRAN_FLAG = '1';

                                    item.ImageId = UpLoadByArea.ImageId;
                                    item.TransSeq = UpLoadByArea.TranSeq;
                                }
                                else
                                {
                                    cTranFlag = GlobConst.TRAN_CREATE;
                                    in_data.C_PROC_STEP = cTranFlag;
                                    in_data.C_TRAN_FLAG = '1';

                                }
                                item.LotId = UpLoadByArea.LotID;
                                item.SlotId = UpLoadByArea.Slot_ID;
                                item.WaferId = UpLoadByArea.Wafer_ID;
                                item.InspectType = UpLoadByArea.Inspect_Type;
                                item.SideType = UpLoadByArea.Side_Type;
                                item.AreaId = UpLoadByArea.Area_ID;
                                item.ImageType = UpLoadByArea.ImageType;
                                in_data.IspImgeDef = item;
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
                        lblSts.Text = "预览";
                        btnBrowser.Enabled = false;
                        btnUpload.Text = "Delete";
                        b_Upload = false;
                        item = out_data.model.IspImgeDef;
                        //btnUpload.Enabled = false;
                        //MessageBox.Show(out_data._MsgCode);
                    }
                    else
                    {
                        btnUpload.Enabled = true;
                        MessageBox.Show(out_data._ErrorMsg);

                    }
                }
                catch (Exception ex)
                {
                    btnUpload.Enabled = true;
                    MessageBox.Show(ex.Message);
                    return;
                }
            } else
            {
                try
                {
                    cTranFlag = GlobConst.TRAN_DELETE;
                    in_data.C_PROC_STEP = cTranFlag;
                    in_data.C_TRAN_FLAG = '1';
                    in_data.IspImgeDef = item;
                    in_node.model = in_data;
                    var out_data = OQASrv.Call.SaveImageInfo(in_node);
                    if (out_data._success == true)
                    {
                        RefreshContrl();

                        //btnUpload.Enabled = false;
                        //MessageBox.Show(out_data._MsgCode);
                    }
                    else
                    {
                        btnUpload.Enabled = false;
                        MessageBox.Show(out_data._ErrorMsg);
                    }
                } catch (Exception ex)
                {
                    btnUpload.Enabled = false;
                    MessageBox.Show(ex.Message);
                    return;
                }
                //delete

            }
        }

        public void UploadBylot(string lotId,string type)
        {
            UpLoadByLot = new ByLot();
            UpLoadByLot.LotID = lotId;
            UpLoadByLot.ImageType = type;
            UpLoadFlag = OQA_Core.UpLoadFlag.ByLot;
        }

        public void InitByImgInstance(ISPIMGDEF instance)
        {
            item = instance;
            lblSts.Text = "预览";
            btnBrowser.Enabled = false;
            btnUpload.Text = "Delete";
            btnUpload.Enabled = true;
            b_Upload = false;
            
            txtPicName.Text = instance.ImagePath;
        }

        public void RefreshContrl ()
        {
            lblSts.Text = "未传";
            btnBrowser.Enabled = true;
            btnUpload.Text = "Save";
            btnUpload.Enabled = false;
            b_Upload = true;
            txtPicName.Text = string.Empty;
        }

        public string GetImagePath()
        {
            return null == item ? null : item.ImagePath;
        }


        //定义委托
        public delegate void    PreViewClickHandle(object sender, EventArgs e);
        //定义事件
        public event PreViewClickHandle PreviewLableClicked;
        private void lblSts_Click(object sender, EventArgs e)
        {
            if (null != PreviewLableClicked && lblSts.Text.Equals("预览"))
                PreviewLableClicked(sender, e);
        }
    }
}
