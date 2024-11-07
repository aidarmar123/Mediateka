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
    /// Логика взаимодействия для SelectRole.xaml
    /// </summary>
    public partial class SelectRole : Window
    {
        List<RoleUser> roles = new List<RoleUser>()
        {
            new RoleUser(){ Id=1, Name="Организатор"},
            new RoleUser(){ Id=2, Name="Исполнитель"},
            new RoleUser(){ Id=3, Name="Модератор/Администратор"},
        };
        public SelectRole()
        {
            InitializeComponent();
            CbRole.ItemsSource = roles;
        }

        private void BOk_Click(object sender, RoutedEventArgs e)
        {
            if(CbRole.SelectedItem is  RoleUser role)
            {
                App.SelectRoleReg = role;
                this.Close();
            }
            else
            {
                Xceed.Wpf.Toolkit.MessageBox.Show("Выберете роль");
            }
        }

       
    }
}
