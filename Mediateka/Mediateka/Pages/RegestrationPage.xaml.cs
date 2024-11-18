using Mediateka.Models;
using Mediateka.Services;
using Mediateka.Windows;
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
        string startEmail;


        public RegestrationPage(EventPlanner user)
        {
            InitializeComponent();

            contextEventPlanner = user;
            startEmail = user.Email;
            DataContext = contextEventPlanner;


        }
        public RegestrationPage(Executor user)
        {
            InitializeComponent();

            SPSkillsExecutor.Visibility = Visibility.Visible;
            CCBSkils.ItemsSource = App.Db.Skill.ToList();
            contextExecutor = user;
            startEmail = user.Email;
            DataContext = contextExecutor;

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
                bool isValid = true;
                if (contextEventPlanner != null)
                {
                    if (startEmail != contextEventPlanner.Email)
                        isValid = !IsReapetUser(contextEventPlanner.Email);

                    isValid = isValid && ValidationUser(contextEventPlanner.Name, contextEventPlanner.Surname, contextEventPlanner.Patronymic, contextEventPlanner.Phone, contextEventPlanner.Email);

                    if (isValid && contextEventPlanner.Id == 0)
                        App.Db.EventPlanner.Add(contextEventPlanner);
                }
                else if (contextExecutor != null)
                {
                    if (startEmail != contextExecutor.Email)
                        isValid = !IsReapetUser(contextExecutor.Email);
                    isValid = isValid && ValidationUser(contextExecutor.Name, contextExecutor.Surname, contextExecutor.Patronymic, contextExecutor.Phone, contextExecutor.Email);

                    if (isValid && contextExecutor.Id == 0)
                        App.Db.Executor.Add(contextExecutor);
                }
                if (isValid)
                {
                    App.Db.SaveChanges();
                    App.mainWindow.Refresh();
                    if (contextExecutor != null)
                    {
                        foreach (Skill skill in CCBSkils.SelectedItems)
                        {
                            App.Db.ExecutorSkill.Add(new ExecutorSkill() { SkillId = skill.Id, ExecutorId = contextExecutor.Id });
                            App.Db.SaveChanges();
                        }
                    }

                    Xceed.Wpf.Toolkit.MessageBox.Show("Данные успешно сохранены");
                    NavigationService.GoBack();
                }


            }
        }


        private bool IsReapetUser(string email)
        {
            var moderator = App.Db.Moderators.FirstOrDefault(x => x.Login == email);
            var executor = App.Db.Executor.FirstOrDefault(x => x.Email == email);
            var eventPlanner = App.Db.EventPlanner.FirstOrDefault(x => x.Email == email);

            bool isReapet = moderator != null || executor != null || eventPlanner != null;
            if (isReapet)
                Xceed.Wpf.Toolkit.MessageBox.Show("Пользователь уже существует");

            return isReapet;
        }

        private bool ValidationUser(string name, string surname, string patronymic, string phone, string email)
        {
            bool isValidName = !name.Any(char.IsDigit) && !surname.Any(char.IsDigit) && !patronymic.Any(char.IsDigit);


            if (!isValidName)
                Xceed.Wpf.Toolkit.MessageBox.Show("В ФИО нельзя вводить цифры");

            bool isValidNumber = phone.Any(char.IsDigit) && phone.Length == 11;
            if (!isValidNumber)
                Xceed.Wpf.Toolkit.MessageBox.Show("Телефон должен состоять из 11 цифр");

            bool isValidEmail = email.Contains("@") && email.Contains(".");
            if (!isValidEmail)
                Xceed.Wpf.Toolkit.MessageBox.Show("Email не действителен");

            return isValidName && isValidNumber && isValidEmail;

        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();

        }

        private void BAddFile_Click(object sender, RoutedEventArgs e)
        {

            new UnstallFile(null, contextExecutor).ShowDialog();
            DataContext = null;
            DataContext = contextExecutor;
        }

        private void BDeleteFile_Click(object sender, RoutedEventArgs e)
        {
            if (LBPortfolio.SelectedItem is MaterialEvent material)
            {
                App.Db.MaterialEvent.Remove(material);
                App.Db.SaveChanges();
                DataContext = null;
                DataContext = contextExecutor;
            }
        }

        private void BInstallile_Click(object sender, RoutedEventArgs e)
        {
            if (LBPortfolio.SelectedItem is MaterialEvent material)
            {
                var saveFile = new SaveFileDialog() { Filter = $".{material.FormatFile} | *.{material.FormatFile};" };
                if (saveFile.ShowDialog().GetValueOrDefault())
                {
                    var file = File.Create(saveFile.FileName);
                    file.Close();
                    File.WriteAllBytes(saveFile.FileName, material.Data);
                }
            }
        }
    }
}
