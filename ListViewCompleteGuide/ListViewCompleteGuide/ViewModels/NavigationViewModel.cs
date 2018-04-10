using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace ListViewCompleteGuide.ViewModels
{
    public class NavigationViewModel : ReactiveObject
    {
        public ReactiveCommand NavigationItemSelectedCommand { get; private set; }
        public ObservableCollection<MasterDetailNavMenuItem> MenuItems { get; set; }

        public NavigationViewModel()
        {
            MenuItems = new ObservableCollection<MasterDetailNavMenuItem>
            {
                new MasterDetailNavMenuItem{Title = "Contacts", Id = 1},
                new MasterDetailNavMenuItem{Title = "Todos", Id = 2}
            };

            NavigationItemSelectedCommand = ReactiveCommand.Create<MasterDetailNavMenuItem>((n) =>
            {
                if(n.Id == 1)
                {
                    (App.Current.MainPage as MasterDetailPage).Master = new ContactsPage();
                }
                else
                {
                    (App.Current.MainPage as MasterDetailPage).Master = new TodoItemPage();
                }
                ;
            });
        }
    }
}
