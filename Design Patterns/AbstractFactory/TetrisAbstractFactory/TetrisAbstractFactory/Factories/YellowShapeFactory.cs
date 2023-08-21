using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisAbstractFactory.Factories.Base;
using TetrisAbstractFactory.Shapes;

namespace TetrisAbstractFactory.Factories {
    internal class YellowShapeFactory : IShapeFactory {

        public IShape GetIShape() {
            var shape = new IShape();
            Console.ForegroundColor = ConsoleColor.Yellow;
            return shape;
        }

        public OShape GetOShape() {
            var shape = new OShape();
            Console.ForegroundColor = ConsoleColor.Yellow;
            return shape;
        }
    }
}
