using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }

        [Required]
        public string NameToken { get; set; }

        [ForeignKey("CategoryTypeID")]
        public CategoryType CategoryType { get; set; }

        [Required]
        public int CategoryTypeID { get; set; }

        public string Description { get; set; }


        public ICollection<Book> books { get; set; }
                   = new List<Book>();
    }
}
