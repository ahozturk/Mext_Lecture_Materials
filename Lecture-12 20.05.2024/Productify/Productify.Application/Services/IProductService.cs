namespace Productify.Application;

public interface IProductService
{
    List<GetProductDto> GetAll();
    GetProductDto GetById(Guid id);
    void Add(AddProductDto addProductDto);
    void Update(UpdateProductDto addProductDto);
    void Delete(Guid id);
}
