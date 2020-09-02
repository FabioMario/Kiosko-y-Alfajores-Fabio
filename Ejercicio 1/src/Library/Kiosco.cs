using System;

namespace Expert_SRP
{
    public class Kiosco 
    // No cumple con SRP porque  no solo dice si puedes comprar o no, si no que tambien hace la conversion a pesos esa misma clase
    // Alfajor deberia de ser la responable en calcular su precio por que es la experta en la informacion necesaria para hacerlo ya que la contiene
    {
        public Kiosco()
        {
        }
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Conversion k = new Conversion();
            Double pesos = k.ConvertirAPesos(dinero, moneda);
            return pesos >= a.PrecioDulce + a.PrecioMasa;
        }
    }
}