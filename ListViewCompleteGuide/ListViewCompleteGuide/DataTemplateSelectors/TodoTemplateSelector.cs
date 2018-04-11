using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using ListViewCompleteGuide.DataTemplates;
using ListViewCompleteGuide.Models;

namespace ListViewCompleteGuide.DataTemplateSelectors
{
    public class TodoTemplateSelector : DataTemplateSelector
    {
        public DataTemplate PrimaryItemTemplate { get; set; }
        public DataTemplate SecondaryItemTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var todo = item as Todo;

            return todo.IsDone ? SecondaryItemTemplate : PrimaryItemTemplate;
        }
    }
}
