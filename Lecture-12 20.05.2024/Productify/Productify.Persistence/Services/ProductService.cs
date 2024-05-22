using Productify.Application;
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

        var entityState1 = _context.Entry(product).State;

        _context.Products.Add(product);

        var entityState2 = _context.Entry(product).State;

        _context.SaveChanges();

        var entityState3 = _context.Entry(product).State;

    }

    public void Delete(Guid id)
    {
        var product = _context.Products.FirstOrDefault(x => x.Id == id);

        if (product is null)
            throw new Exception("Product not found");

        _context.Products.Remove(product);

        _context.SaveChanges();
    }

    public List<GetProductDto> GetAll(Paginition paginition)
    {
        var products = _context.Products.Select(x => new GetProductDto
        {
            Id = x.Id,
            Name = x.Name,
            Description = x.Description,
            IsDeleted = x.IsDeleted,
        })
        .ToList() //Buraya dikkat (IQueryable - IEnumerable)
        .Skip(paginition.PageSize * paginition.PageCount)
        .Take(paginition.PageSize);

        return products;
    }

    public GetProductDto GetById(Guid id)
    {
        return _context.Products
            .Select(x => new GetProductDto
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                IsDeleted = x.IsDeleted,
            })
            .FirstOrDefault(x => x.Id == id)!;
    }

    public void Update(UpdateProductDto updateProductDto)
    {
        var product = _context.Products.FirstOrDefault(x => x.Id == updateProductDto.Id);

        if (product is null)
            throw new Exception("Product not found");

        product.Name = updateProductDto.Name;
        product.Description = updateProductDto.Description;

        _context.SaveChanges();
    }
}
