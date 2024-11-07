using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Mediateka.Models
{
    public partial class Event
    {
        public SolidColorBrush IsResponse
        {
            get
            {
                if(App.contextExecutor != null)
                {
                    var ev = EventExecutor.FirstOrDefault(x => x.ExecutorId == App.contextExecutor.Id);
                    if(ev != null)
                    {
                        //Проверка если принят
                        if (ev.StatusExecutorId ==1)
                            return Brushes.LightGreen;

                        //Проверка если не принят
                        if(ev.StatusExecutorId ==3)
                            return Brushes.LightPink;

                        return Brushes.LightGray;
                    }
                }
                 
                return  null;
            }
        }

        public List<EventExecutor> HitEventExecutor
        {
            get
            {
                return EventExecutor.Where(x=>x.StatusExecutorId==1).ToList();
            }
        }
    }
}
