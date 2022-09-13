using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models;
public class MarkerDTO
{
    [Required(ErrorMessage = "Please enter id...")]
    public int Id { get; set; }
    [Required(ErrorMessage = "Please enter latitude...")]
    public double Latitude { get; set; }
    [Required(ErrorMessage = "Please enter longitude...")]
    public double Longitude { get; set; }
    [Required(ErrorMessage = "Please enter address...")]
    public string Address { get; set; }
    public int Population { get; set; }
}
