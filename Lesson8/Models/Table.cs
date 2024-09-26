using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8.Models;

internal class Table
{
    public int Number { get; set; }
    public string Description { get; set; }
    public override string ToString() => $"Столик N {Number}, ({Description})";
}

