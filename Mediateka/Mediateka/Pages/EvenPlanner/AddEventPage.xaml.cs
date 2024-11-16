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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mediateka.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddEventPage.xaml
    /// </summary>
    public partial class AddEventPage : Page
    {
        Event contextEvent;
        Dictionary<string, double> currencies;
        List<string> listCurrency = new List<string>() { "RUB", "USD", "EUR" };

        public AddEventPage(Event _event)
        {
            InitializeComponent();
            BCurrency.Content = listCurrency[0];
            CCBSkills.ItemsSource = App.Db.Skill.ToList();
            contextEvent = _event;
            DataContext = contextEvent;
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.GoBack();
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            var error = ValidationLine.ValidationObject(contextEvent);
            if (error.Length > 0)
            {
                Xceed.Wpf.Toolkit.MessageBox.Show(error.ToString(), "Поля не заполнены", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                var errorDate = new StringBuilder();
                if (contextEvent.DateTime < DateTime.Now)
                    errorDate.AppendLine("Дата проведения должна быть больше " + DateTime.Now.ToString("d"));

                if (contextEvent.Deadline < contextEvent.DateTime)
                    errorDate.AppendLine("Крайний срок должен быть больше Даты Проведения");

                if (errorDate.Length <= 0)
                {
                    contextEvent.StatusId = 3; // Statusid = 3 => на модерации
                    if (contextEvent.Id == 0)
                        App.Db.Event.Add(contextEvent);

                    App.Db.SaveChanges();
                    foreach (Skill skill in CCBSkills.SelectedItems)
                    {
                        App.Db.EventSkill.Add(new EventSkill() { SkillId = skill.Id, EventId = contextEvent.Id });
                        App.Db.SaveChanges();
                    }

                    NavigationService.GoBack();

                }
                else
                {
                    Xceed.Wpf.Toolkit.MessageBox.Show(errorDate.ToString());
                }

            }
        }

        private async void BCurrency_ClickAsync(object sender, RoutedEventArgs e)
        {
            //var currency = await NetManager.Get<Currency>("");

            //currencies = currency.rates;
             

            //var indexCurrency = listCurrency.IndexOf(BCurrency.Content.ToString());
            //indexCurrency += 1;
            //if (indexCurrency >= listCurrency.Count)
            //    indexCurrency = 0;


            //if (contextEvent.Salary > 0)
            //{
            //BCurrency.Content = listCurrency[indexCurrency];
            //    if (indexCurrency != 0)
            //    {
            //        contextEvent.Salary =(int)(contextEvent.Salary/ currencies.FirstOrDefault(x => x.Key == listCurrency[indexCurrency]).Value);
            //        DataContext = null;
            //        DataContext = contextEvent;
            //    }
                
                    
            //        contextEvent.Salary = (int)(contextEvent.Salary * currencies.FirstOrDefault(x => x.Key == BCurrency.Content.ToString()).Value);
            //        DataContext = null;
            //        DataContext = contextEvent;
                
               
            //}

        }
    }
}
