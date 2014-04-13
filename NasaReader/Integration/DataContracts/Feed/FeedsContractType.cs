using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NasaReader.Integration.DataContracts.Feed
{
    [DataContract]
    public class FeedsContractType
    {
        [DataMember]
        public string count;

        [DataMember]
        public ValueContractType value;
    }

}
