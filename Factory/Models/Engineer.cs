using System.Collections.Generic;
using System;
// Only use these directives if you add a date of hire for Engineers/ or alternatively Date of maintence for Machines!
// using System.ComponentModel.DataAnnotations;
// using System.ComponentModel;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    public int EngineerId { get; set; }
    public string Name { get; set; }

    public virtual ICollection<EngineerMachine> JoinEntities { get; }
  }
}