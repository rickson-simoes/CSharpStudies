

using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
  public class OrientacaoObj
  {
    static void Main(string[] args)
    {
      var payment = new List<Payments>();

      Console.WriteLine("(Add) Adicionando valores numa lista genérica e consultando a lista: ");
      payment.Add(new Payments(1));
      payment.Add(new Payments(2));
      payment.Add(new Payments(3));
      payment.Add(new Payments(4));
      payment.Add(new Payments(5));
      payment.Add(new Payments(6));

      foreach (var item in payment)
      {
        Console.WriteLine(item.Id);
      }
      Console.WriteLine("-------");

      Console.WriteLine("(Remove) Removendo valor de ID '2' de uma lista: ");
      var removendoValor = payment.First(x => x.Id == 2);
      payment.Remove(removendoValor);
      foreach (var item in payment)
      {
        Console.WriteLine(item.Id);
      }

      Console.WriteLine("-------");



      Console.WriteLine("(Skip) Pulando os primeiros 2 valores numa lista: ");
      Console.WriteLine("Lista:");
      foreach (var item in payment)
      {
        Console.WriteLine(item.Id);
      }

      var pulaItemLista = payment.Skip(2);

      Console.WriteLine("Nova lista com valores pulados:");
      foreach (var item in pulaItemLista)
      {
        Console.WriteLine(item.Id);
      }
      Console.WriteLine("-------");



      Console.WriteLine("(Any) Verificando a existencia de valor 3 numa lista: ");
      var checaIdExistente = payment.Any(x => x.Id == 9);
      Console.WriteLine(checaIdExistente);
      Console.WriteLine("-------");



      Console.WriteLine("(FirstOrDefault) Consultando o valor 3 numa lista: ");
      // O método First retorna erro se não existir o valor informado
      var checaValor = payment.FirstOrDefault(x => x.Id == 3);
      try
      {
        Console.WriteLine(checaValor.Id);
      } catch
      {
        Console.WriteLine($"Esse valor não é existente");
      }
      Console.WriteLine("-------");



      Console.WriteLine("(TAKE) Pegando os valores iniciais de uma lista");
      var pegaValores = payment.Take(3);
      foreach (var item in pegaValores)
      {
        Console.WriteLine(item.Id);
      }
      Console.WriteLine("-------");



      Console.WriteLine("(TAKE & SKIP) Pegando 3 valores depois de ter pulado 2");
      var pegaValores2 = payment.Skip(2).Take(3);
      foreach (var item in pegaValores2)
      {
        Console.WriteLine(item.Id);
      }
      Console.WriteLine("-------");



      Console.WriteLine("(WHERE) Achando valores de acordo com o ID ser maior que 3: ");
      var encontraValor = payment.Where(x => x.Id > 3);

      foreach (var encontraValorPayment in encontraValor)
      {
        Console.WriteLine(encontraValorPayment.Id);
      }
      Console.WriteLine("-------");



      Console.WriteLine("(Count) Conta quantos ID'S com 4 tem (adicionei + 2 valores com ID '4' ): ");
      payment.Add(new Payments(4));
      payment.Add(new Payments(4));

      var contaValor = payment.Count(x => x.Id == 4);

      Console.WriteLine("Lista com todos os IDS:");

      foreach (var item in payment)
      {
        if(item.Id == 4)
        {
          Console.WriteLine("Valor de ID '4' achado", item.Id);
        } else
        {
          Console.WriteLine(item.Id);
        }
      }
      Console.WriteLine("-");
      Console.WriteLine("-");
      Console.WriteLine($"Total de ID'S com numero 4: {contaValor}");

      Console.WriteLine("-------");



      Console.WriteLine("(Clear) Limpa a lista ");
      payment.Clear();
      foreach (var item in payment)
      {
        Console.WriteLine(item.Id);
      }
      Console.WriteLine("-------");


    }
  }

  public class Payments
  {
    public int Id { get; set; }

    public Payments(int id)
    {
      Id = id;
    }
  }
}

