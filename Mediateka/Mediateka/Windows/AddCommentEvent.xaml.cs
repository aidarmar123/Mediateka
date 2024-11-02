using Mediateka.Models;
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
    /// Логика взаимодействия для AddCommentEvent.xaml
    /// </summary>
    public partial class AddCommentEvent : Window
    {
        Event contextEvent;
        public AddCommentEvent(Event _event)
        {
            InitializeComponent();
            contextEvent = _event;
            DataContext = contextEvent;
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(contextEvent.CommentModerator))
            {
                App.Db.SaveChanges();
                this.Close();
            }
            else
            {
                Xceed.Wpf.Toolkit.MessageBox.Show("Комментарий пустой");
            }
        }
    }
}
