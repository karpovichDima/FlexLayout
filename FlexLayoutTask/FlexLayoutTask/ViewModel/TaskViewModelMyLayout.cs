using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using FlexLayoutTask.Models;
using Xamarin.Forms;

namespace FlexLayoutTask.ViewModel
{
    public class TaskViewModelMyLayout
    {
        public ObservableCollection<Model> Models { get; set; }
        public ObservableCollection<Model> ListViewModels { get; set; }

        public ICommand AddCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public TaskViewModelMyLayout()
        {
            AddCommand = new Command(AddCommandHandler);
            DeleteCommand = new Command(DeleteCommandHandler);

            Models = new ObservableCollection<Model>
            {
                new Model{ Text = "Text1", Command = new Command(ChangeText)},
                new Model{ Text = "Text2", Command = new Command(ChangeText)}, 
                new Model{ Text = "Text3", Command = new Command(ChangeText)},
                new Model{ Text = "Text4", Command = new Command(ChangeText)},
                new Model{ Text = "Text5", Command = new Command(ChangeText)},
                new Model{ Text = "Text6", Command = new Command(ChangeText)},
                new Model{ Text = "Text7", Command = new Command(ChangeText)},
                new Model{ Text = "Text8", Command = new Command(ChangeText)},
                new Model{ Text = "Text9", Command = new Command(ChangeText)},
                new Model{ Text = "Text10", Command = new Command(ChangeText)},
            };
            ListViewModels = new ObservableCollection<Model>
            {
                new Model{ Text = "Text1"},
                new Model{ Text = "Text2"},
                new Model{ Text = "Text3"},
                new Model{ Text = "Text4"},
                new Model{ Text = "Text5"},
                new Model{ Text = "Text6"},
                new Model{ Text = "Text7"},
                new Model{ Text = "Text8"},
                new Model{ Text = "Text9"},
                new Model{ Text = "Text10"},
                new Model{ Text = "Text1"},
                new Model{ Text = "Text2"},
                new Model{ Text = "Text3"},
                new Model{ Text = "Text4"},
                new Model{ Text = "Text5"},
                new Model{ Text = "Text6"},
                new Model{ Text = "Text7"},
                new Model{ Text = "Text8"},
                new Model{ Text = "Text9"},
                new Model{ Text = "Text10"},
            };
        }

        private void ChangeText(object obj)
        {
            var model = (Model)obj;
            var modelText = model.Text;
        }

        private void AddCommandHandler()
        {
            Models.Add(new Model{Text = "NEW_TEXT"});
        }
        
        private void DeleteCommandHandler(object obj)
        {
            if (obj is Model model)
            {
                var text = model.Text;
            }

            Models.Remove(Models.Last());
        }
    }
}