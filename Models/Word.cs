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

        public int LanguageID { get; set; }
        [Required]
        public virtual Language Language { get; set; }
        public Word()
        {

        }
    }
}
