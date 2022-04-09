using System;
namespace DictionaryWebApp.Models
{
    public class Word
    {
        public int Id { get; set; }
        public string WordText { get; set; }
        public string WordMeaning { get; set; }
        public string WordTranslate { get; set; }
        public string WordUsageExample { get; set; }

        public Word()
        {

        }
    }
}
