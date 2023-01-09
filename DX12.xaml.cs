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
using System.Windows.Shapes;
using System.Diagnostics;

namespace SpeedGameLauncherWPF
{
    /// <summary>
    /// Interaction logic for DX12.xaml
    /// </summary>
    public partial class DX12 : Window
    {
        public DX12()
        {
            InitializeComponent();
        }

        private async void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            // Close all windows
            Application.Current.Windows.OfType<Window>().ToList().ForEach(x => x.Close());

            // Open the executable file "SpeedGame" with the launch argument "-dx12"
            System.Diagnostics.Process.Start("SpeedGame", "-dx12");
        }


    }
}
