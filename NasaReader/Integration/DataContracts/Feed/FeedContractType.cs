using NasaReader.Integration.DataContracts.Feed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NasaReader.Integration.DataContracts
{
    [DataContract]
    public class FeedContractType
    {
        [DataMember]
        public string title;

        [DataMember]
        public string link;

        [DataMember]
        public string description;

        [DataMember]
        public SourceContractType source;

        [DataMember(Name = "y:published")]
        public PublishContractType published;
    };
}
