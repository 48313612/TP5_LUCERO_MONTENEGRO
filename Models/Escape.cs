using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP5_LUCERO_MONTENEGRO.Models
{
    public class Escape
    {
        static private List<string> incognitasSalas = new List<string>() {"2198", "186", "16", "11", "espacio"};
        static private int estadoDeJuego = 1;

    private static void InicializarJuego() 
    {

    }
  public static int GetEstadoJuego() 
  {
    return estadoDeJuego;
  }
 public static bool ResolverSala(int Sala, string Incognita)
 {
  estadoDeJuego = GetEstadoJuego();
  bool puedeResolver = false;
  int x = 0;
  bool resolvio = false;
      if(Sala == estadoDeJuego)
      {
        puedeResolver = true;
      }
      while(x < incognitasSalas.Count && !resolvio)
      {
        if(Incognita == incognitasSalas[x])
        {
          resolvio = true;
          estadoDeJuego++; //prerguntar array incognitas correctas
        }
      }
      return resolvio; // que bool debe retornar
 }
    }
}