﻿using PP.ViewModel;
using System.Windows;

namespace PP
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CollectionsView.DataContext = new CollectionsController {getCollection = new CameraCollection()};
        }
    }
}
