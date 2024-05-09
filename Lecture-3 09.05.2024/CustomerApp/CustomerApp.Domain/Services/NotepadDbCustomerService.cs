using CustomerApp.Domain.Abstractions;
using CustomerApp.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Domain.Services
{
    public class NotepadDbCustomerService : ICustomerService
    {
        private readonly string _filePath;

        public NotepadDbCustomerService()
        {
            _filePath = "C:\\Users\\Hakan\\Documents\\Projects\\CustomerApp\\CustomerApp.API\\TextDb.txt";
        }

        public void Create(CustomerCreateDto customerCreateDto)
        {
            string saveData = $"{Guid.NewGuid()},{customerCreateDto.Name},{customerCreateDto.Surname}";

            //guid-2,Melike,Aydın
            
            File.AppendAllText(_filePath, saveData);
        }

        public List<CustomerListDto> List()
        {
            List<CustomerListDto> list = new();

            string allText = File.ReadAllText(_filePath);

            string[] lines = allText.Split("\r\n");

            foreach (string line in lines)
            {
                //line = "guid-1,Hakan,Öztürk"
                var data = line.Split(",");

                CustomerListDto customerListDto = new()
                {
                    Id = Guid.Parse(data[0]),
                    Name = data[1],
                };

                list.Add(customerListDto);
            }

            return list;
        }
    }
}
