using Template.Application;

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
        throw new NotImplementedException();
    }

    public List<GetProductDto> GetAll(Paginition paginition)
    {
        throw new NotImplementedException();
    }
}
