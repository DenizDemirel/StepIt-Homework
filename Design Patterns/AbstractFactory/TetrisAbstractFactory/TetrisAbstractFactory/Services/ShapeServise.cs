  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisAbstractFactory.Factories;
using TetrisAbstractFactory.Factories.Base;
using TetrisAbstractFactory.Shapes;
using TetrisAbstractFactory.Shapes.Base;

namespace TetrisAbstractFactory.Services {
    internal class ShapeServise {
        private IShapeFactory shapeFactory; 

        public ShapeServise(IShapeFactory shapeFactory) {
            this.shapeFactory = shapeFactory ?? new YellowShapeFactory();
        }
        public IShape CreateIShape() {

            return this.shapeFactory.GetIShape();
        } 
        public OShape CreateOShape() {

            return this.shapeFactory.GetOShape();
        }
    }
}
