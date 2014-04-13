using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NasaReader.Integration.DataContracts.Feed
{
    [DataContract]
    public class ValueContractType
    {
        [DataMember]
        public string title;
        
        [DataMember]
        public string description;
        
        [DataMember]
        public string link;

        [DataMember]
        public string pubDate;
        
        [DataMember]
        public string generator;
        
        [DataMember]
        public string callback;
        
        [DataMember]
        public FeedContractType[] items;
        
    }
}
