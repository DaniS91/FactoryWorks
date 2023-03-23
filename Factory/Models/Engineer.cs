using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }

    [Required(ErrorMessage = "Engineer's first name must be entered!")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Engineer's last name must be entered!")]
    public string LastName { get; set; }

    public List<EngineerMachine> JoinEntities { get; }
  }
}