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
using System.ComponentModel;
using System.Data;
using Windows.UI.Popups;
using System.Text;
using System.Threading.Tasks;
using SDKTemplate;
using Tickets;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace LotteryApp.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Customer : Page
    {
        public Customer()
        {
            this.InitializeComponent();
        }

        async Task OnClick_btnCreateAsync(object sender, RoutedEventArgs e)
        {
            Tickets.Customer tempCust = new Tickets.Customer(txtName.ToString(), txtPhone.ToString(), txtEmail.ToString());
            App.currentCustomer = tempCust;
            var created = new MessageDialog("Customer Created");

            await created.ShowAsync();
        }
        void OnClick_btnCancel(object sender, RoutedEventArgs e)
        {
            txtEmail.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
        }
    }
}
