//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Web.Mvc;
namespace WebApplication1.Models
{
    public partial class student
    {
        
        public int id { get; set; }
        [Required(ErrorMessage = "Please insert Name")]
        [StringLength(15,MinimumLength=3,ErrorMessage="Name must contain 3 or maximin 15 Characters")]
        public string name { get; set; }
        [Required(ErrorMessage = "Please insert Roll No")]
        [Remote("checkRoll","Home",ErrorMessage="Roll No is Already Exist Try Another")]
        public int rollno { get; set; }
        [Required(ErrorMessage = "Please insert Course")]
        public string course { get; set; }
        [Required(ErrorMessage = "Please insert Maths Marks")]
        [Range(1,100,ErrorMessage="Enter Marks Between 1 to 100 Only")]
        public int math { get; set; }
        [Required(ErrorMessage = "Please insert Urdu Marks")]
        [Range(1, 100, ErrorMessage = "Enter Marks Between 1 to 100 Only")]
        public int urdu { get; set; }
        [Required(ErrorMessage = "Please insert English Marks")]
        [Range(1, 100, ErrorMessage = "Enter Marks Between 1 to 100 Only")]
        public int english { get; set; }
        public int total { get; set; }
        public int obtain { get; set; }
        public double percentage { get; set; }
        public string grade { get; set; }
        public string remarks { get; set; }
        public string picture { get; set; }
    }
}