using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue;

internal class Command
{
    private readonly string _url;
    private readonly DateTime _date;

    public Command(string url)
    {
        _url = url;
        _date = DateTime.Now;
    }

    public override string ToString()
    {
        return $"Date: {_date.ToString("yyyy-MM-dd hh:mm")}, url: {_url}";
    }
}
