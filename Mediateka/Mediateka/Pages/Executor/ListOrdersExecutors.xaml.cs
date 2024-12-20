﻿using Mediateka.Models;
using Mediateka.Windows;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mediateka.Pages
{
    /// <summary>
    /// Логика взаимодействия для ListOrdersExecutors.xaml
    /// </summary>
    public partial class ListOrdersExecutors : Page
    {
        List<Event> listEvent = App.Db.Event.Where(ev => ev.StatusId == 1).ToList();
        public ListOrdersExecutors()
        {
            InitializeComponent();
            Refresh();
        }

        private void Refresh()
        {
            LVEvents.ItemsSource = listEvent;
            LVOrders.ItemsSource = App.Db.EventExecutor.Where(x=>x.ExecutorId == App.contextExecutor.Id && x.StatusExecutorId==1).ToList();
            
        }

        private void BResponse_Click(object sender, RoutedEventArgs e)
        {
            var contextEvent = (sender as Button).DataContext as Event;
            if (contextEvent != null)
            {
                //Проверяем отликнулься ли уже пользователь
             
                var eventExecutor = new EventExecutor()
                {
                    ExecutorId = App.contextExecutor.Id,
                    EventId = contextEvent.Id,
                    StatusExecutorId = 2
                };
                App.Db.EventExecutor.Add(eventExecutor);
                App.Db.SaveChanges();
                Refresh();
            }
        }

        private void TBSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            listEvent = App.Db.Event.Where(ev => ev.StatusId == 1).ToList();
            listEvent = listEvent.Where(ev => ev.EventPlanner.MediumRating >= RatingBar.Value).ToList();

            var text = TBSearch.Text;
            if (string.IsNullOrEmpty(text))
            {
                Refresh();
            }
            else
            {
                LVEvents.ItemsSource = listEvent.Where(ev=>ev.SearchText.Contains(text)).ToList();
            }
        }

        

        private void LVEvents_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (LVEvents.SelectedItem is Event _event)
            {
                new EventWindow(_event).ShowDialog();
            }
        }

        private void BUpload_Click(object sender, RoutedEventArgs e)
        {
            if(LVOrders.SelectedItem is EventExecutor eventExecutor)
            {
                new UnstallFile(eventExecutor).ShowDialog();
                Refresh();
                
            }
            else
            {
                Xceed.Wpf.Toolkit.MessageBox.Show("Выбирете мероприятие");
            }
        }

        private void BRemoveFile_Click(object sender, RoutedEventArgs e)
        {
            var material = (sender as Button).DataContext as MaterialEvent;
            if(material != null)
            {
                App.Db.MaterialEvent.Remove(material);
                App.Db.SaveChanges();
                Refresh();
            }
        }

        private void LVOrders_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (LVOrders.SelectedItem is EventExecutor eventExecutor)
            {
                new EventWindow(eventExecutor.Event).ShowDialog();
            }
        }

        private void RatingBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            listEvent = App.Db.Event.Where(ev => ev.StatusId == 1).ToList();
            listEvent = listEvent.Where(ev => ev.EventPlanner.MediumRating >= RatingBar.Value).ToList();
            if (!string.IsNullOrEmpty(TBSearch.Text))
                listEvent = listEvent.Where(ev=>ev.SearchText.Contains(TBSearch.Text)).ToList();

            LVEvents.ItemsSource = listEvent;
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            RatingBar.Value = 0;
        }
    }
}
