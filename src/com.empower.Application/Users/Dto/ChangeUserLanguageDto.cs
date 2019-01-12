using System.ComponentModel.DataAnnotations;

namespace com.empower.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}