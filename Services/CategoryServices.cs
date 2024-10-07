using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Data;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Models;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Services;

public class CategoryServices : ICategoryRepository
{
    private readonly ApplicationDbContext _context;

    public async Task Add(Category category)
    {
        await _context.Categories.AddAsync(category);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> CheckExistence(int id)
    {
        return await _context.Categories.AnyAsync(c => c.Id == id);
    }

    public async Task Delete(int id)
    {
        var category = await GetById(id);
        if (category != null)
        {
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Category>> GetAll()
    {
        return await _context.Categories.ToListAsync();
    }

    public async Task<Category> GetById(int id)
    {
        return await _context.Categories.FindAsync(id);
    }

    public async Task Update(Category category)
    {
        _context.Entry(category).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
}