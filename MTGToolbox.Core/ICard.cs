using System;
using System.Collections.Generic;
using System.Text;

namespace MTGToolbox.Core
{
    public interface ICard
    {
        int Id { get; set; }
        string Name { get; set; }
    }
}
