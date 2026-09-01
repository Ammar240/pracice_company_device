using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue;

internal class PrinitingJop
{
    private readonly string _file;
    private readonly int _copies;

    public PrinitingJop(string file, int copies)
    {
        _file = file;
        _copies = copies;
    }

    public override string ToString()
    {
        return $"{_file,-20} X {_copies} Copies";
    }
}
