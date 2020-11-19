using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PO7.Models
{
    public class Gun
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Nazwa")]
        [Required(ErrorMessage = "Podaj nazwę broni")]
        public string name { get; set; }

        [Display(Name = "Kaliber")]
        [Required(ErrorMessage = "Podaj kaliber broni")]
        public string caliber { get; set; }

        [Display(Name = "Długość lufy w calach")]
        [Required(ErrorMessage = "Podaj długość lufy")]
        public string size { get; set; }

        [Display(Name = "Waga w gramach")]
        [Required(ErrorMessage = "Podaj wagę")]
        public  string weight { get; set; }
        public virtual List<ShootingResult> shootings { get; set; }
    }
}
