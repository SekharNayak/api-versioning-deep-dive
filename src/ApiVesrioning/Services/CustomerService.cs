using ApiVesrioning.DTOs;
using System.Threading.Tasks;
using AutoFixture;
using System.Linq;

namespace ApiVesrioning.Services
{
    public class CustomerService : ICustomerService
    {
        
        public Task<Customer> GetCustomerByIdAsync(string id , bool addressDetails = true)
        {
            return Task.FromResult(BuildCustomer(id , addressDetails));
        }


        private Customer BuildCustomer(string id , bool addressDetails = true)
        {
            var customer = new Fixture()
                .Build<Customer>()
                .With(_ => _.Id , id)
                .With(_ => _.Email , "someone@example.com")
                .With(_ => _.Addresses, (addressDetails) ? (new Fixture().CreateMany<Address>()).ToArray() : null)
                .Create();

            return customer;
        }
    }
}
