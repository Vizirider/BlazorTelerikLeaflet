﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models;

namespace GridTest.Repository.IRepository;
public interface IProductRepository
{
    public Task<ProductDTO> Create(ProductDTO productDTO);
    public Task<ProductDTO> Update(ProductDTO productDTO);
    public Task<int> Delete(int id);
    public Task<ProductDTO> GetById(int id);
    public Task<IEnumerable<ProductDTO>> GetAll();
}
