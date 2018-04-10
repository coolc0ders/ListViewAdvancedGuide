using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewCompleteGuide.ViewModels
{
    public class NavigationViewModel : ReactiveObject
    {
        public ReactiveCommand NavigationItemSelectedCommand { get; private set; }
        
        public NavigationViewModel()
        {
            NavigationItemSelectedCommand = ReactiveCommand.Create<MasterDetailNavMenuItem>((n) =>
            {
                ;
            });
        }
    }
}
