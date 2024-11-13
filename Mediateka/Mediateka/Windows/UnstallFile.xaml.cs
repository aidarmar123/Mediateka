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
    /// Логика взаимодействия для UnstallFile.xaml
    /// </summary>
    public partial class UnstallFile : Window
    {
        EventExecutor contextEventExecutor;
        MaterialEvent contextMaterialEvent= new MaterialEvent();

        public UnstallFile(Models.EventExecutor eventExecutor)
        {
            InitializeComponent();
            contextEventExecutor = eventExecutor;
            DataContext = contextMaterialEvent;
        }

        private void BUnstall_Click(object sender, RoutedEventArgs e)
        {
            var openFile = new OpenFileDialog();
            if (openFile.ShowDialog().GetValueOrDefault())
            {
                contextMaterialEvent = new MaterialEvent()
                {
                    CommentFile = contextMaterialEvent.CommentFile,
                    DateTimeSend = DateTime.Now,
                    NameFile = openFile.SafeFileName,
                    EventId = contextEventExecutor.EventId,
                    ExecutorId = contextEventExecutor.ExecutorId,
                    FormatFile = System.IO.Path.GetExtension(openFile.FileName),
                    Data = File.ReadAllBytes(openFile.FileName)
                };
                DataContext = null;
                DataContext= contextMaterialEvent;

                
                

            }
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            if (contextMaterialEvent.Data == null)
            {
                Xceed.Wpf.Toolkit.MessageBox.Show("Файл не добавлен");
                return;
            }
            App.Db.MaterialEvent.Add(contextMaterialEvent);
            App.Db.SaveChanges();
            this.Close();
        }
    }
}
