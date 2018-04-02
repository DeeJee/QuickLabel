using QuickLabel.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickLabel.Data
{
    public class ContainerManager
    {
        IRepository<Container> repo;
        IList<Container> list;
        Random random = new Random();

        public ContainerManager()
        {
            this.repo = new ContainerRepository();
        }

        public Container GetRandom()
        {
            if (list == null)
            {
                list = (IList<Container>)repo.GetAll();
            }
            var max = list.Count();

            var index = random.Next(max);

            return list[index];
        }
    }
}
