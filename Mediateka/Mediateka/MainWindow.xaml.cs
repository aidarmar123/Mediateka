﻿using Mediateka.Models;
using Mediateka.Pages;
using Mediateka.Services;
using Mediateka.Windows;
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

namespace Mediateka
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            App.mainWindow = this;
            MainFrame.Navigate(new LoginPage());
        }


        private void BExit_Click(object sender, RoutedEventArgs e)
        {
            App.ExitFromApp();
            this.DataContext = null;
            GProfile.Visibility = Visibility.Collapsed;
            MainFrame.Navigate(new LoginPage());
        }

        private void BAddUser_Click(object sender, RoutedEventArgs e)
        {
            new SelectRole().ShowDialog();
            if (App.SelectRoleReg != null)
            {
                if (App.SelectRoleReg.Id == 1)
                    MainFrame.Navigate(new RegestrationPage(new EventPlanner()));
                else if (App.SelectRoleReg.Id == 2)
                    MainFrame.Navigate(new RegestrationPage(new Executor()));
                else if (App.SelectRoleReg.Id == 3)
                    MainFrame.Navigate(new RegestrationModerator(new Moderators()));


            }
        }

        private void GProfile_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var contextModerator = this.DataContext as Moderators;
            if (contextModerator != null)
            {
                MainFrame.Navigate(new RegestrationModerator(contextModerator));
            }
            else
            {
                if (DataContext is Executor executor)
                {
                    var profile = new RegestrationPage(executor);
                    profile.ExPortfolio.Visibility = Visibility.Visible;
                    MainFrame.Navigate(profile);

                }

                else if (DataContext is EventPlanner eventPlanner)
                {
                    MainFrame.Navigate(new RegestrationPage(eventPlanner));

                }


            }

            Refresh();
        }

        public void Refresh()
        {
            DataContext = null;
            if (App.contextExecutor != null)
            {
                DataContext = App.contextExecutor;
            }
            else if (App.contextEventPlanner != null)
            {
                DataContext = App.contextEventPlanner;
            }
            else if (App.contextModerator != null)
            {
                DataContext = App.contextModerator;
            }

        }
    }
}
