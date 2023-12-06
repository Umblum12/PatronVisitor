using PatronVisitor.Componentes;
using PatronVisitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronVisitor.Concreto
{
    public class VisitanteConcreto : IVisitor
    {
        public void Visitar(Procesador componente)
        {
            Console.WriteLine(String.Format("Procesador s/n {0}", componente.Serial));
        }

        public void Visitar(PlacaBase componente)
        {
            Console.WriteLine(String.Format("Placa Base s/n {0}", componente.Serial));
        }

        public void Visitar(DiscoRigido componente)
        {
            Console.WriteLine(String.Format("Disco Rigido s/n {0}", componente.Serial));
        }
    }
    public class VisitanteConcreto2 : IVisitor
    {
        public void Visitar(Procesador componente)
        {
            Console.WriteLine(String.Format("Procesador 2 s/n {0}", componente.Serial));
        }

        public void Visitar(PlacaBase componente)
        {
            Console.WriteLine(String.Format("Placa Base 2 s/n {0}", componente.Serial));
        }

        public void Visitar(DiscoRigido componente)
        {
            Console.WriteLine(String.Format("Disco Rigido 2 s/n {0}", componente.Serial));
        }
    }
}
