using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }

    [Required(ErrorMessage = "The machine's model name can't be empty")]
    public string ModelName { get; set; }

    [Required(ErrorMessage = "The machine's task description can't be empty")]
    public string TaskDescription { get; set; }

    [Required(ErrorMessage = "The machine's brand name can't be empty")]
    public string BrandName { get; set; }

    public List<EngineerMachine> JoinEntities { get; }
  }
}