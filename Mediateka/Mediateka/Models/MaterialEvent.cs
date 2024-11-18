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
    
    public partial class MaterialEvent
    {
        public int Id { get; set; }
        public Nullable<int> EventId { get; set; }
        public System.DateTime DateTimeSend { get; set; }
        public int ExecutorId { get; set; }
        public byte[] Data { get; set; }
        public string FormatFile { get; set; }
        public string NameFile { get; set; }
        public string CommentFile { get; set; }
    
        public virtual Event Event { get; set; }
        public virtual Executor Executor { get; set; }
    }
}
