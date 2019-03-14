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
        public const string PAK_S = "PAKS";
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

    public sealed class LotSts
    {
        /// <summary>
        /// 同一级上传图片分类 LOT OQA 收料外观图片类型
        /// </summary>
        public const string Create = "Create";
        public const string IspOut = "IspOut";
        public const string ChangeOut = "ChangeOut";
        public const string PackageOut = "PackageOut";
        public const string TransferOut = "TransferOut";
    }
}
