using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP5_LUCERO_MONTENEGRO.Models
{
    public class Escape
    {
        static public List<string> incognitasSalas;
        static private int estadoDeJuego = 1;

    public static void InicializarJuego() 
    {
      incognitasSalas = new List<string>() {"2198", "186", "1611", "espacio"};
    }
    public static int GetEstadoJuego() 
  {
    return estadoDeJuego;
  }
    public static bool ResolverSala(int Sala, string Incognita, bool salaCorrecta)
    {
      estadoDeJuego = GetEstadoJuego();
      bool resolvio = false;

      if (incognitasSalas == null)
        {
            InicializarJuego();
        }
      
      if (Incognita.ToLower() == incognitasSalas[Sala - 1] && salaCorrecta == true)
        {
          resolvio = true;
          estadoDeJuego++;
        }
    return resolvio;
  }  
 }
}