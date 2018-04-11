using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewCompleteGuide
{
    public class ListViewGrouping<T> : List<T>
    {
        public string Title { get; set; }
        public string ShortName { get; set; }

        public ListViewGrouping(string title, string shortName)
        {
            Title = title;
            ShortName = shortName;
        }
    }
}
