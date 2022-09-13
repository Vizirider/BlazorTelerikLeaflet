using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models;

namespace GridTest.Repository.IRepository;
public interface IProductPriceRepository
{
    public Task<ProductPriceDTO> Create(ProductPriceDTO productPriceDTO);
    public Task<ProductPriceDTO> Update(ProductPriceDTO productPriceDTO);
    public Task<int> Delete(int id);
    public Task<ProductPriceDTO> GetById(int id);
    public Task<IEnumerable<ProductPriceDTO>> GetAll(int? id=null);
}
