//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mediateka.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExecutorSkill
    {
        public int Id { get; set; }
        public int SkillId { get; set; }
        public int ExecutorId { get; set; }
    
        public virtual Executor Executor { get; set; }
        public virtual Skill Skill { get; set; }
    }
}
