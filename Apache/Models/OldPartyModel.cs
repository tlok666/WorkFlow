using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Apache.Models
{
    public class MedicalAidItem
    {
        public int ID { get; set; }
        public string sSickName { get; set; }
        public bool bSickSex { get; set; }
        public int iSickAge { get; set; }
        public string sSickiDentityNum { get; set; }
        public string sSickCardNum { get; set; }

        public string sFriendName { get; set; }
        public bool bFriendSex { get; set; }
        public string sRelationship { get; set; }
        public string sFriendiDentityNum { get; set; }
        public string sFriendCardNum { get; set; }

        public bool bIsCountry;
        public string sAddress;
        public string sPhoneNum;
        public int iDifficultType;
        public string sHospital;
        public DateTime tAdmitedTime;
        public DateTime tLeaveTime;
        public string sIllustrate;

        public int iMedicalFund;
        public int iCompendFund;
        public int iCopSecureFund;
        public int iSeriousFund;
        public int iOtherFund;
        public int iSelfFund;


        public int iPopulation { get; set; }
        public string sEducationLevel { get; set; }
        public DateTime tJoinTime { get; set; }
        public string sFamilyAddress { get; set; }
        public string sGroupAdress{ get; set; }

    }
}