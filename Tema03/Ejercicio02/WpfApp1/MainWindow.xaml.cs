using BibliotecaClases;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Windows.UI.Xaml.Controls;

namespace WpfApp1
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
        /// <summary>
        /// Al pulsar el botón, crea una persona con el nombre introducido en el textbox
        /// </summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ClsPersona persona = new ClsPersona(tbNom.Text);

            MessageBox.Show("Buenos días " + persona.Nombre);

        }
    }
}