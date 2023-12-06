using PatronVisitor.Interfaces;
using PatronVisitor.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronVisitor.Componentes
{
    public class DiscoRigido : Componente
    {
        public DiscoRigido(string serial) : base(serial) { }
        public override void Aceptar(IVisitor visitor)
        {
            visitor.Visitar(this);
        }
    }
}
