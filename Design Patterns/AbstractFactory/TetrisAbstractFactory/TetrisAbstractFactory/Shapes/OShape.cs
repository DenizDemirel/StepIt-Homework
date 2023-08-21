using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisAbstractFactory.Shapes.Base;

namespace TetrisAbstractFactory.Shapes {
    public class OShape : Shape {
        public OShape() {
            this.Form = new string[3, 4] {
               { "*","*","*","*"},
               { "*","*","*","*"},
               { "*","*","*","*"},
            };
        }
    }
}
