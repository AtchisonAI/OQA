namespace OQAService
{
    class GlobalConstant
    {
        public const char TRAN_CREATE = 'I';
        public const char TRAN_DELETE = 'D';
        public const char TRAN_UPDATE = 'U';
        public const char TRAN_VIEW = 'Q';
    }

    class ISPStatus
    {
        public const string Create = "Create";
        public const string IspOut = "IspOut";
        public const string ChangeOut = "ChangeOut";
        public const string PackageOut = "PackageOut";
        public const string TransferOut = "TransferOut";
        
    }


    class IspResult
    {
        public const string Create = "Create";
        public const string IspOut = "Pass";
        public const string ChangeOut = "Hold";
        public const string PackageOut = "Pndn";
    }

    class IspType
    {
        public const string AOI = "AOI";
        public const string MACRO = "MACRO";
        public const string MIRCRO = "MIRCRO";
    }
}
