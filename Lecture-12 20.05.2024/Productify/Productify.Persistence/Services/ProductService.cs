﻿using Productify.Application;
using Productify.Domain;

namespace Productify.Persistence;

public class ProductService : IProductService
{
    private readonly ProductifyDbContext _context;

    public ProductService(ProductifyDbContext context)
    {
        _context = context;
    }

    public void Add(AddProductDto addProductDto)
    {
        var product = new Product
        {
            Name = addProductDto.Name,
            Description = addProductDto.Description,
        };

        _context.Products.Add(product);

        _context.SaveChanges();
    }

    public void Delete(Guid id)
    {
        var product = _context.Products.FirstOrDefault(x => x.Id == id);

        if (product is null)
            throw new Exception("Product not found");

        _context.Products.Remove(product);

        _context.SaveChanges();
    }

    public List<GetProductDto> GetAll()
    {
        var products = _context.Products.Select(x => new GetProductDto
        {
            Id = x.Id,
            Name = x.Name,
            Description = x.Description,
            IsDeleted = x.IsDeleted,
        }).ToList();

        return products;
    }

    public void Update(Guid id, UpdateProductDto addProductDto)
    {
        var product = _context.Products.FirstOrDefault(x => x.Id == id);

        if (product is null)
            throw new Exception("Product not found");

        product.Name = addProductDto.Name;
        product.Description = addProductDto.Description;

        _context.SaveChanges();
    }
}
