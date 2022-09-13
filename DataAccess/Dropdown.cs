using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess;
public class Dropdown
{
    [Key]
    public int ModeId { get; set; }
    public string ModeName { get; set; }
}
