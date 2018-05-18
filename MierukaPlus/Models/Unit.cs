using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MierukaPlus.Models
{
    public class Unit
    {
        public Unit()
        {
            Processes = new HashSet<Process>();
            Machines = new HashSet<Machine>();
        }
        public int Id { get; set; }
        [Display(Name = "Unit Name")]
        public string Name { get; set; }
        public virtual ICollection<Process> Processes { get; set; }
        public virtual ICollection<Machine> Machines { get; set; }
    }
}