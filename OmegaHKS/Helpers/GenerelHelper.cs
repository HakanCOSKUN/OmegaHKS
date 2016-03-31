using System;
using System.Collections.Generic;
using System.Linq;

namespace OmegaHKS.Helpers
{
    public static class GenerelHelper
    {
        public static string GetDecimalToString(decimal? input)
        {
            return !input.HasValue ? string.Empty : input.Value.ToString();
        }

        public static string GetIntToString(int? input)
        {
            return !input.HasValue ? string.Empty : input.Value.ToString();
        }

        public static string NumVal(string pValue)
        {
            var retValue = !string.IsNullOrEmpty(pValue) ? pValue : "NULL";
            return retValue;
        }

        public static bool IsConnected()
        {
            var sonuc = false;
            try
            {
                var networkUp = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
                if (networkUp)
                {
                    return new System.Net.NetworkInformation.Ping().Send("www.google.com", 1000).Status == System.Net.NetworkInformation.IPStatus.Success;
                }
                else
                {
                    return sonuc;
                }
            }
            catch (Exception)
            {
                return sonuc;
            }
        }
    }
}
