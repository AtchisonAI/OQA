using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferPic;

namespace pic_up
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


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
                        txtPicName.Text = fileName;//在textBox中显示文件名
                        pictureBox1.Load(fileName);//使该图片在客户端pictuBox中显示
                    }
                    else
                    {
                        MessageBox.Show("请选择正确的图片格式！");
                    }

                }
                else
                    return;//未选中文件则返回；
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            //pictureBox1.Load(fileName);
            //读取流，上传文件流到服务器
            FileStream fs = new FileStream(txtPicName.Text, FileMode.Open, FileAccess.Read);//创建一个文件，并把文件放在文件流里边；
            Stream sm = new MemoryStream();//创建一个滤层流 将文件从第0位拷贝到sm中
            fs.Position = 0;//获取或设置此流的当前位置
            fs.CopyTo(sm);
            //拷贝完成之后进行上传
            EndpointAddress epAddr = new EndpointAddress("net.tcp://localhost:9600/transferPic");//此处也可以用IIS做服务
            NetTcpBinding bind = new NetTcpBinding();//绑定方式
            bind.MaxBufferPoolSize = 2147483647;//最大缓冲
            bind.TransferMode = TransferMode.Streamed;//传输模式为流式处理
            bind.MaxReceivedMessageSize = 2147483647;//定义了服务端接收Message的最大长度，防止文件过大
            bind.Security.Mode = SecurityMode.None;//安全模式设置为不进行验证；
            //创建一个工厂
            ITransferPicService proxy = ChannelFactory<ITransferPicService>.CreateChannel(bind, epAddr);
            sm.Position = 0;
            string picpath = proxy.SendPic(sm);//WCF客户端调用该方法 把客户端sm上传到服务端去
        }
        Random random = new Random();
        public int[] ballNumber = new int[13];
        public bool sign = false;

        public void shuangSeQiu()
        {
            for (int i = 0; i < 13; i++)
            {
                sign = false;
               // Console.WriteLine("the current count number is " + i);
                int randomNumber = random.Next(1, 26);
               // Console.WriteLine("output: " + randomNumber);
                if (i == 0)
                {
                    ballNumber[0] = randomNumber;
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (randomNumber == ballNumber[j])
                        {
                            sign = true;
                            i--;
                            break;
                        }
                    }
                    if (!sign)
                    {
                        ballNumber[i] = randomNumber;
                    }
                }
            }
            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine(ballNumber[i]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            shuangSeQiu();
        }
    }
}
