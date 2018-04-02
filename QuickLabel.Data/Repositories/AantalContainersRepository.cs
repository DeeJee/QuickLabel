using CsvHelper;
using NLog;
using QuickLabel.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using Helper = CsvHelper.Configuration;

namespace QuickLabel.Data
{
    public class AantalContainersRepository : IRepository<AantalContainers>
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();

        public IEnumerable<AantalContainers> GetAll()
        {
            var appSettings = ConfigurationManager.AppSettings;
            var fileName = appSettings.Get("aantalContainersFileName");
            var separator = appSettings.Get("fieldSeparator");
            try
            {
                Helper.Configuration adresFile = new Helper.Configuration();
                adresFile.Delimiter = separator;
                using (var file = File.OpenText(fileName))
                {
                    CsvReader reader = new CsvReader(file, adresFile);
                    var records = reader.GetRecords<AantalContainers>().ToList();
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
