using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NasaReader.Integration.Utils
{
    class EnumUtil
    {

        public static string getEnumDescription(Enum value)
        {
            if(value == null)
                return "";

            FieldInfo field = value.GetType().GetField(value.ToString());
            DescriptionAttribute attr = field.GetCustomAttribute(typeof(DescriptionAttribute), false) as DescriptionAttribute;
            return attr != null ? attr.Description : "";
        }

    }
}
