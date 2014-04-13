using NasaReader.Integration.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaReader.Integration.Utils
{
    class DataUtil
    {

        public static string FormatDataFromContract(FeedContractType contract)
        {
            return contract.published.day_name + " " + UnixTimeStampToDate(contract.published.utime);
        }

        public static string UnixTimeStampToDate(int timestamp)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0 ,System.DateTimeKind.Utc);
            return dtDateTime.AddSeconds(timestamp).ToString("h:mm:ss tt MM/dd/yyyy");
        }

        public static string UnixTimeStampToDateCustom(int timestamp, string format)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            return dtDateTime.AddSeconds(timestamp).ToString(format);
        }
    }
}
