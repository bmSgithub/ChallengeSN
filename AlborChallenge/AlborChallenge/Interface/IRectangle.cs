using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlborChallenge.Interface
{
    public interface IRectangle : IShape
    {
        int Height { get; set; }
    }
}
