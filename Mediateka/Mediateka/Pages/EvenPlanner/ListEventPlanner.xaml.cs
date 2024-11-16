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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mediateka.Pages
{
    /// <summary>
    /// Логика взаимодействия для ListEventPlanner.xaml
    /// </summary>
    public partial class ListEventPlanner : Page
    {
        public ListEventPlanner()
        {
            InitializeComponent();
            Refresh();
        }

        private void Refresh()
        {
            var list  = App.Db.Event.Where(ev => ev.EventPlannerId == App.contextEventPlanner.Id).ToList();
            
            LVEvents.ItemsSource = list;
            LVLastEvents.ItemsSource = list.Where(x=>x.StatusId ==4).ToList();
        }

        private void BAddEvent_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEventPage(new Models.Event() { EventPlannerId=App.contextEventPlanner.Id}));
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
                LVEvents.ItemsSource = App.Db.Event.Where(ev => ev.EventPlannerId == App.contextEventPlanner.Id && ev.Name.Contains(text)).ToList();
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void BEdit_Click(object sender, RoutedEventArgs e)
        {
            if(LVEvents.SelectedItem is Event _event)
            {
                NavigationService.Navigate(new AddEventPage(_event));
            }
        }

        private void LVEvents_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void DGExecutors_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var executor = ((sender as DataGrid).SelectedItem as EventExecutor).Executor;
            var contextEvent = (sender as DataGrid).DataContext as Event; 

            if(executor != null && contextEvent!=null)
            {
                new ExecutorProfile(executor, contextEvent).ShowDialog(); 
            }
        }

        private void BHire_Click(object sender, RoutedEventArgs e)
        {
            var eventExecutor = (sender as Button).DataContext as EventExecutor;
            if (eventExecutor != null)
            {
                if(eventExecutor.StatusExecutorId == 1)
                {
                    Xceed.Wpf.Toolkit.MessageBox.Show("Исполнитель уже принят");
                    return;
                }
                eventExecutor.StatusExecutorId = 1;
                App.Db.SaveChanges();
                Refresh();
            }
        }

        private void BRefusal_Click(object sender, RoutedEventArgs e)
        {
            var eventExecutor = (sender as Button).DataContext as EventExecutor;
            if (eventExecutor != null)
            {
                if (eventExecutor.StatusExecutorId == 3)
                {
                    Xceed.Wpf.Toolkit.MessageBox.Show("Исполнителю уже отказано");
                    return;
                }

                eventExecutor.StatusExecutorId = 3;
                new AddCommentToExecutor(eventExecutor).ShowDialog();
                App.Db.SaveChanges();
                Refresh();
            }
        }

        private void BInstall_Click(object sender, RoutedEventArgs e)
        {
            var material = (sender as Hyperlink).DataContext as MaterialEvent;
            if (material != null)
            {
                var saveFile = new SaveFileDialog() { Filter = $".{material.FormatFile} | *.{material.FormatFile};" };
                if (saveFile.ShowDialog().GetValueOrDefault())
                {
                    var file = File.Create(saveFile.FileName);
                    file.Close();
                    File.WriteAllBytes(saveFile.FileName, material.Data);
                }
            }
        }

        private void TBSearchLast_TextChanged(object sender, TextChangedEventArgs e)
        {
            var text = TBSearchLast.Text;
            if (string.IsNullOrEmpty(text))
            {
                Refresh();
            }
            else
            {
                LVLastEvents.ItemsSource = App.Db.Event.Where(ev => ev.EventPlannerId == App.contextEventPlanner.Id && ev.Name.Contains(text) && ev.StatusId==4).ToList();
            }
        }
    }
}
