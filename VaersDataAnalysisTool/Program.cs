using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using Models;


namespace CSVReader
{
    public class Program
    {

        static void Main(string[] args)
        {

            List<Vax> vaxData = new();
            List<Symptoms> symptomsData = new();
            List<Data> Data = new();
            ClassBuilder classBuilder = new();


            string vaxFile = "VAERSVAX";
            string symptFile = "VAERSSYMPTOMS";
            string dataFile = "VAERSDATA";
            string currentyear = "2021";

            string path = @"D:\Vaers_Data\Data\";
            var fileNamesList = Directory.EnumerateFiles(path).ToList();



            foreach (var file in fileNamesList)
            {
                string fileName = Path.GetFileName(file);
                string filePath = Path.Combine(path, fileName);

                if (fileName.Contains(vaxFile))
                {
                    var vaxinfo = classBuilder.GetVaxInfo(filePath);
                    foreach (var vax in vaxinfo)
                    {
                        vaxData.Add(vax);
                    }
                }
                else if (fileName.Contains(symptFile))
                {
                    var symptoms = classBuilder.GetSymptomInfo(filePath);
                    foreach (var symptom in symptoms)
                    {
                        symptomsData.Add(symptom);
                    }
                }
                else if (fileName.Contains(dataFile))
                {
                    var data = classBuilder.GetData(filePath);
                    foreach (var datas in data)
                    {
                        Data.Add(datas);
                    }
                }
            }


        }
    }
}
