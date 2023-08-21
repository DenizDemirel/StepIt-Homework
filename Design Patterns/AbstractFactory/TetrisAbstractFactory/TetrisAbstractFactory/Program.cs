using TetrisAbstractFactory.Factories;
using TetrisAbstractFactory.Factories.Base;
using TetrisAbstractFactory.Services;

namespace TetrisAbstractFactory {
    internal class Program {
        static void Main(string[] args) {

            ShapeServise shapeService = new ShapeServise(new RedShapeFactory());

            var result = shapeService.CreateOShape();
            result.Draw();


        }
    }
}