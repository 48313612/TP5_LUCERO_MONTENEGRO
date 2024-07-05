using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP5_LUCERO_MONTENEGRO.Models
{
    public class Escape
    {
        static private List<string> incognitasSalas = new List<string>() {"2198", "186", "1111", "agujero negro"};
        static private int estadoDeJuego = 1;

    private static void InicializarJuego() 
    {

    }
  public static int GetEstadoJuego() 
  {
    return estadoDeJuego;
  }
 //public static bool ResolverSala(int Sala, string Incognita){}
    }
}