using PatronVisitor;
using PatronVisitor.Component;
using PatronVisitor.Componentes;
using PatronVisitor.Concreto;
using PatronVisitor.Interfaces;

IVisitor visitante = new VisitanteConcreto();


Componente dr = new DiscoRigido("1231DSFFSD3-DR");
Componente pb = new PlacaBase("dkk3nndj12313-PB");
Componente p = new Procesador("9393SKKK4K3-P");


dr.Aceptar(visitante);
pb.Aceptar(visitante);
p.Aceptar(visitante);

IVisitor visitante2 = new VisitanteConcreto2();

Componente dr2 = new DiscoRigido("1231DSFFSD3-DR");
Componente pb2 = new PlacaBase("dkk3nndj12313-PB");
Componente p2 = new Procesador("9393SKKK4K3-P");


dr2.Aceptar(visitante2);
pb2.Aceptar(visitante2);
p2.Aceptar(visitante2);

Console.ReadKey();
