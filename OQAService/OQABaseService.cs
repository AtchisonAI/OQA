using WcfService;

using System;
using System.IO;
using System.Drawing;
using System.ComponentModel;
using System.Runtime.Serialization.Formatters.Binary;
using System.Reflection;
using WCFModels.OQA;
using WCFModels.Message;

namespace OQAService.Services
{
    public class OQABaseService : BaseService
    {


        public OQABaseService() : base("OQADB")
        {

        }

        //public IDatabase db;

        //private IDatabase GetDb()
        //{
        //    return db;
        //}
       // private int[] ballNumber = new int[13];
        public int[] ChooseIspWafer(int chooseCount,int RowCount)
        {
            int[] ballNumber = new int[chooseCount];
            try
            {                
                Random random = new Random();
                bool sign = false;

                for (int i = 0; i < chooseCount; i++)
                {
                    sign = false;
                    // Console.WriteLine("the current count number is " + i);
                    int randomNumber = random.Next(1, RowCount);
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

                return ballNumber;
                 
            }
            catch (Exception ex)
            {
                return ballNumber;
            }

        }
            public static void InitTable( object sorcue)
        {
            FieldInfo[] sourceFieldInfo = sorcue.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (FieldInfo sourceFiled in sourceFieldInfo)
            {
                var value = sourceFiled.GetValue(sorcue);

                if (sourceFiled.FieldType == typeof(String))
                {
                    if (string.IsNullOrWhiteSpace(value as string))
                    {
                        sourceFiled.SetValue(sorcue, " ");
                    }

                }
                else
                {
                    if (null == value)
                    {
                        if (sourceFiled.FieldType == typeof(decimal))
                        {
                            sourceFiled.SetValue(sorcue, 0);
                        }
                           
                    }
                }


            }
        }


        public string GetSysTime()
        {
            string result = GetSystemDateTime();
            //DateTime.Now.ToString("yyyyMMddhhmmss");
            return result;
        }

        /// <summary>

        /// 将Base64字符串转换为图片

        /// </summary>

        /// <param name="sender"></param>

        /// <param name="e"></param>

        public string SavePic(string transferPic, string picID)
        {
            string base64 = transferPic;

            byte[] bytes = Convert.FromBase64String(base64);

            MemoryStream memStream = new MemoryStream(bytes);

            Bitmap tn = new Bitmap(memStream);//创建一个位图；把ms变成图片；

            string picPath = "OQA_Pic/" + picID + ".jpeg";

            string path = picPath.Substring(0, picPath.LastIndexOf("/"));
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            tn.Save(picPath, System.Drawing.Imaging.ImageFormat.Jpeg);

            return picPath;
            //..//OQA_Pic/20190311104054.jpeg

        }



        public Stream GetPic(string sPath)
        {
            MemoryStream ms = new MemoryStream();
            FileStream fs = new FileStream(sPath, FileMode.Open, FileAccess.Read);//创建一个文件，并把文件放在文件流里边；
            fs.Position = 0;//指明从第0位开始拷贝
            fs.CopyTo(ms);
            ms.Position = 0;//注意如果缺少该条代码接收端将无法显示上传图片
            return ms;//然后在返回客户端；

        }

        public  void SaveISPLotHistory(ModelListRsp<ISPLOTSTS> IN_ISPLOTSTS,string s_userid)
        {
            foreach (ISPLOTSTS S_ISPLOTSTS in IN_ISPLOTSTS.models)
            {
                SaveISPLotHistoryIml(S_ISPLOTSTS, s_userid);
            }
        }

        public void SaveISPLotHistory(ModelRsp<ISPLOTSTS> IN_ISPLOTST, string s_userid)
        {
            SaveISPLotHistoryIml(IN_ISPLOTST.model, s_userid);
        }

        private void SaveISPLotHistoryIml(ISPLOTSTS S_ISPLOTSTS, string s_userid)
        {
            UpdateModelListReq<ISPLOTHI> ISPLOTHIS_Save = new UpdateModelListReq<ISPLOTHI>();
            ModelListRsp<ISPLOTHI> ISPLOTHIS_message = new ModelListRsp<ISPLOTHI>();

            ISPLOTHI T_ISPLOTHIS = new ISPLOTHI(); //定义临时表结构
            T_ISPLOTHIS.LotId = S_ISPLOTSTS.LotId;
            T_ISPLOTHIS.FoupId = S_ISPLOTSTS.FoupId;
            T_ISPLOTHIS.Status = S_ISPLOTSTS.Status;
            T_ISPLOTHIS.InspectResult = S_ISPLOTSTS.InspectResult;
            T_ISPLOTHIS.PartId = S_ISPLOTSTS.PartId;
            T_ISPLOTHIS.PartDesc = S_ISPLOTSTS.PartDesc;
            T_ISPLOTHIS.ProductDieQty = S_ISPLOTSTS.ProductDieQty;
            T_ISPLOTHIS.Qty = S_ISPLOTSTS.Qty;
            T_ISPLOTHIS.RecUser = S_ISPLOTSTS.RecUser;
            T_ISPLOTHIS.RecUserName = S_ISPLOTSTS.RecUserName;
            T_ISPLOTHIS.RecDate = S_ISPLOTSTS.RecDate;
            T_ISPLOTHIS.RecShift = S_ISPLOTSTS.RecShift;
            T_ISPLOTHIS.Phone = S_ISPLOTSTS.Phone;
            T_ISPLOTHIS.LotType = S_ISPLOTSTS.LotType;
            T_ISPLOTHIS.Stage = S_ISPLOTSTS.Stage;
            T_ISPLOTHIS.Dept = S_ISPLOTSTS.Dept;
            T_ISPLOTHIS.InspectDate = S_ISPLOTSTS.InspectDate;
            T_ISPLOTHIS.CustomerId = S_ISPLOTSTS.CustomerId;
            T_ISPLOTHIS.CustLotId = S_ISPLOTSTS.CustLotId;
            T_ISPLOTHIS.CustPartId = S_ISPLOTSTS.CustPartId;
            T_ISPLOTHIS.OrignalCountry = S_ISPLOTSTS.OrignalCountry;
            T_ISPLOTHIS.QaId = S_ISPLOTSTS.QaId;
            T_ISPLOTHIS.QaStamp = S_ISPLOTSTS.QaStamp;
            T_ISPLOTHIS.Cmf1 = S_ISPLOTSTS.Cmf1;
            T_ISPLOTHIS.Cmf2 = S_ISPLOTSTS.Cmf2;
            T_ISPLOTHIS.Cmf3 = S_ISPLOTSTS.Cmf3;
            T_ISPLOTHIS.Cmf4 = S_ISPLOTSTS.Cmf4;
            T_ISPLOTHIS.Cmf5 = S_ISPLOTSTS.Cmf5;
            T_ISPLOTHIS.Cmf6 = S_ISPLOTSTS.Cmf6;
            T_ISPLOTHIS.Cmf7 = S_ISPLOTSTS.Cmf7;
            T_ISPLOTHIS.Cmf8 = S_ISPLOTSTS.Cmf8;
            T_ISPLOTHIS.Cmf9 = S_ISPLOTSTS.Cmf9;
            T_ISPLOTHIS.Cmf10 = S_ISPLOTSTS.Cmf10;
            T_ISPLOTHIS.TransSeq = S_ISPLOTSTS.TransSeq;
            T_ISPLOTHIS.CreateTime = S_ISPLOTSTS.CreateTime;
            T_ISPLOTHIS.CreateUserId = S_ISPLOTSTS.CreateUserId;
            T_ISPLOTHIS.UpdateTime = S_ISPLOTSTS.UpdateTime;
            T_ISPLOTHIS.UpdateUserId = S_ISPLOTSTS.UpdateUserId;
            T_ISPLOTHIS.TranTime = GetSysTime();
            T_ISPLOTHIS.TranUserId = s_userid;
            InitTable(T_ISPLOTHIS);
            ISPLOTHIS_Save.models.Add(T_ISPLOTHIS);

            //调用数据库操作

            ISPLOTHIS_Save.operateType = OperateType.Insert;
            //执行
            UpdateModels(ISPLOTHIS_Save, ISPLOTHIS_message);
        }

    }
}
