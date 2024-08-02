using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP5_LUCERO_MONTENEGRO.Models
{
    public class Escape
    {
        static private List<string> incognitasSalas;
        static private int estadoDeJuego = 1;

    private static void InicializarJuego() 
    {
      incognitasSalas = new List<string>() {"2198", "186", "16", "11", "espacio"};
    }
  public static int GetEstadoJuego() 
  {
    return estadoDeJuego;
  }
    public static bool ResolverSala(int Sala, string Incognita)
    {
  estadoDeJuego = GetEstadoJuego();
  bool puedeResolver = false;

      if (incognitasSalas == null)
        {
            InicializarJuego();
        }
      else if(Sala == estadoDeJuego)
        { 
        puedeResolver = true;
        }
      
      if (Incognita == incognitasSalas[Sala - 1] && puedeResolver)
        {
          puedeResolver = true;
          estadoDeJuego++; //prerguntar array incognitas correctas
        }
      else
      {
        puedeResolver = false;
      }
    return puedeResolver;
  }
     
 }

    }