using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OQA_Core
{
    public sealed class GlobConst
    {
        public const char TRAN_CREATE = 'I';
        public const char TRAN_DELETE = 'D';
        public const char TRAN_UPDATE = 'U';
        public const char TRAN_VIEW = 'Q';
    }

    public sealed class UpLoadFlag
    {
        public const int ByLot = 1;
        public const int ByWafer = 2;
        public const int BySide = 3;
        public const int ByPoint = 4;
    }

    public sealed class ImageType
    {
        /// <summary>
        /// 同一级上传图片分类 LOT OQA 收料外观图片类型
        /// </summary>
        public const string ISP = "ISP";
        public const string PAK_F = "PAK_F";
        public const string PAK_S = "PAK_S";
        public const string PAK_P = "PAK_P";
        public const string PAK_A = "PAK_A";

    }

    public sealed class InspectType
    {
        public const string AOI = "AOI";
        public const string MA = "MACRO";
        public const string MI = "MIRCRO";
    }

    public sealed class SideType
    {
        public const string Front = "F";
        public const string Back = "B";
    }

    public sealed class DefectCodeList
    {
        public static readonly string[] code = new string[] { "A", "S", "D", "F", "C", "P", "R", "B", "O" };
    }

    public sealed class CheckType
    {
        //lot 检验类型
        public const string FOREIGN_C = "FOREIGN_C";
        public const string SEAL_C = "SEAL_C";
        public const string PEEL_C = "PEEL_C";
        public const string PACKING_C = "PACKING_C";
        public const string SURFACE_C = "SURFACE_C";
        public const string SHIP_C = "SHIP_C";
        public const string PIN_C = "PIN_C";
        public const string FOSB_C = "FOSB_C";
    }

    public sealed class CheckItemSts
    {
        //lot 检验类型
        public const string OK = "OK";
        public const string NO = "NO";
    }
}
