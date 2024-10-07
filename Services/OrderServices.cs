using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Data;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Models;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Services;

public class OrderServices : IOrderRepository
{
    private readonly ApplicationDbContext _context;
    public async Task Add(Order order)
    {
        await _context.Orders.AddAsync(order);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> CheckExistence(int id)
    {
        return await _context.Orders.AnyAsync(o => o.Id == id);
    }

    public async Task Delete(int id)
    {
        var order = await GetById(id);
        if (order != null)
        {
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Order>> GetAll()
    {
        return await _context.Orders.ToListAsync();
    }

    public async Task<Order> GetById(int id)
    {
        return await _context.Orders.FindAsync(id);
    }

    public async Task Update(Order order)
    {
        _context.Entry(order).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
}
