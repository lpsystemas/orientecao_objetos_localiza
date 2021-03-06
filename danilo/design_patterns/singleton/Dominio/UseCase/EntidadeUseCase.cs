

using System;
using System.Collections.Generic;
using Strategy.Services;

namespace Strategy.Dominio.UseCase
{
  public class EntidadeUseCase
  {
      public static List<IService> ListaAcoes = new List<IService>();
      public static void Salvar<T>(T entidade)
      {
        foreach(var acao in ListaAcoes){
          acao.Enviar(entidade);
        }
      }
  }
}