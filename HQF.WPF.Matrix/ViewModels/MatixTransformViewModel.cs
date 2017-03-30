using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using HQF.WPF.Matrix.Models;

namespace HQF.WPF.Matrix.ViewModels
{
    public class MatixTransformViewModel : BindableBase
    {
        private Rectangle _currentRectangle;

        public MatixTransformViewModel()
        {
            AddCommand=new DelegateCommand(AddD3Matrix);
            RemoveCommand=new DelegateCommand<D3Matrix>(RemoveD3Matrix);
            ApplyCommand=new DelegateCommand(ApplyD3Matrixs);

            CurrentRectangle=new Rectangle() {Width = 100,Height = 100,Stroke = Brushes.Coral};

            D3Matrixs =new ObservableCollection<D3Matrix>();

            D3Matrixs.Add(D3Matrix.FroMatrix(System.Windows.Media.Matrix.Identity));
            D3Matrixs.Add(D3Matrix.FroMatrix(System.Windows.Media.Matrix.Identity));


            Shapes = new ObservableCollection<Shape>();

            Shapes.Add(CurrentRectangle);
        }

        private void ApplyD3Matrixs()
        {
            foreach (var d3Matrix in D3Matrixs)
            {
                CurrentRectangle.RenderTransform=new MatrixTransform(d3Matrix.ToMatrix());
            }
            
        }

        private void RemoveD3Matrix(D3Matrix obj)
        {
            throw new NotImplementedException();
        }

        private void AddD3Matrix()
        {
            throw new NotImplementedException();
        }

        public ICommand AddCommand { get; set; }
        public ICommand RemoveCommand { get; set; }

        public ICommand ApplyCommand { get; set; }

        public ObservableCollection<D3Matrix> D3Matrixs { get; set; }

        public ObservableCollection<Shape> Shapes { get; set; }

        public Rectangle CurrentRectangle
        {
            get { return _currentRectangle; }
            set { SetProperty(ref _currentRectangle, value); }
        }
    }
}
