using QuickLabel.Entities;
using System.Collections.Generic;
using System.Linq;

namespace QuickLabel.Data
{
    public class AantalContainersManager
    {
        IRepository<AantalContainers> repo;
        Dictionary<string, int> list;

        private Dictionary<string, int> List
        {
            get
            {
                if (list == null)
                {
                    list = repo.GetAll().ToDictionary(d => d.Containertypenummer, d => d.MaximumAantal);
                }
                return list;
            }
        }

        public int MyProperty { get; set; }

        public AantalContainersManager()
        {
            repo = new AantalContainersRepository();
        }

        public int GetMaxByType(string type)
        {
            return List[type];
        }
    }
}
