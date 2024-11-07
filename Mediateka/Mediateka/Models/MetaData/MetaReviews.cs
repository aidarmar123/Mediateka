using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka.Models.MetaData
{
    public partial class MetaReviews
    {
        public int Id { get; set; }
        [Required]
        public string ContentMsg { get; set; }
        public int EvenPlannerId { get; set; }
        public int ExecutorId { get; set; }
        public int TypeMsgId { get; set; }
        [Required]
        public int Rating { get; set; }

        public virtual EventPlanner EventPlanner { get; set; }
        public virtual Executor Executor { get; set; }
        public virtual TypeMsg TypeMsg { get; set; }
    }
}
