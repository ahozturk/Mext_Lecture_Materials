using Productify.Domain;

namespace Productify.Application;

public static class MappingService
{
    public static GetProductDto ConvertToGetProductDto(Product product)
    {
        if (product is null)
            return null;

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
        if (addProductDto is null)
            return null;

        return new Product
        {
            Id = addProductDto.Id,
            Name = addProductDto.Name,
            Description = addProductDto.Description,
            IsDeleted = addProductDto.IsDeleted,
        };
    }
}
