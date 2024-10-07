using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Data;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Models;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Services;

public class ProductServices : IProductRepository
{
    private readonly ApplicationDbContext _context;
    public async Task Add(Product product)
    {
        await _context.Products.AddAsync(product);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> CheckExistence(int id)
    {
        return await _context.Products.AnyAsync(p => p.Id == id);
    }

    public async Task Delete(int id)
    {
        var product = await GetById(id);
        if (product != null)
        {
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Product>> GetAll()
    {
        return await _context.Products.ToListAsync();
    }

    public async Task<Product> GetById(int id)
    {
        return await _context.Products.FindAsync(id);
    }

    public async Task Update(Product product)
    {
        _context.Entry(product).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
}
