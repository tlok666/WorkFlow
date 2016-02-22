using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Apache.Models
{
    public class DifficultiesItem
    {
        public string sName { get; set; }
        public string siDentityNum { get; set; }
        public int iPeopleType;
        public bool bSex;
        public string sFamilyAddress;
        public int iPolulation;
        public int iDifficultType;
        public string sAidType;
        public int iCount;
    }
}