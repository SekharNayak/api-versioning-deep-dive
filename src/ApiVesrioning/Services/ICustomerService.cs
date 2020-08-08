using ApiVesrioning.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVesrioning.Services
{
    public interface ICustomerService
    {
        Task<Customer> GetCustomerByIdAsync(string id , bool addressDetails = true);
    }
}
