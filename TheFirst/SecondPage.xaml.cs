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

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace TheFirst
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class SecondPage : Page
    {
        Message mess = new Message();
        public SecondPage()
        {
            this.InitializeComponent();
        }

        private void logUpOkButton_Click(object sender, RoutedEventArgs e)
        {
            if(regupNameTextBox.Text == "" || reguoPasswordBox.Password == "")
            {
                logupFlyoutText.Text = "输入不能为空！";
                FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
            }
            else if (mess.search(regupNameTextBox.Text))
            {
                logupFlyoutText.Text = "账号已存在";
                FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
            }
            else
            {
                mess.regin(regupNameTextBox.Text, reguoPasswordBox.Password);
                displayNoWifiDialog();
                this.Frame.Navigate(typeof(MainPage));
            }
        }

        private async void displayNoWifiDialog()
        {
            ContentDialog noWifiDialog = new ContentDialog()
            {
                Title = "注册成功！",
                PrimaryButtonText = "Ok"
            };

            ContentDialogResult result = await noWifiDialog.ShowAsync();
        }
    }
}
