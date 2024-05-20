namespace Productify.Application;

public interface ProductService
{
    List<GetProductDto> GetAll();
    void Add(AddProductDto addProductDto);
    void Update(Guid id, AddProductDto addProductDto);
    void Delete(Guid id);
}
