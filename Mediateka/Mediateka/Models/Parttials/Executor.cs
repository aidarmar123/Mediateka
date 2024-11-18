using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka.Models
{
    public partial class Executor
    {
        public string FullName { get => $"{Name} {Surname} {Patronymic}"; }

        public double MediumRating
        {
            get
            {
                if(ReceivingReviews.Count > 0)
                    return ReceivingReviews.Select(x=>x.Rating).Sum()/ ReceivingReviews.Count;
                return 0;
            }
        }
        public List<Reviews> ReceivingReviews
        {
            get
            {
                return Reviews.Where(x=>x.TypeMsgId== 2).ToList();
            }
        }
    }
}
