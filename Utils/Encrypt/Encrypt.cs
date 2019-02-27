using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Encrypt
{
    public class Encrypt
    {
        public static string RSAEncode(string str)
        {
            long P;
            long Q;
            //long D;
            //long M;
            long N;
            long num;
            long tempM;

            P = 13;
            Q = 23;
            N = P * Q;
            //D = 53;

            StringBuilder enCodeStr = new StringBuilder();
            string tempStr;

            for (int i = 0; i < str.Length;++i)
            {
                //按顺序取字符串中的字符，并转成相应的ascii码值
                num = (int)str[i];

                //加密运算
                tempM = (long)((Math.Pow(num,2) % N) * (Math.Pow(num ,2) % N) * (num % N)) % N;

                //将加密后的值转成固定的4位字符串，不足4位的在前面补零
                tempStr = String.Format("{0:d4}", (int)tempM);
                enCodeStr.Append(tempStr);
            }

            return enCodeStr.ToString();
        }

        public static string RSADecode(string str)
        {
            StringBuilder decodeString = new StringBuilder("");
            string tmpString;
            int inputSLen;
            long P;
            long Q;
            //long D;
            long M;
            long N;
            long tempM;
            long num;

            P = 13;
            Q = 23;
            N = P * Q;
            //D = 53;

            inputSLen = (str.Length) / 4;

            for (int i = 0; i < inputSLen; i++)
            {
                tmpString = str.Substring(4 * i, 4);

                //将内容位数字的字符串转为数字
                num = System.Convert.ToInt64(tmpString);
                M = (num * num) % N;

                tempM = 1;
                for (int j = 0; j < 26; j++)
                {
                    tempM = (tempM * M) % N;
                }
                tempM = (tempM * (num % N)) % N;

                //转换解密后的数值成其相应的ascii字符
                decodeString.Append((char)tempM);
            }

            return decodeString.ToString();
        }
    }
}