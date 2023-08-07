using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
    public class Engineer
    {
        public int EngineerId { get; set; }
        [Required(ErrorMessage = "The engineer's description can't be empty. Please write a blurb!")]
        public string Description { get; set; }
        public List<EngineerMachine> JoinEntities { get; }
    }
}