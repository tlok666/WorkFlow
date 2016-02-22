using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Apache.Models
{
    public class GuaredFamilyItem
    {
        public int ID { get; set; }
        public string drafter { get; set; }
        public DateTime isiCreateDate { get; set; }
        public DateTime? isiCompleteDate { get; set; }


        public string sName { get; set; }
        public string sIdentityNum { get; set; }
        public bool bSex { get; set; }
        public string sRace { get; set; }
        public string sFamilyAddress { get; set; }
        public DateTime? sBirthMonth { get; set; }
        public int iPopulation { get; set; }
        public bool bIsDisable { get; set; }

        public string Member1_sName { get; set; }
        public string Member1_sRelationship { get; set; }
        public bool Member1_bSex { get; set; }
        public int Member1_iAge { get; set; }
        public bool Member1_bDisable { get; set; }
        public string Member1_sIdentity { get; set; }

        public string Member2_sName { get; set; }
        public string Member2_sRelationship { get; set; }
        public bool Member2_bSex { get; set; }
        public int Member2_iAge { get; set; }
        public bool Member2_bDisable { get; set; }
        public string Member2_sIdentity { get; set; }

        public string Member3_sName { get; set; }
        public string Member3_sRelationship { get; set; }
        public bool Member3_bSex { get; set; }
        public int Member3_iAge { get; set; }
        public bool Member3_bDisable { get; set; }
        public string Member3_sIdentity { get; set; }

    }
}