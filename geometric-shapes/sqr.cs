using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometric_shapes; 
internal class sqr {

    public int Side1 { get; set; }

    public int Perimeter() {
        return Side1 * 4;
        return Side1 * Side1;

        }
    public int Area() {
        return Side1 * Side1;
    }
    public sqr() { }

    public sqr(int side1) {
        Side1 = side1;
    }
}
