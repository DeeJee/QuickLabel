using CsvHelper;
using NLog;
using QuickLabel.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Configuration;
using Helper = CsvHelper.Configuration;

namespace QuickLabel.Data
{
    public class AddresRepository : IRepository<Adres>
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();

        public IEnumerable<Adres> GetAll()
        {
            var appSettings = ConfigurationManager.AppSettings;
            var fileName = appSettings.Get("adressenFileName");
            var separator = appSettings.Get("fieldSeparator");

            List<Adres> addresses = new List<Adres>();
            try
            {
                Helper.Configuration adresFile = new Helper.Configuration();
                adresFile.Delimiter = separator;
                using (var file = File.OpenText(fileName))
                {
                    CsvReader reader = new CsvReader(file, adresFile);
                    var records = reader.GetRecords<Adres>().ToList();
                    return records;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                throw;
            }
        }
    }
}
