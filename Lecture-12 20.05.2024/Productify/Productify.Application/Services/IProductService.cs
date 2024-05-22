namespace Productify.Application;

public interface IProductService
{
    List<GetProductDto> GetAll(Paginition paginition);
    GetProductDto GetById(Guid id);
    void Add(AddProductDto addProductDto);
    void Update(UpdateProductDto addProductDto);
    void Delete(Guid id);
}
