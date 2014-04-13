using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaReader.Integration.Enums
{
    public class MessagesEnum
    {
        public enum ConnectionErrors
        {
            [Description("Internet connection is required to load the required data. Turn on you internet connection")]
            NoConnectionError
        }

    }
}
