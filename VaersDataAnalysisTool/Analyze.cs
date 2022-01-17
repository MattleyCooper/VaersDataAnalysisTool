using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaersDataAnalysisTool
{
    public class Analyze
    {
        public List<Vax> Vaxes { get; set; }
        public List<Symptoms> symptoms { get; set; }
        public List<Data> Datas { get; set; }

        Analyze(List<Vax> vax, List<Symptoms> symp, List<Data> data)
        {
            this.Vaxes = vax; 
            this.symptoms = symp;
            this.Datas = data;

            AnaylzeAllYearsData(vax, symp, data);
        }
        public void AnaylzeAllYearsData(List<Vax> vax, List<Symptoms> symp, List<Data> data)
        {

        }



    }
}
