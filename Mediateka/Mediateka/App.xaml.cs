using Mediateka.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Mediateka
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static MediatekaEntities Db = new MediatekaEntities();

        public static Executor contextExecutor;
        public static EventPlanner contextEventPlanner;
        public static Moderators contextModerator;
    }
}
