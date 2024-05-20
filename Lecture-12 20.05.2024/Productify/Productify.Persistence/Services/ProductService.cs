using Productify.Application;

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
        throw new NotImplementedException();
    }

    public void Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    public List<GetProductDto> GetAll()
    {
        throw new NotImplementedException();
    }

    public void Update(Guid id, UpdateProductDto addProductDto)
    {
        throw new NotImplementedException();
    }
}
