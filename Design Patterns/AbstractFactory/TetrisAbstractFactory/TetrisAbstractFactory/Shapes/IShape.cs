using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisAbstractFactory.Shapes.Base;

namespace TetrisAbstractFactory.Shapes {
    public class IShape : Shape {
        public IShape() {
            this.Form = new string[4, 1] {
               { "*" },
               { "*" },
               { "*" },
               { "*" },
            };
        }
    }
}
