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
                if (contextEventPlanner != null)
                {
                    if (contextEventPlanner.Id == 0)
                        App.Db.EventPlanner.Add(contextEventPlanner);
                }
                else if (contextExecutor != null)
                {
                    if (contextExecutor.Id == 0)
                        App.Db.Executor.Add(contextExecutor);
                }
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

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();

        }
    }
}
