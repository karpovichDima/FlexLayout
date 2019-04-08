using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlexLayoutTask.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TaskView : ContentPage
    {
        public TaskView()
        {
            InitializeComponent();
        }

        private void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            
        }

        private void GoTopButtonClicked(object sender, EventArgs e)
        {
            
        }
    }
}