using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GuessingGame2.Models
{
    public class GameModel
    {
        [Required]
        [MaxLength (10, ErrorMessage = "Please choose a name less than 10 characters long.")]
        [Display(Name = "Player Name")]
        public string PlayerName { get; set; }

        [Range(1, 25, ErrorMessage = "Hint: The number will be between 1 and 25.")]
        public int Guess { get; set; }
    }
}