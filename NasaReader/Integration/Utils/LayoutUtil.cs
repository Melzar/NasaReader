using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace NasaReader.Integration.Utils
{
    class LayoutUtil
    {
        /// <summary>
        /// Method for generating basic skeletion for grid
        /// </summary>
        /// <param name="colnumber"></param>
        /// <param name="contentpanel"></param>
        public static void GenerateDynamicGridSkeleton(int colnumber, Grid contentpanel)
        {
            contentpanel.ColumnDefinitions.Clear();
            contentpanel.RowDefinitions.Clear();
            while(colnumber != 0)
            {
                ColumnDefinition column = new ColumnDefinition();
                contentpanel.ColumnDefinitions.Add(column);
                colnumber--;
            }
            RowDefinition header = new RowDefinition();
            contentpanel.RowDefinitions.Add(header);
        }

    }
}
