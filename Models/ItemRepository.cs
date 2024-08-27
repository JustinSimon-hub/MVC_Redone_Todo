using System.Collections.Generic;
using System.Data;
namespace Testing.Models
{
    public class ItemRepository : IItemRepository
    {
        private readonly IDbConnection _connection;

        public ItemRepository(IDbConnection connection)
        {
                _connection = connection;
        }

       
    }
}