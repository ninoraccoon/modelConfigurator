using System.ComponentModel.DataAnnotations;

namespace modelConfigurator.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}