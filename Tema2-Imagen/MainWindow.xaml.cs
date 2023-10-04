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

namespace Tema2_Imagen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Alta_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (imagen_Image != null)
                imagen_Image.Opacity = 1;
        }

        private void Media_RadioButton_Checked(object sender, RoutedEventArgs e) 
            => imagen_Image.Opacity = 0.6;

        private void Baja_RadioButton_Checked(object sender, RoutedEventArgs e) 
            => imagen_Image.Opacity = 0.3;

        private void Relleno_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (imagen_Image != null)
                imagen_Image.Stretch = Stretch.Fill;
        }

        private void Uniforme_RadioButton_Checked(object sender, RoutedEventArgs e) 
            => imagen_Image.Stretch = Stretch.Uniform;

        private void RellenoUniforme_RadioButton_Checked(object sender, RoutedEventArgs e) 
            => imagen_Image.Stretch = Stretch.UniformToFill;

        private void SinAjustar_RadioButton_Checked(object sender, RoutedEventArgs e) 
            => imagen_Image.Stretch = Stretch.None;
    }
}
