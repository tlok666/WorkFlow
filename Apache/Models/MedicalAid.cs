using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Apache.Models
{
    public class OldPartyItem
    {
        public int ID { get; set; }
        public string sName { get; set; }
        public bool bSex { get; set; }
        public string sRace { get; set; }
        public int iAge { get; set; }
        public int iPopulation { get; set; }
        public string sEducationLevel { get; set; }
        public string siDentityNum { get; set; }
        public DateTime tJoinTime { get; set; }
        public string sFamilyAddress { get; set; }
        public string sCardNum { get; set; }
        public string sGroupAdress{ get; set; }

    }
}