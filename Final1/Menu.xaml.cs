using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class Menu : Page
    {
        public Menu()
        {
            this.InitializeComponent();
        }

        private void Image_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private async void Mbtn1_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog msgbox = new MessageDialog("No classes scheduled!", "Class Scheduler");
            msgbox.Commands.Clear();
            msgbox.Commands.Add(new UICommand { Label = "OK", Id = 0 });
          
            var res = await msgbox.ShowAsync();

            if ((int)res.Id == 0)
            {
               
                this.Frame.Navigate(typeof(Menu), null);
            }


            else
            {
            }

        }
      

        private void Mbtn5_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Add), null);
        }


    }
}
