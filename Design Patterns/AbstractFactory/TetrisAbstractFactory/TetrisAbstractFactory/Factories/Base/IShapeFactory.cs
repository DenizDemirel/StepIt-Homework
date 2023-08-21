using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisAbstractFactory.Shapes;

namespace TetrisAbstractFactory.Factories.Base {
    public interface IShapeFactory {
        IShape GetIShape();
        OShape GetOShape();
    }
}
