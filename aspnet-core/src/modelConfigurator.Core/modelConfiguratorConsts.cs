using modelConfigurator.Debugging;

namespace modelConfigurator
{
    public class modelConfiguratorConsts
    {
        public const string LocalizationSourceName = "modelConfigurator";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "9cd265ecb75d4ad0ad3a5785358c8533";
    }
}
