using System;
using System.Collections.Generic;
using System.Text;

namespace ArchitecturalPatterns.Model
{
    public class SomeModel : NotifyPropertyChanged
    {
        private string _value;

        public string Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged();
            }
        }
    }
}
