using AutoMapper;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess;
using DataAccess.ViewModel;

using Models;

namespace Business.Mapper;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Category, CategoryDTO>().ReverseMap();
        CreateMap<Product, ProductDTO>().ReverseMap();
        CreateMap<ProductPrice, ProductPriceDTO>().ReverseMap();
        CreateMap<OrderHeaderDTO, OrderHeader>().ReverseMap();
        CreateMap<OrderDetail, OrderDetailDTO>().ReverseMap();
        CreateMap<OrderDTO, Order>().ReverseMap();
        CreateMap<Dropdown, DropdownDTO>().ReverseMap();
        CreateMap<Marker, MarkerDTO>().ReverseMap();
    }
}
