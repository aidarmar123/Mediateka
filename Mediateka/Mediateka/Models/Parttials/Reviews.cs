using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka.Models
{
    public partial class Reviews
    {
        public Object SendMsg
        {
            get
            {
                if (TypeMsgId == 1)
                    return Executor;
                else if (TypeMsgId == 2)
                    return EventPlanner;
                return null;
            }
        }
    }
}
