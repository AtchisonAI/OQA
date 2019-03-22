namespace OQAService
{
    class GlobalConstant
    {
        public const char TRAN_CREATE = 'I';
        public const char TRAN_DELETE = 'D';
        public const char TRAN_UPDATE = 'U';
        public const char TRAN_VIEW = 'Q';
    }

    class IspResult
    {
        public const string Create = "Create";
        public const string Pass = "Pass";
        public const string Hold = "Hold";
        public const string Pndn = "Pndn";
        public const string Scrap = "Scrap";
    }

    class IspType
    {
        public const string AOI = "AOI";
        public const string MACRO = "MACRO";
        public const string MIRCRO = "MIRCRO";
    }
}
