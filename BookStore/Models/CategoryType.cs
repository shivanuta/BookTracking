using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class CategoryType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryTypeID { get; set; }

        [Required]
        public string Type { get; set; }

        public string Name { get; set; }


        public ICollection<Category> categories { get; set; }
                    = new List<Category>();
    }
}
