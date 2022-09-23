using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using PP.Model;

namespace PP.ViewModel
{
    public class CollectionsController : PropertyChange
    {
        public CollectionsController()
        {
            Cameras = new ObservableCollection<Camera>(Collection.GetCam());
        }
        private static ObservableCollection<Camera> _cameras;
        public static ObservableCollection<Model.Camera> Cameras 
        { 
            get => _cameras;
            set
            {
                var prop = new PropertyChange();
                _cameras = value;

                prop.OnPropertyChanged();
            }
        }
        private RelayCommand loadMoreCamerasCommand;
        public RelayCommand LoadMoreCamerasCommand
        {
            get
            {
                return loadMoreCamerasCommand ??
                    (loadMoreCamerasCommand = new RelayCommand(obj =>
                    {
                        for (int i = 1; i < 30; i++)
                        {
                            Camera camera = new Camera();
                            camera.Name = "Камера "+i;
                            Cameras.Add(camera);
                        }
                    }));
            }
        }
    }
}
