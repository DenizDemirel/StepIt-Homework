using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisAbstractFactory.Shapes.Base {
    public class Shape {
        
        protected string[,] Form;

        public void Draw() {
            for (int i = 0; i < Form.GetLength(0); i++) { 
                for (int j = 0; j < Form.GetLength(1); j++) {
                    Console.Write(Form[i,j]);
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
