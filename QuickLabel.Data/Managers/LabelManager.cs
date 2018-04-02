using QuickLabel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickLabel.Data
{
    public class LabelManager
    {
        AddressManager addressManager;
        ContainerManager containerManager;
        AantalContainersManager aantalContainersManager;
        Random random = new Random();

        public LabelManager()
        {
            addressManager = new AddressManager();
            containerManager = new ContainerManager();
            aantalContainersManager = new AantalContainersManager();
        }

        public QuickLabelData GetRandom()
        {
            var address = addressManager.GetRandom();
            var container = containerManager.GetRandom();

            var max = aantalContainersManager.GetMaxByType(container.Typenummer);
            var aantal = random.Next(1, max);
            QuickLabelData data = new QuickLabelData
            {
                Adres = address,
                Aantal = aantal,
                Container = container
            };
            return data;
        }
    }
}
