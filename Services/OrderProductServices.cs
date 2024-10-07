using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Data;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Models;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Services;

public class OrderProductServices : IOrderProductRepository
{
    private readonly ApplicationDbContext _context;
    public async Task Add(OrderProduct orderProduct)
    {
        await _context.OrderProducts.AddAsync(orderProduct);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> CheckExistence(int id)
    {
        return await _context.OrderProducts.AnyAsync(o => o.Id == id);
    }

    public async Task Delete(int id)
    {
        var orderProduct = await GetById(id);
        if (orderProduct != null)
        {
            _context.OrderProducts.Remove(orderProduct);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<OrderProduct>> GetAll()
    {
        return await _context.OrderProducts.ToListAsync();
    }

    public async Task<OrderProduct> GetById(int id)
    {
        return await _context.OrderProducts.FindAsync(id);
    }

    public async Task Update(OrderProduct orderProduct)
    {
        _context.Entry(orderProduct).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
}
