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

        private async void BSave_Click(object sender, RoutedEventArgs e)
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

                    var contextCurrency = await NetManager.Get<Currency>(BCurrency.Content.ToString());
                    contextEvent.Salary = contextEvent.Salary * contextCurrency.rates.FirstOrDefault(x => x.Key == "RUB").Value;

                    if (contextEvent.Id == 0)
                        App.Db.Event.Add(contextEvent);

                    App.Db.SaveChanges();
                    var listEventSkill = App.Db.EventSkill.Where(x => x.EventId == contextEvent.Id);
                    App.Db.EventSkill.RemoveRange(listEventSkill);
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

            if (contextEvent.Salary > 0)
            {
                var indexCurrency = listCurrency.IndexOf(BCurrency.Content.ToString());
                indexCurrency += 1;
                if (indexCurrency >= listCurrency.Count)
                    indexCurrency = 0;
                BCurrency.Content = listCurrency[indexCurrency];


                var contextCurrency = await NetManager.Get<Currency>(listCurrency[indexCurrency - 1 >= 0 ? indexCurrency - 1 : listCurrency.Count - 1]);
                contextEvent.Salary = contextEvent.Salary * contextCurrency.rates.FirstOrDefault(x => x.Key == BCurrency.Content.ToString()).Value;

                contextEvent.Salary = Math.Round(contextEvent.Salary, 2);
                DataContext = null;
                DataContext = contextEvent;


            }

        }
    }
}
