using QuickLabel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickLabel.Data
{
    public class AddressManager
    {
        IRepository<Adres> repo;
        IList<Adres> list;
        Random random = new Random();

        public AddressManager()
        {
            this.repo = new AddresRepository();
            list = (IList<Adres>)repo.GetAll();
        }

        public Adres GetRandom()
        {
            if (list == null)
            {
                list = (IList<Adres>)repo.GetAll();
            }
            var max = list.Count();

            var index = random.Next(max);

            return list[index];
        }
    }
}
