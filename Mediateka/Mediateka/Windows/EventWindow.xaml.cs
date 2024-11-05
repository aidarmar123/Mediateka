﻿using Mediateka.Models;
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
using System.Windows.Shapes;

namespace Mediateka.Windows
{
    /// <summary>
    /// Логика взаимодействия для EventWindow.xaml
    /// </summary>
    public partial class EventWindow : Window
    {
        Event contextEvent;
        public EventWindow(Models.Event _event)
        {
            InitializeComponent();
            contextEvent = _event;
            DataContext = contextEvent;
        }

        private void BResponse_Click(object sender, RoutedEventArgs e)
        {
            if (contextEvent != null)
            {
                var eventExecutor = new EventExecutor()
                {
                    ExecutorId = App.contextExecutor.Id,
                    EventId = contextEvent.Id,
                    StatusExecutorId = 2
                };
                App.Db.EventExecutor.Add(eventExecutor);
                App.Db.SaveChanges();
            }
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}