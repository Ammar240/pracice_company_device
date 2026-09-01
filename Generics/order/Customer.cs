using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.order;

internal class Customer : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
}
