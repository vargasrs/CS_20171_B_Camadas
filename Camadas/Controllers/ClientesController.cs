using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{  
    // aqui eh que vai conversar com BD. Por exemplo, a edicao vai mandar para banco.
    
    public class ClientesController
    {
      // aqui por enquanto trabalhamos com uma lista de clientes, pois ainda nao tem tabela
      // o static serve para dizer que todos poderao usar ela.
      // por exemplo, se compro um GOL nao quer dizer que ninguem podera comprar mais gol
      private static List<Cliente> listaClientes = new List<Cliente>();

      public void Adicionar(string nome, string cpf)
      {
        // crio objeto
        Cliente c = new Cliente();
        c.Nome = nome;
        c.Cpf = cpf;
       // salvo objeto na lista
        listaClientes.Add(c);
      }

      // vai procurar cliente na lista e retorna 
      public Cliente Detalhes(int id)
      {
        foreach (Cliente cli in listaClientes)
        {
          // ao encontrar codigo cliente retorna codigo e sai do laco
          if (cli.ClienteID == id)
            return cli;
        }
        return null;
      }

      //
      public void Editar(int id, string nome, string cpf)
      {
        foreach (Cliente cli in listaClientes)
        {
          if (cli.ClienteID == id)
          {
            cli.Nome = nome;
            cli.Cpf = cpf;
          }
        }
      }


    //
    public void Excluir(int id)
    {
      foreach (Cliente cli in listaClientes)
      {
        if (cli.ClienteID == id)
          listaClientes.Remove(cli);
      }
    }

  }



}

