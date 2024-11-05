using Mediateka.Models;
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
using System.Windows.Shapes;

namespace Mediateka.Windows
{
    /// <summary>
    /// Логика взаимодействия для ExecutorProfile.xaml
    /// </summary>
    public partial class ExecutorProfile : Window
    {
        Executor contextExecutor;
        Event contextEvent;
        public ExecutorProfile(Executor executor, Event _event)
        {
            InitializeComponent();
            contextExecutor = executor;
            contextEvent = _event;
            DataContext = contextExecutor;
        }

        private void BInstall_Click(object sender, RoutedEventArgs e)
        {
            var material = (sender as Button).DataContext as MaterialEvent;
            if (material != null)
            {
                var saveFile = new SaveFileDialog() { Filter = $".{material.FormatFile} | *.{material.FormatFile};"};
                if (saveFile.ShowDialog().GetValueOrDefault())
                {
                    var file=File.Create(saveFile.FileName);
                    file.Close();
                    File.WriteAllBytes(saveFile.FileName,material.Data);
                }
            }
        }

        private void BHire_Click(object sender, RoutedEventArgs e)
        {
            var eventExecutor = App.Db.EventExecutor.FirstOrDefault(x => x.EventId == contextEvent.Id && x.ExecutorId == contextExecutor.Id);
            if (eventExecutor != null)
            {
                eventExecutor.StatusExecutorId = 1;
                App.Db.SaveChanges();
                this.Close();
            }
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
