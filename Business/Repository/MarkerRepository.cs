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

namespace Business.Repository;
public class MarkerRepository : IMarkerRepository
{
    private readonly ApplicationDbContext _db;
    private readonly IMapper _mapper;

    public MarkerRepository(ApplicationDbContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task<IEnumerable<MarkerDTO>> GetAll()
    {
        return _mapper.Map<IEnumerable<Marker>, IEnumerable<MarkerDTO>>(_db.Markers);
    }
}
