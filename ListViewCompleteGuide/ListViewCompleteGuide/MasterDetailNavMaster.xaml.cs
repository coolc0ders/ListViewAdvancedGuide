using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewCompleteGuide
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailNavMaster : ContentPage
    {
        public ListView ListView;

        public MasterDetailNavMaster()
        {
            InitializeComponent();

            BindingContext = new MasterDetailNavMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterDetailNavMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterDetailNavMenuItem> MenuItems { get; set; }
            
            public MasterDetailNavMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterDetailNavMenuItem>(new[]
                {
                    new MasterDetailNavMenuItem { Id = 0, Title = "Page 1" },
                    new MasterDetailNavMenuItem { Id = 1, Title = "Page 2" },
                    new MasterDetailNavMenuItem { Id = 2, Title = "Page 3" },
                    new MasterDetailNavMenuItem { Id = 3, Title = "Page 4" },
                    new MasterDetailNavMenuItem { Id = 4, Title = "Page 5" },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}