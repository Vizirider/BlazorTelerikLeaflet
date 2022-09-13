using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models;
public class DropdownDTO
{
    [Required(ErrorMessage = "Please enter id...")]
    public int ModeId { get; set; }
    [Required(ErrorMessage = "Please enter name...")]
    public string ModeName { get; set; }
}
