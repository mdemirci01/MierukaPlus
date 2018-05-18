using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MierukaPlus.Models
{
    public class Machine
    {
        public int Id { get; set; }
        [Display(Name = "Machine Name")]
        public string Name { get; set; }
        public int UnitId { get; set; }
        [ForeignKey("UnitId")]
        public virtual Unit Unit { get; set; }
        public int ProcessId { get; set; }
        [ForeignKey("ProcessId")]
        public virtual Process Process { get; set; }
    }
}