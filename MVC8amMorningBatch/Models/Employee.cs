using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC8amMorningBatch.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
    }

    public class Register {
        [Key]
        public int EmpId { get; set; }
        [Required(ErrorMessage ="this Filed is required !")]
        [Display(Name ="Employee Name")]
        public string EmpName { get; set; }
        [Required(ErrorMessage = "this Filed is required !")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Password and Conform Password Not Match")]
        public string ConfirmPassword { get; set; }
        [DataType(DataType.EmailAddress,ErrorMessage ="Invalid EmailId")]
        public string EmailId { get; set; }
        [Range(18,60,ErrorMessage ="18 to 60 is valid")]
        public int Age { get; set; }
        [StringLength(10,ErrorMessage ="Address length should not be more then 10")]
        public string Address { get; set; }
        [RegularExpression(@"\$(\d+)\.(\d\d)", ErrorMessage = "the Pattern 32225")]
        public string ZipCode { get; set; }
    }
}