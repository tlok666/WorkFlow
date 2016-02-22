using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Apache.Models
{
    public class ItServiceItem
    {
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }
        public string isitype { get; set; }
        public string sub_isitype { get; set; }
        public string end_isitype { get; set; }
        public string drafter { get; set; }
        public string applicant { get; set; }      //申请人
        public string applicantPhone { get; set; }      //申请人电话
        public string applicant_dept { get; set; }   //申请人部门
        public string description { get; set; }
        public string solution { get; set; }
        public string DealwithpeopleName { get; set; }   //处理人名字
        public string ItManagerOpinion { get; set; }                   //意见域
        public string ProcessingDepartmentOpinion { get; set; }       //意见域
        public string DealwithpeopleOpinion { get; set; }             //意见域
        public DateTime isiCreateDate { get; set; }
        public DateTime? isiCompleteDate { get; set; }
    }
}