using System;
using System.ComponentModel.DataAnnotations;

namespace DictionaryWebApp.Models
{
    public class Word
    {

        public int Id { get; set; }
        [Required]
        public string WordText { get; set; }
        [Required]
        public string WordMeaning { get; set; }
        [Required]
        public string WordTranslate { get; set; }
        [Required]
        public string WordUsageExample { get; set; }

        public Word()
        {

        }
    }
}
