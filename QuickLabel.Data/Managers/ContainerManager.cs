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

        public ContainerManager(string containerFilename, string separator)
        {
            this.repo = new ContainerRepository(containerFilename, separator);
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
