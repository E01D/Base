using System;

namespace Root.Coding.Code.Framework.E01D
{
    public class FrameworkInstance
    {
        private const string DisableCachingName = @"TestSwitch.LocalAppContext.DisableCaching";
        private const string DontEnableSchUseStrongCryptoName = @"Switch.System.Net.DontEnableSchUseStrongCrypto";

        public void InitializeNetworkFor46()
        {
            AppContext.SetSwitch(DisableCachingName, true);
            AppContext.SetSwitch(DontEnableSchUseStrongCryptoName, true);
        }
    }
}
