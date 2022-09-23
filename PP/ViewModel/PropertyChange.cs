﻿using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace PP.ViewModel
{
    public class PropertyChange : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
