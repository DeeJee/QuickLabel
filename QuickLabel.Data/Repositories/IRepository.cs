using System.Collections.Generic;

namespace QuickLabel.Data
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
    }
}