using Xamarin.Forms;

namespace FlexLayoutTask.CustomControlls
{
    public class CustomStackLayout : StackLayout
    {
        public static readonly BindableProperty ViewModelCommandProperty = BindableProperty.Create("ViewModelCommand", typeof(Command), typeof(CustomStackLayout), null);

        public Command ViewModelCommand
        {
            get => (Command)GetValue(ViewModelCommandProperty);
            set => SetValue(ViewModelCommandProperty, value);
        }
    }
}