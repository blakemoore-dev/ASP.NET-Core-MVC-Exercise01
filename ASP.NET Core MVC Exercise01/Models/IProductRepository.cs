using System.Collections.Generic;
using System.Data;

namespace ASP.NET_Core_MVC_Exercise01.Models
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
    }
}
