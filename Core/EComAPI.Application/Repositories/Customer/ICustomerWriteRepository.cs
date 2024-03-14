using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity = EComAPI.Domain.Entities;

namespace EComAPI.Application.Repositories.Customer;

public interface ICustomerWriteRepository : IWriteRepository<Entity.Customer>
{
    
}
