using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlexLayoutTask.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TaskMyLayout : ContentPage
	{
		public TaskMyLayout ()
		{
			InitializeComponent ();
		}

	    private void Element_OnChildAdded(object sender, ElementEventArgs e)
	    {
	        
	    }
	}
}