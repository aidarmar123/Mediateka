using Mediateka.Models;
using Mediateka.Models.MetaData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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


        App()
        {
            RegestrDescriptor<Executor,MetaUser>();
            RegestrDescriptor<EventPlanner,MetaUser>();
            RegestrDescriptor<Moderators,MetaModerator>();
        }

        private void RegestrDescriptor<T1, T2>()
        {
            var provider = new AssociatedMetadataTypeTypeDescriptionProvider(typeof(T1), typeof(T2));
            TypeDescriptor.AddProviderTransparent(provider,typeof(T1));
        }
    }
}
