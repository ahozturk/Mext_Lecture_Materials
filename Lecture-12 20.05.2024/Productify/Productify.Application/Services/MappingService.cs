using Productify.Domain;

namespace Productify.Application;

public static class MappingService
{
    public static GetProductDto ConvertToGetProductDto(Product product)
    {
        return new GetProductDto
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            IsDeleted = product.IsDeleted,
        };
    }

    public static Product ConvertToProduct(GetProductDto addProductDto)
    {
        return new Product
        {
            Id = addProductDto.Id,
            Name = addProductDto.Name,
            Description = addProductDto.Description,
            IsDeleted = addProductDto.IsDeleted,
        };
    }
}
