using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CourseProjectLibrary.Models
{
    public class Users
    {
        [Key]

        public int UserID { get; set; }

        [Required(ErrorMessage = "User's Name is Required.")]
        [DisplayName("User's Name")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "User's Gender is Required. [M/F]")]
        [DisplayName("User's Gender [M/F]")]
        public char UserGender { get; set; }

        [Required(ErrorMessage = "User's Age is Required.")]
        [DisplayName("User's Age")]
        public int UserAge { get; set; }


        [Required(ErrorMessage = "User's Birth Date is Required.")]
        [DisplayName("User's Date Of Birth")]
        public DateTime BirthDate { get; set; }

        public string Remarks { get; set; }
    }
}