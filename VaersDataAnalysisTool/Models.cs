using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{

    public class VaxClassMap : ClassMap<Vax>
    {
        public VaxClassMap()
        {
            Map(i => i.VAERS_ID).Name("VAERS_ID");
            Map(i => i.VAX_TYPE).Name("VAX_TYPE");
            Map(i => i.VAX_MANU).Name("VAX_MANU");
            Map(i => i.VAX_LOT).Name("VAX_LOT");
            Map(i => i.VAX_DOSE_SERIES).Name("VAX_DOSE_SERIES");
            Map(i => i.VAX_ROUTE).Name("VAX_ROUTE");
            Map(i => i.VAX_SITE).Name("VAX_SITE");
            Map(i => i.VAX_NAME).Name("VAX_NAME");
        }
    }
    public class Vax
    {
        public string VAERS_ID { get; set; }
        public string VAX_TYPE { get; set; }
        public string VAX_MANU { get; set; }
        public string VAX_LOT { get; set; }
        public string VAX_DOSE_SERIES { get; set; }
        public string VAX_ROUTE { get; set; }
        public string VAX_SITE { get; set; }
        public string VAX_NAME { get; set; }
    }
    public class SymptomsClassMap : ClassMap<Symptoms>
    {
        public SymptomsClassMap()
        {
            Map(i => i.VAERS_ID).Name("VAERS_ID");
            Map(i => i.SYMPTOM1).Name("SYMPTOM1");
            Map(i => i.SYMPTOMVERSION1).Name("SYMPTOMVERSION1");
            Map(i => i.SYMPTOM2).Name("SYMPTOM2");
            Map(i => i.SYMPTOMVERSION2).Name("SYMPTOMVERSION2");
            Map(i => i.SYMPTOM3).Name("SYMPTOM3");
            Map(i => i.SYMPTOMVERSION3).Name("SYMPTOMVERSION3");
            Map(i => i.SYMPTOM4).Name("SYMPTOM4");
            Map(i => i.SYMPTOMVERSION4).Name("SYMPTOMVERSION4");
            Map(i => i.SYMPTOM5).Name("SYMPTOM5");
            Map(i => i.SYMPTOMVERSION5).Name("SYMPTOMVERSION5");
        }
    }
    public class Symptoms
    {
        

        public string VAERS_ID { get; set; }
        public string SYMPTOM1 { get; set; }
        public string SYMPTOMVERSION1 { get; set; }
        public string SYMPTOM2 { get; set; }
        public string SYMPTOMVERSION2 { get; set; }
        public string SYMPTOM3 { get; set; }
        public string SYMPTOMVERSION3 { get; set; }
        public string SYMPTOM4 { get; set; }
        public string SYMPTOMVERSION4 { get; set; }
        public string SYMPTOM5 { get; set; }
        public string SYMPTOMVERSION5 { get; set; }
    }

    public class DataClassMap : ClassMap<Data>
    {
        public DataClassMap()
        {
            Map(i => i.VaersId).Name("VAERS_ID");
            Map(i => i.RECVDATE).Name("RECVDATE");
            Map(i => i.STATE).Name("STATE");
            Map(i => i.AGE_YRS).Name("AGE_YRS");
            Map(i => i.CAGE_YR).Name("CAGE_YR");
            Map(i => i.CAGE_MO).Name("CAGE_MO");
            Map(i => i.SEX).Name("SEX");
            Map(i => i.RPT_DATE).Name("RPT_DATE");
            Map(i => i.SYMPTOM_TEXT).Name("SYMPTOM_TEXT");
            Map(i => i.DIED).Name("DIED");
            Map(i => i.DATEDIED).Name("DATEDIED");
            Map(i => i.L_THREAT).Name("L_THREAT");
            Map(i => i.ER_VISIT).Name("ER_VISIT");
            Map(i => i.HOSPITAL).Name("HOSPITAL");
            Map(i => i.HOSPDAYS).Name("HOSPDAYS");
            Map(i => i.X_STAY).Name("X_STAY");
            Map(i => i.DISABLE).Name("DISABLE");
            Map(i => i.RECOVD).Name("RECOVD");
            Map(i => i.VAX_DATE).Name("VAX_DATE");
            Map(i => i.ONSET_DATE).Name("ONSET_DATE");
            Map(i => i.NUMDAYS).Name("NUMDAYS");
            Map(i => i.LAB_DATA).Name("LAB_DATA");
            Map(i => i.V_ADMINBY).Name("V_ADMINBY");
            Map(i => i.V_FUNDBY).Name("V_FUNDBY");
            Map(i => i.OTHER_MEDS).Name("OTHER_MEDS");
            Map(i => i.CUR_ILL).Name("CUR_ILL");
            Map(i => i.HISTORY).Name("HISTORY");
            Map(i => i.PRIOR_VAX).Name("PRIOR_VAX");
            Map(i => i.SPLTTYPE).Name("SPLTTYPE");
            Map(i => i.FORM_VERS).Name("FORM_VERS");
            Map(i => i.TODAYS_DATE).Name("TODAYS_DATE");
            Map(i => i.BIRTH_DEFECT).Name("BIRTH_DEFECT");
            Map(i => i.OFC_VISIT).Name("OFC_VISIT");
            Map(i => i.ER_ED_VISIT).Name("ER_ED_VISIT");
            Map(i => i.ALLERGIES).Name("ALLERGIES");
        }
    }
    public class Data
    {
        public int VaersId { get; set; }
        public string RECVDATE { get; set; }
        public string STATE { get; set; }
        public string AGE_YRS { get; set; }
        public string CAGE_YR { get; set; }
        public string CAGE_MO { get; set; }
        public string SEX { get; set; }
        public DateOnly? RPT_DATE { get; set; }
        public string SYMPTOM_TEXT { get; set; }
        public string DIED { get; set; }
        public DateOnly? DATEDIED { get; set; }
        public string L_THREAT { get; set; }
        public string ER_VISIT { get; set; }
        public string HOSPITAL { get; set; }
        public string HOSPDAYS { get; set; }
        public string X_STAY { get; set; }
        public string DISABLE { get; set; }
        public string RECOVD { get; set; }
        public string VAX_DATE { get; set; }
        public string ONSET_DATE { get; set; }
        public string NUMDAYS { get; set; }
        public string LAB_DATA { get; set; }
        public string V_ADMINBY { get; set; }
        public string V_FUNDBY { get; set; }
        public string OTHER_MEDS { get; set; }
        public string CUR_ILL { get; set; }
        public string HISTORY { get; set; }
        public string PRIOR_VAX { get; set; }
        public string SPLTTYPE { get; set; }
        public string FORM_VERS { get; set; }
        public string TODAYS_DATE { get; set; }
        public string BIRTH_DEFECT { get; set; }
        public string OFC_VISIT { get; set; }
        public string ER_ED_VISIT { get; set; }
        public string ALLERGIES { get; set; }

    }
}
