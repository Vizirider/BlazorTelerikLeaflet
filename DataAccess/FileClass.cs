using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess;
public class FileClass
{
    public int FileId { get; set; } = 0;
    public string Name { get; set; } = "";
    public string Path { get; set; } = "";
    public List<FileClass> Files { get; set; } = new List<FileClass>();
}
