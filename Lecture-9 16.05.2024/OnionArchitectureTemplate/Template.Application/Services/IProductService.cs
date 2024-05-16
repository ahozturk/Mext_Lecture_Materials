namespace Template.Application;

public interface IProductService
{
    void Add(AddProductDto addProductDto);
    List<GetProductDto> GetAll(Paginition paginition);
}
