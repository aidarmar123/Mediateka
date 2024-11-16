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
    /// Логика взаимодействия для AddCommentToExecutor.xaml
    /// </summary>
    public partial class AddCommentToExecutor : Window
    {
        EventExecutor contextEventExecutor;
        public AddCommentToExecutor(Models.EventExecutor eventExecutor)
        {
            InitializeComponent();
            contextEventExecutor = eventExecutor;
            DataContext = contextEventExecutor;
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            App.Db.SaveChanges();
            this.Close();
        }
    }
}
