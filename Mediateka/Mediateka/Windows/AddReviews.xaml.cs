using Mediateka.Models;
using Mediateka.Service;
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
    /// Логика взаимодействия для AddReviews.xaml
    /// </summary>
    public partial class AddReviews : Window
    {

        Reviews contextReview;
  
        public AddReviews(Executor executor)
        {
            InitializeComponent();
            contextReview = new Reviews()
            {
                TypeMsgId = 2,
                EvenPlannerId = App.contextEventPlanner.Id,
                ExecutorId = executor.Id,
            };
           
            DataContext = contextReview;
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            contextReview.Rating =(int)RBRating.Value;
            var error = ValidationLine.ValidationObject(contextReview);
            if (error.Length > 0)
            {
                Xceed.Wpf.Toolkit.MessageBox.Show(error.ToString());
            }
            else
            {
                App.Db.Reviews.Add(contextReview);
                App.Db.SaveChanges();
                this.Close();
            }
        }
    }
}
