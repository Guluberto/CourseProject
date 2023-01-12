using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CourseProjectLibrary.Models
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }


        [Required(ErrorMessage = "Product Name is Required.")]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }


        [Required(ErrorMessage = "Author Name is Required.")]
        [DisplayName("Author Name")]
        public string AuthorName { get; set; }


        [Required(ErrorMessage = "Price is Required.")]
        [DisplayName("Price in BGN")]
        public float Price { get; set; }


        [Required(ErrorMessage = "Date is Required.")]
        [DisplayName("Date of creating the product" +
            " MM/DD/YY HH:MM:SS [AM/PM]")]
        public DateTime AddedIntoStorage { get; set; }


        [Required(ErrorMessage = "Quantity is Required.")]
        public long Quantity { get; set; }

        public string Remarks { get; set; }
    }

    public class CRUD : DbContext
    {
        public DbSet<Products> products { set; get; }

        public DbSet<Users> users { set; get; }
    }

}