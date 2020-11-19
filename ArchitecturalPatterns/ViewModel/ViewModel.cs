using ArchitecturalPatterns.Commands;
using ArchitecturalPatterns.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ArchitecturalPatterns.ViewModel
{
    public class ViewModel : NotifyPropertyChanged
    {
        private string inputValue;

        public string InputValue
        {
            get => inputValue;
            set
            {
                inputValue = value;
                OnPropertyChanged();
            }
        }
        public SomeModel Model { get; set; }
        public ICommand SaveCommand { get; set; }
        public ICommand LoadCommand { get; set; }

        public ViewModel()
        {
            Model = new SomeModel();
            SaveCommand = new Command(x => Model.Value = InputValue, x => InputValue != Model.Value);
            LoadCommand = new Command(x => InputValue = Model.Value, x => InputValue != Model.Value);
        }
    }
}
