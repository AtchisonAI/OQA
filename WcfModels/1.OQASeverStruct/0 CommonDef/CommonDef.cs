using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFModels.OQA
{
    public sealed class LotSts
    {
        /// <summary>
        /// Lot在OQA系统节点中的状态
        /// </summary>
        public const string Create = "Create";
        public const string IspOut = "IspOut";
        public const string ChangeOut = "ChangeOut";
        public const string PackageOut = "PackageOut";
        public const string TransferOut = "TransferOut";
        public const string Close = "Close";
    }
}
