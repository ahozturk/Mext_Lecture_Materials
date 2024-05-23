using Productify.Domain;
namespace Productify.Application;

public class GetProductDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsDeleted { get; set; }

    public GetProductDto()
    {
        
    }

    // public GetProductDto(Product product)
    // {
    //     Id = product.Id;
    //     Name = product.Name;
    //     Description = product.Description;
    //     IsDeleted = product.IsDeleted;
    // }

    // public static GetProductDto ConvertToDto(Product product)
    // {
    //     return new GetProductDto
    //     {
    //         Id = product.Id,
    //         Name = product.Name,
    //         Description = product.Description,
    //         IsDeleted = product.IsDeleted,
    //     };
    // }
}
