namespace Productify.Application;

public interface IProductService
{
    List<GetProductDto> GetAll();
    void Add(AddProductDto addProductDto);
    void Update(Guid id, UpdateProductDto addProductDto);
    void Delete(Guid id);
}
