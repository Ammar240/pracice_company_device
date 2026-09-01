using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.order;

internal class Order : IEntity
{
    public int Id { get; set; }
    public decimal TotalPrice { get; set; }
}
