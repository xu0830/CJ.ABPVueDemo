using System.ComponentModel.DataAnnotations;

namespace CJ.ABPVueDemo.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}