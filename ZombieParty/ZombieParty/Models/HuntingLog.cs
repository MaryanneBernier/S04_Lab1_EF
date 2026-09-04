using System.ComponentModel.DataAnnotations;

namespace ZombieParty.Models
{
    public class HuntingLog
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(25, MinimumLength = 5,
            ErrorMessage = "{0} requires between {2} and {1} characters.")]
        public string Title { get; set; }

        [StringLength(255,
        ErrorMessage = "{0} requires between {2} and {1} characters.")]
        public string Description { get; set; }

        public List<Zombie> Zombies { get; set; }
    }
}
