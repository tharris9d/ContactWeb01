using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactWeb01.Models
{
    public class State
    {
        [Key]
        public int id { get; set; }

        [Display(Name="State")]
        [Required(ErrorMessage = "State Name is required") ]
        [StringLength(ContactWebConstants.MAX_STATE_NAME_LENGTH)]
        public string Name { get; set; }
        [Required(ErrorMessage = "State Abbreviation is required")]
        [StringLength(ContactWebConstants.MAX_STATE_ABBR_LENGTH)]
        public string Abbreviation { get; set; }
    }
}
