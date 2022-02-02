using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDSC_Task.Core.Models
{
    public class News
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(150)]
        public string Title { get; set; }

        [Display(Name = "Content")]
        public string Content { get; set; }
       
        public string Photo { get; set; }
        [DataType(DataType.Date)]
       
        public DateTime PublishDate { get; set; }

        [ForeignKey("Category")]

        public int Category_Id { get; set; }

        public Category Category { get; set; }

        [ForeignKey("Source")]
       
        public int Source_Id { get; set; }
        public Source Source { get; set; }
       
    }
}
