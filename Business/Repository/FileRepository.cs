using BlazorInputFile;

using Business.Repository.IRepository;

using DataAccess;

using Microsoft.AspNetCore.Hosting;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository;
public class FileRepository : IFileRepository
{
    IHostingEnvironment _hostingEnvironment = null;
    public FileRepository(IHostingEnvironment hostingEnvironment)
    {
        _hostingEnvironment = hostingEnvironment;
    }
    public List<FileClass> GetAllPDFs()
    {
        List<FileClass> files = new();
        string path = $"{_hostingEnvironment.WebRootPath}\\files\\";
        int nFileId = 1;

        foreach(string pdfPath in Directory.EnumerateFiles(path, "*.pdf"))
        {
            files.Add(new FileClass()
            {
                FileId = nFileId++,
                Name = Path.GetFileName(pdfPath),
                Path = pdfPath
            });
        }
        return files;
    }

    public async Task Upload(IFileListEntry file)
    {
        var path = Path.Combine(_hostingEnvironment.WebRootPath, "files", file.Name);
        var memoryStream = new MemoryStream();

        await file.Data.CopyToAsync(memoryStream);

        using(FileStream fileStream = new(path, FileMode.Create, FileAccess.Write))
        {
            memoryStream.WriteTo(fileStream);
        }
    }

    public async Task Delete(string path)
    {
        if (File.Exists(Path.GetFullPath(path)))
        {
            File.Delete(Path.Combine(path));
        }
    }
}
