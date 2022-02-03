using System;
using System.ComponentModel.DataAnnotations;

namespace Mission4.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int ApplicationId { get; set; }

        [Required(ErrorMessage = "Title is Required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Year is Required")]
        public ushort Year { get; set; }

        [Required(ErrorMessage = "Director is Required")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Rating is Required")]
        public string Rating { get; set; }

        //Optional fields
        public bool Edited { get; set; }

        public string LentTo { get; set; }

        [MaxLength(25)]
        public string Notes { get; set; }


        //Foregin key relationship
        [Required(ErrorMessage = "Category is Required")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
