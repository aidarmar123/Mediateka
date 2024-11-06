using Mediateka.Models;
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
        public ListOrdersExecutors()
        {
            InitializeComponent();
            Refresh();
        }

        private void Refresh()
        {
            LVEvents.ItemsSource = App.Db.Event.Where(ev => ev.StatusId == 1).ToList();
            LVOrders.ItemsSource = App.Db.EventExecutor.Where(x=>x.ExecutorId == App.contextExecutor.Id && x.StatusExecutorId==1).ToList();
            
        }

        private void BResponse_Click(object sender, RoutedEventArgs e)
        {
            var contextEvent = (sender as Button).DataContext as Event;
            if (contextEvent != null)
            {
                //Проверяем отликнулься лт уже пользователь
                var repaetEventExecutor = App.Db.EventExecutor.FirstOrDefault(x => x.EventId == contextEvent.Id && x.ExecutorId == App.contextExecutor.Id);
                if (repaetEventExecutor != null)
                {
                    Xceed.Wpf.Toolkit.MessageBox.Show("Вы уже отликнулись");
                    return;
                }

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

        private void TBSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            var text = TBSearch.Text;
            if (string.IsNullOrEmpty(text))
            {
                Refresh();
            }
            else
            {
                LVEvents.ItemsSource = App.Db.Event.Where(ev => ev.StatusId ==1 && ev.Name.Contains(text)).ToList();
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
                var openFile = new OpenFileDialog();
                if (openFile.ShowDialog().GetValueOrDefault())
                {
                    var matrial = new MaterialEvent()
                    {
                        DateTimeSend = DateTime.Now,
                        NameFile = openFile.SafeFileName,
                        EventId = eventExecutor.EventId,
                        ExecutorId = eventExecutor.ExecutorId,
                        FormatFile = System.IO.Path.GetExtension(openFile.FileName),
                        Data = File.ReadAllBytes(openFile.FileName)
                    };
                    App.Db.MaterialEvent.Add(matrial);
                    App.Db.SaveChanges();
                    Refresh();
                }
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
    }
}
