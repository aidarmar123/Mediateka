using Mediateka.Models;
using Mediateka.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        public AddReviews(Reviews reviews)
        {
            InitializeComponent();
            contextReview = reviews;
            DataContext = contextReview;
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            contextReview.Rating = (int)RBRating.Value;
            var error = ValidationLine.ValidationObject(contextReview);
            if (error.Length > 0)
            {
                Xceed.Wpf.Toolkit.MessageBox.Show(error.ToString());
            }
            else
            {
                bool isValid = true;

                //ThreadStart start = () =>
                //                {

                //Thread thread = new Thread(start);
                //thread.Start();

                //thread.Join();
                foreach (var word in App.Db.SwearWords.Select(w => w.Name))
                {
                    if (contextReview.ContentMsg.Contains(word))
                    {
                        MessageBox.Show("Не цензурная лексика");
                        isValid = false;
                        break;
                    }
                }

            
            if (isValid)
            {

                App.Db.Reviews.Add(contextReview);
                App.Db.SaveChanges();
                this.Close();
            }
        }
    }
}
}
