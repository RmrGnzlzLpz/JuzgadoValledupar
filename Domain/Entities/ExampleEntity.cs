using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class ExampleEntity : Entity<int>
    {
        public string Property { get; set; }
    }
}
