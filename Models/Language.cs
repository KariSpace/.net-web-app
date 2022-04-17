using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DictionaryWebApp.Models
{
    public class Language
    {

        public int Id { get; set; }
        [Required]
        public string LanguageName { get; set; }

        public virtual ICollection<Word> Words { get; set; }
    }
}
