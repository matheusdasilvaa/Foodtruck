using Foodtruck.Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foodtruck.Negocio.Persistencia;

namespace Foodtruck.Negocio
{
    public class Gerenciador
    {

        private Banco banco = new Banco();

        

        public Validacao AdicionarCliente(Cliente clienteAdicionado)
        {
            Validacao validacao = new Validacao();

            if(this.banco.Clientes.Where(c => c.Id == clienteAdicionado.Id).Any())
            {
                validacao.Mensagens.Add("Id", "Já existe um cliente com esse código");
            }

            if (String.IsNullOrEmpty(clienteAdicionado.Nome))
            {
                validacao.Mensagens.Add("Nome", "O nome não pode ser nulo ou vazio");
            }

            if (String.IsNullOrEmpty(clienteAdicionado.Email))
            {
                validacao.Mensagens.Add("Email", "O email não pode ser nulo ou vazio");
            }

            if (!clienteAdicionado.Email.Contains("@"))
            {
                validacao.Mensagens.Add("Email", "Email no formato inválido");
            }

            if (validacao.Valido)
            {
                this.banco.Clientes.Add(clienteAdicionado);
                this.banco.SalvarDados();
            }

            return validacao;
        }

        public List<Cliente> TodosOsClientes()
        {
            return this.banco.Clientes.ToList();
        }

        public void AdicionarLanche(Lanche lancheAdicionado)
        {
            this.banco.Lanches.Add(lancheAdicionado);
            this.banco.SalvarDados();
        }


    }
}
