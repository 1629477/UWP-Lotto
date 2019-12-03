using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace LotteryApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;
            this.mainFrame.Navigated += MainFrame_Navigated;

            SystemNavigationManager.GetForCurrentView().BackRequested += OnBackRequested;
        }
        private void OnBackRequested(object sender, BackRequestedEventArgs e)
        {
            if (mainFrame.CanGoBack)
            {
                e.Handled = true;
                mainFrame.GoBack();
            }
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {
            btnBack.IsEnabled = mainFrame.CanGoBack;
            btnForward.IsEnabled = mainFrame.CanGoForward;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(Pages.Euro));
        }

        private void OnGoBackClick(object sender, RoutedEventArgs e)
        {
            if (mainFrame.CanGoBack) mainFrame.GoBack();
        }

        private void OnGoForwardClick(object sender, RoutedEventArgs e)
        {
            if (mainFrame.CanGoForward) mainFrame.GoForward();
        }

        private void OpenSplitViewClick(object sender, RoutedEventArgs e)
        {
            this.mainSplitView.IsPaneOpen = !this.mainSplitView.IsPaneOpen;
        }

        private void OnGoEuroClick(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(Pages.Euro));
        }

        private void OnGoCustomerClick(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(Pages.Customer));
        }

        private void OnGoLottoClick(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(Pages.Lotto));
        }
    }
}
