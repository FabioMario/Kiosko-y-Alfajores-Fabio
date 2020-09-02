using System;

namespace Expert_SRP
{
    public class Conversion
    {
        public Conversion()
        {
        }

        public Double ConvertirAPesos(Double dinero, String moneda)
        {
            if (moneda.Equals("U$S"))
            {
                return dinero / 30;
            }
            else if (moneda.Equals("$"))
            {
                return dinero;
            }
            else
            {
                return -1;
            }
        }
    }
}