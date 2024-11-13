using Mediateka.Models;
using Mediateka.Service;
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
    /// Логика взаимодействия для RegestrationPage.xaml
    /// </summary>
    public partial class RegestrationPage : Page
    {
        EventPlanner contextEventPlanner;
        Executor contextExecutor;
        public RegestrationPage(Object user)
        {
            InitializeComponent();
            if (user.GetType() == typeof(EventPlanner))
            {
                contextEventPlanner = user as EventPlanner;
                DataContext = contextEventPlanner;
            }
            else if (user.GetType() == typeof(Executor))
            {
                SPSkillsExecutor.Visibility = Visibility.Visible;
                CCBSkils.ItemsSource = App.Db.Skill.ToList();
                contextExecutor = user as Executor;
                DataContext = contextExecutor;
            }


        }

        private void BAddImage_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog() { Filter = ".png, .jpg, .jpeg | *.png; *.jpg; *.jpeg" };
            if (openFileDialog.ShowDialog().GetValueOrDefault())
            {
                DataContext = null;
                if (contextEventPlanner != null)
                {
                    contextEventPlanner.Avatar = File.ReadAllBytes(openFileDialog.FileName);
                    DataContext = contextEventPlanner;
                }
                else if (contextExecutor != null)
                {
                    contextExecutor.Avatar = File.ReadAllBytes(openFileDialog.FileName);
                    DataContext = contextExecutor;
                }
            }
        }

        private void Regestr_Click(object sender, RoutedEventArgs e)
        {
            //Проверка на заполнение строк
            var error = new StringBuilder();
            if (contextEventPlanner != null)
                error = ValidationLine.ValidationObject(contextEventPlanner);
            else if (contextExecutor != null)
                error = ValidationLine.ValidationObject(contextExecutor);




            if (error.Length > 0)
            {
                Xceed.Wpf.Toolkit.MessageBox.Show(error.ToString());
            }
            else
            {
                bool isValid = false;
                if (contextEventPlanner != null)
                {
                    isValid = !IsReapetUser(contextEventPlanner.Email);
                    isValid =isValid && ValidationName(contextEventPlanner.Name, contextEventPlanner.Surname, contextEventPlanner.Patronymic);

                    if (isValid && contextEventPlanner.Id == 0)
                        App.Db.EventPlanner.Add(contextEventPlanner);
                }
                else if (contextExecutor != null)
                {

                    
                    isValid = !IsReapetUser(contextExecutor.Email);
                    isValid =isValid && ValidationName(contextExecutor.Name, contextExecutor.Surname, contextExecutor.Patronymic);
                    if (isValid && contextExecutor.Id == 0)
                        App.Db.Executor.Add(contextExecutor);
                }
                if (isValid)
                {
                    App.Db.SaveChanges();
                    if (contextExecutor != null)
                    {
                        foreach (Skill skill in CCBSkils.SelectedItems)
                        {
                            App.Db.ExecutorSkill.Add(new ExecutorSkill() { SkillId = skill.Id, ExecutorId = contextExecutor.Id });
                            App.Db.SaveChanges();
                        }
                    }

                    Xceed.Wpf.Toolkit.MessageBox.Show("Вы успешно зарегестрированы");
                    NavigationService.GoBack();
                }
                

            }
        }

        private bool IsReapetUser(string email)
        {
            var moderator = App.Db.Moderators.FirstOrDefault(x=>x.Login == email);
            var executor= App.Db.Executor.FirstOrDefault(x=>x.Email == email);
            var eventPlanner = App.Db.EventPlanner.FirstOrDefault(x=>x.Email == email);

            bool isReapet = moderator != null || executor != null || eventPlanner != null;
            if (isReapet)
                Xceed.Wpf.Toolkit.MessageBox.Show("Пользователь уже существует");
            
            return isReapet;
        }

        private bool ValidationName(string name, string surname, string patronymic)
        {
            bool isValidName = !name.Any(char.IsDigit) && !surname.Any(char.IsDigit) && !patronymic.Any(char.IsDigit);
            if(!isValidName)
                Xceed.Wpf.Toolkit.MessageBox.Show("В ФИО нельзя вводить цифры");

            return isValidName;

        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();

        }
    }
}
