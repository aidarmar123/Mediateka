using Mediateka.Models;
using Mediateka.Services;
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
        double salaryRUB;
        List<string> listCurrency = new List<string>() { "RUB", "USD", "EUR" };
        public EventWindow(Models.Event _event)
        {
            InitializeComponent();
            BCurrency.Content = listCurrency[0];
            contextEvent = _event;
            salaryRUB = contextEvent.Salary;
            DataContext = contextEvent;
        }

        private void BResponse_Click(object sender, RoutedEventArgs e)
        {
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
                this.Close();
            }
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BAddComment_Click(object sender, RoutedEventArgs e)
        {
            var review = new Reviews()
            {
                TypeMsgId = 1,
                EvenPlannerId = contextEvent.EventPlannerId,
                ExecutorId = App.contextExecutor.Id,
            };
            new AddReviews(review).ShowDialog();
            DataContext = null;
            DataContext = contextEvent;
        }
        private async void BCurrency_ClickAsync(object sender, RoutedEventArgs e)
        {

            if (contextEvent.Salary > 0)
            {
                var indexCurrency = listCurrency.IndexOf(BCurrency.Content.ToString());
                indexCurrency += 1;
                if (indexCurrency >= listCurrency.Count)
                    indexCurrency = 0;

                BCurrency.Content = listCurrency[indexCurrency];

                if (indexCurrency == 0)
                {
                    contextEvent.Salary = salaryRUB;
                }
                else
                {

                    var contextCurrency = await NetManager.Get<Currency>(listCurrency[indexCurrency - 1 >= 0 ? indexCurrency - 1 : listCurrency.Count - 1]);
                    contextEvent.Salary = contextEvent.Salary * contextCurrency.rates.FirstOrDefault(x => x.Key == BCurrency.Content.ToString()).Value * 0.9;
                }

                contextEvent.Salary = Math.Round(contextEvent.Salary, 2);
                DataContext = null;
                DataContext = contextEvent;


            }

        }
    }
}
