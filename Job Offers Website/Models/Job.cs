using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Job_Offers_Website.Models
{
    public class Job
    {
        public int Id { get; set; }
        [Display(Name ="اسم الوظيفة")]
        public string JobTitle { get; set; }
        [Display(Name ="وصف الوظيفة")]
        public string JobContent { get; set; }
        [Display(Name ="صورة الوظيفة")]
        public string JobImage { get; set; }
        [Display(Name ="نوع الوظيفة")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}