using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42Libreria
{
  public class UnaExepcion : Exception
  {
    public UnaExepcion(string mensaje, Exception e) : base(mensaje,e)
    {
      
    }
  }
}
