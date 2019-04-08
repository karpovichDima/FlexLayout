using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using FlexLayoutTask.Annotations;
using FlexLayoutTask.Models;
using Xamarin.Forms;

namespace FlexLayoutTask.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private int _valueA;
        private int _valueB;
        private int _result;

        public ICommand AddCommand { get; set; }
        public ICommand MultiplyCommand { get; set; }

        public int ValueA
        {
            get { return _valueA; }
            set
            {
                _valueA = value;
                OnPropertyChanged();
            }
        }

        public int ValueB
        {
            get { return _valueB; }
            set
            {
                _valueB = value;
                OnPropertyChanged();
            }
        }

        public int Result
        {
            get { return _result; }
            set
            {
                _result = value;
                OnPropertyChanged();
            }
        }

        public MainPageViewModel()
        {
            /*MultiplyCommand = new Command(MultiplyCommandHandler);
            AddCommand = new Command(AddCommandHandler);*/
        }

        public void AddCommandHandler()
        {
            Result = _valueA + _valueB;
        }

        public void MultiplyCommandHandler()
        {
            Result = _valueA * _valueB;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}