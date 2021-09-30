using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Opacidad
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ImagenEpisodioIV_MouseEnter(object sender, MouseEventArgs e)
        {
            ImagenEpisodioIV.Opacity = 0.5;
        }

        private void ImagenEpisodioIV_MouseLeave(object sender, MouseEventArgs e)
        {
            ImagenEpisodioIV.Opacity = 1;
        }

        private void ImagenEpisodioV_MouseEnter(object sender, MouseEventArgs e)
        {
            ImagenEpisodioV.Opacity = 0.5;
        }

        private void ImagenEpisodioV_MouseLeave(object sender, MouseEventArgs e)
        {
            ImagenEpisodioV.Opacity = 1;
        }

        private void ImagenEpisodioVI_MouseEnter(object sender, MouseEventArgs e)
        {
            ImagenEpisodioVI.Opacity = 0.5;
        }

        private void ImagenEpisodioVI_MouseLeave(object sender, MouseEventArgs e)
        {
            ImagenEpisodioVI.Opacity = 1;
        }
    }
}
