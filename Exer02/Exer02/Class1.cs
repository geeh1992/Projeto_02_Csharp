using System;
using System.Collections.Generic;
using System.Text;
namespace Exer02
{
    class FilaF

{
   public No primeiro = null;
    public No ultimo = null;
    public void AdicionarNoInicio(int valor)
    {
        var novoNo = new No { Numero = valor };
        if (primeiro == null)
            primeiro = ultimo = novoNo;
        else
        {
            primeiro.Anterior = novoNo;
            novoNo.Proximo = primeiro;
            primeiro = novoNo;
        }
    }
    public void AdicionarNoFinal(int valor)
    {
        var novoNo = new No { Numero = valor };
        if (primeiro == null)
            primeiro = ultimo = novoNo;
        else
        {
            novoNo.Anterior = ultimo;
            ultimo.Proximo = novoNo;
            ultimo = novoNo;
        }
    }
    public void RemoverNoInicio()
    {
        if (primeiro != null)
        {
            if (primeiro == ultimo)
            {
                primeiro = ultimo = null;
            }
            else
            {
                primeiro = primeiro.Proximo;
                primeiro.Anterior = null;
            }
        }
    }
    public void RemoverNoFinal()
    {
        if (primeiro != null)
        {
            if (primeiro == ultimo)
            {
                primeiro = ultimo = null;
            }
            else
            {
                ultimo.Anterior.Proximo = null;
                ultimo = ultimo.Anterior;
            }
            
        }
    }
    public void PercorrerInicioAoFim(Action<int> executar)
    {
        var noAtual = primeiro;
        while (noAtual != null)
        {
            executar(noAtual.Numero);
            noAtual = noAtual.Proximo;
        }
    }
  }
}
