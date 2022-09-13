﻿using AutoMapper;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GridTest.Repository.IRepository;

using DataAccess;
using DataAccess.Data;

using Models;

namespace Business.Repository;
public class CategoryRepository : ICategoryRepository
{
    private readonly ApplicationDbContext _db;
    private readonly IMapper _mapper;

    public CategoryRepository(ApplicationDbContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }
    public async Task<CategoryDTO> Create(CategoryDTO categoryDTO)
    {
        var category = _mapper.Map<CategoryDTO, Category>(categoryDTO);
        category.CreatedDate = DateTime.Now;

        var addedCategory = _db.Categories.Add(category);
        await _db.SaveChangesAsync();

        return _mapper.Map<Category, CategoryDTO>(addedCategory.Entity);
    }

    public async Task<int> Delete(int id)
    {
        var category = await _db.Categories.FirstOrDefaultAsync(x => x.Id == id);
        if(category != null)
        {
            _db.Categories.Remove(category);
            return await _db.SaveChangesAsync();
        }
        return 0;
    }

    public async Task<IEnumerable<CategoryDTO>> GetAll()
    {
        return _mapper.Map<IEnumerable<Category>, IEnumerable<CategoryDTO>>(_db.Categories);
    }

    public async Task<CategoryDTO> GetById(int id)
    {
        var category = await _db.Categories.FirstOrDefaultAsync(x => x.Id == id);
        if (category != null)
        {
            return _mapper.Map<Category, CategoryDTO>(category);
        }
        return new CategoryDTO();
    }

    public async Task<CategoryDTO> Update(CategoryDTO categoryDTO)
    {
        var category = await _db.Categories.FirstOrDefaultAsync(x => x.Id == categoryDTO.Id);
        if(category != null)
        {
            category.Name = categoryDTO.Name;
            _db.Categories.Update(category);
            _db.SaveChanges();
            return _mapper.Map<Category, CategoryDTO>(category);
        }
        return categoryDTO;
    }

    public async Task<IEnumerable<CategoryDTO>> GetProductCategories()
    {
        return (IEnumerable<CategoryDTO>)_mapper.Map<IEnumerable<Product>, IEnumerable<ProductDTO>>(_db.Products.Include(x => x.Category));
    }
}
