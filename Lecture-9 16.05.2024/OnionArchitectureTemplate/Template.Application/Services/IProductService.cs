namespace Template.Application;

public interface IProductService
{
    void Add(AddProductDto addProductDto);
    void Update(Guid id, AddProductDto addProductDto);
    List<GetProductDto> GetAll(Paginition paginition);
}
