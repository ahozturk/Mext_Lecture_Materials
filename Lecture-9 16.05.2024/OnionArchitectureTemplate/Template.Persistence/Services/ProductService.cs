using Template.Application;
using Template.Domain;

namespace Template.Persistence;

public class ProductService : IProductService
{
    private readonly AppDbContext _context;

    public ProductService(AppDbContext context)
    {
        _context = context;
    }

    public void Add(AddProductDto addProductDto)
    {
        _context.Products.Add(new Product
        {
            Title = addProductDto.Title,
            Price = addProductDto.Price
        });

        _context.SaveChanges();
    }

    public List<GetProductDto> GetAll(Paginition paginition)
    {
        return _context.Products.Select(x => new GetProductDto
        {
            Title = x.Title,
        })
        .Skip(paginition.PageCount * paginition.PageSize)
        .Take(paginition.PageSize)
        .ToList();
    }

    public void Update(Guid id, AddProductDto addProductDto)
    {
        var product = _context.Products.FirstOrDefault(x => x.Id == id);

        product.Title = addProductDto.Title;
        product.Price = addProductDto.Price;

        _context.SaveChanges();
    }
}
