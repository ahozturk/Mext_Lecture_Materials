using CustomerAppReview.Domain.DTOs;
using CustomerAppReview.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAppReview.Domain.Abstractions
{
    public interface ICustomerService
    {
        List<CustomerListDto> List();
        void Add(AddCustomerDto addCustomerDto);
    }
}
