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



        public static MainWindow mainWindow;


        public static RoleUser SelectRoleReg;
        public static int selecRating;

        App()
        {
            RegestrDescriptor<Executor,MetaUser>();
            RegestrDescriptor<EventPlanner,MetaUser>();
            RegestrDescriptor<Moderators,MetaModerator>();
            RegestrDescriptor<Event,MetaEvent>();
            RegestrDescriptor<Reviews,MetaReviews>();


            ValidEvent();
        }
        //Метод прверяющий статус мероприятия завершено или нет
        private void ValidEvent()
        {
            foreach(var _event in Db.Event)
            {
                if (_event.DateTime < DateTime.Now)
                {
                    _event.StatusId = 4;
                    
                }
                if (_event.StatusEvent == null)
                    _event.StatusEvent = Db.StatusEvent.FirstOrDefault(x => x.Id == _event.Id);

                Db.SaveChangesAsync();
            }
        }

        private void RegestrDescriptor<T1, T2>()
        {
            var provider = new AssociatedMetadataTypeTypeDescriptionProvider(typeof(T1), typeof(T2));
            TypeDescriptor.AddProviderTransparent(provider,typeof(T1));
        }

        //Функция вызывающия при выходе из приложения и обнуляет всех пользователей
        public static void ExitFromApp()
        {
            contextExecutor = null;
            contextEventPlanner = null;
            contextModerator = null;
            SelectRoleReg = null;
            mainWindow.BAddUser.Visibility = Visibility.Collapsed;
        }
    }
}
