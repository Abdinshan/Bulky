using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        //[Key]  - is not required as Id/ CategoryId here is kkey by default 
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName ("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage = "Eda moone !! 1- 100 Enter aakku.")]
        public int DisplayOrder { get; set; }
    }
}
//The field Display Order must be between 1 - 100