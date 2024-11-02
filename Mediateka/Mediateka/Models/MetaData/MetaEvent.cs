using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka.Models.MetaData
{
    public partial class MetaEvent
    {
        

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public System.DateTime DateTime { get; set; }
        [Required]
        public System.DateTime Deadline { get; set; }
        [Required]
        public string City { get; set; }
        public int StatusId { get; set; }
        public int EventPlannerId { get; set; }
        public string CommentModerator { get; set; }
        [Required]
        public int Salary { get; set; }

        public virtual EventPlanner EventPlanner { get; set; }
        public virtual StatusEvent StatusEvent { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventExecutor> EventExecutor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventSkill> EventSkill { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialEvent> MaterialEvent { get; set; }
    }
}
