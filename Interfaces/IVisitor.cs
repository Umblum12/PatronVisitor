using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronVisitor.Componentes;

namespace PatronVisitor.Interfaces
{
    public interface IVisitor
    {
        void Visitar(Procesador componente);
        void Visitar(PlacaBase componente);
        void Visitar(DiscoRigido componente);
    }
}
