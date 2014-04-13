using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NasaReader.Integration.DataContracts.Feed
{
    [DataContract]
    public class PublishContractType
    {
        [DataMember]
        public string hour;
        
        [DataMember]
        public string minute;

        [DataMember]
        public string second;

        [DataMember]
        public string day;

        [DataMember]
        public string day_name;

        [DataMember]
        public string month;

        [DataMember]
        public string month_name;

        [DataMember]
        public string year;

        [DataMember]
        public int utime;
    }
}
