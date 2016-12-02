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

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace TheFirst
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Message message = new Message("BlackFacer", "8088");
        public MainPage()
        {
            this.InitializeComponent();
        }
        
        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            upText.Text = "";
            if (message.search(nameTextBox.Text))
            {
               if(message.martch(nameTextBox.Text,passwordBox.Password))
                {
                    upText.Text = "(゜-゜)つロ乾杯\n此处应留下点什么蓝色的东西（滑稽）";
                    loginFlyoutText.Text = "登陆成功！";
                    FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
                }
               else
                {
                    loginFlyoutText.Text = "密码错误！";
                    FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
                }
            }
            else
            {
                loginFlyoutText.Text = "账号不存在，请注册新账号";
                FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
            }
        }

        private void logUpButton_Click(object sender, RoutedEventArgs e)
        {
               this.Frame.Navigate(typeof(SecondPage));
        }
    }
}
