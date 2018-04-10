using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

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
                new MasterDetailNavMenuItem{Title = "Contacts"},
                new MasterDetailNavMenuItem{Title = "Todos"}
            };

            NavigationItemSelectedCommand = ReactiveCommand.Create<MasterDetailNavMenuItem>((n) =>
            {
                ;
            });
        }
    }
}
