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
        DataTemplate PrimaryItemTemplate;
        DataTemplate SecondaryItemTemplate;

        public TodoTemplateSelector()
        {
            PrimaryItemTemplate = new DataTemplate(typeof(CurrentTodoTemplate));
            SecondaryItemTemplate = new DataTemplate(typeof(CompletedTodoTemplate));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var todo = item as Todo;

            return todo.IsDone ? SecondaryItemTemplate : PrimaryItemTemplate;
        }
    }
}
