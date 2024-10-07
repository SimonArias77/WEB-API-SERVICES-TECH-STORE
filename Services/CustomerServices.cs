using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Data;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Models;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Services;

public class CustomerServices : ICustomerRepository
{
    private readonly ApplicationDbContext _context;
    public async Task Add(Customer customer)
    {
        await _context.Customers.AddAsync(customer);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> CheckExistence(int id)
    {
        return await _context.Customers.AnyAsync(c => c.Id == id);

    }

    public async Task Delete(int id)
    {
        var customer = await GetById(id);
        if (customer != null)
        {
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Customer>> GetAll()
    {
        return await _context.Customers.ToListAsync();

    }

    public async Task<Customer> GetById(int id)
    {
        return await _context.Customers.FindAsync(id);
    }

    public async Task Update(Customer customer)
    {
        _context.Entry(customer).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
}
