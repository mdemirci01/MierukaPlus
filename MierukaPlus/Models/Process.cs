using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MierukaPlus.Models
{
    public class Process
    {
        public Process()
        {
            Units = new HashSet<Unit>();
            Machines = new HashSet<Machine>();
        }
        public int Id { get; set; }
        [Display(Name = "Process Name")]
        public string Name { get; set; }
        public virtual ICollection<Unit> Units { get; set; }
        public virtual ICollection<Machine> Machines { get; set; }
    }
}