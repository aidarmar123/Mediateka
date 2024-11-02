using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka.Models.MetaData
{
    public partial class MetaModerator
    {
        public int Id { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        public int RoleId { get; set; }
        [Required]
        public virtual Role Role { get; set; }
    }
}
