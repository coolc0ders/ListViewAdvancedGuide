using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewCompleteGuide
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailNav : MasterDetailPage
    {
        public MasterDetailNav()
        {
            InitializeComponent();
        }
    }
}