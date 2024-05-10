using CustomerAppReview.Domain.Abstractions;
using CustomerAppReview.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAppReview.Domain.Services
{
    public class NotepadDbCustomerService : ICustomerService
    {
        private readonly string _dbPath;

        public NotepadDbCustomerService()
        {
            _dbPath = "C:\\Users\\Hakan\\Documents\\Projects\\CustomerAppReview\\CustomerAppReview.API\\TextDb.txt";
        }

        public void Add(AddCustomerDto addCustomerDto)
        {
            string data = $"{Guid.NewGuid()},{addCustomerDto.PhoneNumber},{addCustomerDto.Surname},{addCustomerDto.Name}";

            File.AppendAllText(_dbPath, data);
        }

        public List<CustomerListDto> List()
        {
            List<CustomerListDto> customerList = new();

            string rawData = File.ReadAllText(_dbPath);

            string[] lines = rawData.Split("\r\n");

            foreach (string line in lines)
            {
                string[] data = line.Split(",");

                var customerListDto = new CustomerListDto()
                {
                    Id = Guid.Parse(data[0]),
                    Surname = data[2],
                    Name = data[3],
                };

                customerList.Add(customerListDto);
            }

            return customerList;
        }
    }
}
