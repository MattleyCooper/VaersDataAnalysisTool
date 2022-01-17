using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace CSVReader
{
    public class ClassBuilder
    {   
        public List<Vax> GetVaxInfo(string path)
        {
            //Console.WriteLine("");
            using (var reader = new StreamReader(path))
            {
                using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csvReader.Context.RegisterClassMap<VaxClassMap>();
                    var records = csvReader.GetRecords<Vax>().ToList();

                    return records;
                }
            }
        }
        public List<Symptoms> GetSymptomInfo(string path)
        {
            //Console.WriteLine("");
            using (var reader = new StreamReader(path))
            {
                using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csvReader.Context.RegisterClassMap<SymptomsClassMap>();
                    var records = csvReader.GetRecords<Symptoms>().ToList();

                    return records;
                }
            }
        }
        public List<Data> GetData(string path)
        {
            //Console.WriteLine("");
            using (var reader = new StreamReader(path))
            {
                using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csvReader.Context.RegisterClassMap<DataClassMap>();
                    var records = csvReader.GetRecords<Data>().ToList();

                    return records;
                }
            }
        }
    }
}
