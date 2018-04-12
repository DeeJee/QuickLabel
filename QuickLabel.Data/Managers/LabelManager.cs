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
        Random random = new Random();

        public LabelManager()
        {
            addressManager = new AddressManager();
            containerManager = new ContainerManager();
        }

        public QuickLabelData GetRandom()
        {
            var address = addressManager.GetRandom();
            var container = containerManager.GetRandom();

            var aantal = random.Next(1, container.Aantal);
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
