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
    public sealed partial class Add_Assignment : Page
    {
        public Add_Assignment()
        {
            this.InitializeComponent();
            for (int i = 10; i <= 100; i++)
            {

                String theNumber = string.Format("{0:d2}", i);
                APoints1.Items.Add(theNumber);
                i += 9;
            }
            APoints1.SelectedIndex = 0;
        }

        private void AAbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Add), null);
        }

    }
}
