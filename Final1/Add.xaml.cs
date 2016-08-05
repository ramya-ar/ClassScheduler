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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Final1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Add : Page
    {
        public Add()
        {
            this.InitializeComponent();
        }

        private void Abtn1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Add_Lecture), null);
        }

        private void Abtn2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Add_Assignment), null);
        }

        private void Abtn3_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Add_Test), null);
        }

        private void Abtn4_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Add_Score), null);
        }

        private void Abtn5_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Menu), null);

        }
    }
}
