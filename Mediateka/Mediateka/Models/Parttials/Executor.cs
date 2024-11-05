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

        //public int Id { get; set; }
        //public string Name { get; set; }
        //public string Surname { get; set; }
        //public string Patronymic { get; set; }
        //public byte[] Avatar { get; set; }
        //public string Phone { get; set; }
        //public string Email { get; set; }
        //public string Password { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<EventExecutor> EventExecutor { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ExecutorSkill> ExecutorSkill { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<MaterialEvent> MaterialEvent { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Reviews> Reviews { get; set; }
    }
}
