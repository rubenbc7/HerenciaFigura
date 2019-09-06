using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Triangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public override double calcularArea()
        {
            return (Base* Altura)/2.0;
        }
        public Triangulo()
        {
            color = "Bien buena";
            Base = 8;
            Altura = 10;
        }
    }
}
