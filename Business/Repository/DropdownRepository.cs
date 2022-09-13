using AutoMapper;
using DataAccess.Data;
using DataAccess;
using Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Repository.IRepository;

namespace GridTest.Repository;
public class DropdownRepository : IDropdownRepository
{
    private readonly ApplicationDbContext _db;
    private readonly IMapper _mapper;

    public DropdownRepository(ApplicationDbContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }
    public async Task<IEnumerable<DropdownDTO>> GetAll()
    {
        return _mapper.Map<IEnumerable<Dropdown>, IEnumerable<DropdownDTO>>(_db.Dropdowns);
    }
}
