using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Final1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            signinblock.Visibility = Visibility.Visible;
            registerblock.Visibility = Visibility.Collapsed;
            
        }

        

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {

        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Menu), null);
        }

        private void register_Click(object sender, RoutedEventArgs e)
        {
            signinblock.Visibility = Visibility.Collapsed;
            registerblock.Visibility = Visibility.Visible;
        }

        private void registerb_Click(object sender, RoutedEventArgs e)
        {
         
        }

        private void loginb_Click(object sender, RoutedEventArgs e)
        {
            signinblock.Visibility = Visibility.Visible;
            registerblock.Visibility = Visibility.Collapsed;
        }
    }
}
