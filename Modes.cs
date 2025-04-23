using System.Configuration;

namespace WfsMrFlexSetup
{
    public static class Modes
    {
        public static string MODE_SR = ConfigurationManager.AppSettings["modeSR"];
        public static string MODE_MRXP = ConfigurationManager.AppSettings["modeMrxp"];
    }
}
