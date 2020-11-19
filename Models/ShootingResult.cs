using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PO7.Models
{
    public class ShootingResult
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Wybierz broń")]
        [Display(Name = "Broń")]
        public int gunId { get; set; }
        [Required(ErrorMessage = "Podaj dystans")]
        [Display(Name = "Dystans")]
        public int distance { get; set; }
        [Display(Name = "Ilość strzałów")]
        [Required(ErrorMessage = "Podaj ilość strzałów")]
        public int shots { get; set; }
        [Display(Name = "Ilość zdobytych punktów")]
        [Required(ErrorMessage = "Podaj ilość zdobytych punktów")]
        public int points { get; set; }
        public virtual Gun gun { get; set; }
    }
}
