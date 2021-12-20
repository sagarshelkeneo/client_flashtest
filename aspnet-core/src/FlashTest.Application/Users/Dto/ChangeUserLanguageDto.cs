using System.ComponentModel.DataAnnotations;

namespace FlashTest.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}