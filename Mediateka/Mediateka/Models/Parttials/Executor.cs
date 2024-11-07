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

        public int MediumRating
        {
            get
            {
                return Reviews.Select(x=>x.Rating).Sum()/Reviews.Count;
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
