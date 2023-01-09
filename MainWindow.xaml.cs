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

namespace SpeedGameLauncherWPF
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

        private void CloseAllWindows()
        {
            for (int intCounter = App.Current.Windows.Count - 1; intCounter > 0; intCounter--)
                App.Current.Windows[intCounter].Close();
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private async void PlayGameDX12_Click(object sender, RoutedEventArgs e)
        {

            // MessageBox.Show("Project Speed 2 is not performance friendly when using DirectX12! It is recommended to play the game using the default DirectX11 renderer!");
            
            DX12 SGLWin = new DX12();
            SGLWin.Show();
            /* await Task.Run(() =>
            Close()); */
        }

        private async void PlayGameDefault_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"SpeedGame.exe");
            await Task.Run(() =>
                Close());
        }
    }
}
