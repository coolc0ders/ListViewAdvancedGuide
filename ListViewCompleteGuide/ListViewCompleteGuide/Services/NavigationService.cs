using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ListViewCompleteGuide.Services
{
    public class NavigationService
    {
        static public void Navigate(MasterDetailNavMenuItem menuItem)
        {
            var masterPage = (App.Current.MainPage as MasterDetailPage);

            switch (menuItem.Id)
            {
                case 1:
                    masterPage.Detail = new NavigationPage(new ContactsPage());
                    break;
                case 2:
                    masterPage.Detail = new NavigationPage(new TodoItemPage());
                    break;
            }

            if(masterPage.IsPresented)
            {
                masterPage.IsPresented = false;
            }
        }
    }
}
