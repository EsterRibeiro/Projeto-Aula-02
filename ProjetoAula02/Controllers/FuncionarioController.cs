using ProjetoAula02.Entities;
using ProjetoAula02.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula02.Controllers;
/// <summary>
/// Controlador para a realização de fluxos com funcionário
/// </summary>
public class FuncionarioController
{
    /// <summary>
    /// Método para realização do fluxo de cadastro de funcionário
    /// </summary>
    public void CadastrarFuncionario()
    {
        #region Capturar os dados do funcionário e endereço

        Console.WriteLine("Cadastro de funcionário\n");

        var funcionario = new Funcionario() {
            Id = Guid.NewGuid(),
            Endereco = new Endereco()
            {
                Id = Guid.NewGuid(),
            }
        };

        Console.Write("Nome do funcionario: ");
        funcionario.Nome = Console.ReadLine();

        Console.Write("CPF: ");
        funcionario.Cpf = Console.ReadLine();

        Console.Write("Matricula: ");
        funcionario.Matricula = Console.ReadLine();

        Console.Write("Salário: ");
        funcionario.Salario = decimal.Parse(Console.ReadLine());

        Console.Write("Data de admissao: ");
        funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

        Console.Write("Logradouro: ");
        funcionario.Endereco.Logradouro = Console.ReadLine();

        Console.Write("Numero: ");
        funcionario.Endereco.Numero = Console.ReadLine();

        Console.Write("Complemento: ");
        funcionario.Endereco.Complemento = Console.ReadLine();

        Console.Write("Bairro: ");
        funcionario.Endereco.Bairro = Console.ReadLine();

        Console.Write("Localidade: ");
        funcionario.Endereco.Localidade = Console.ReadLine();

        Console.Write("UF: ");
        funcionario.Endereco.Uf = Console.ReadLine();

        Console.Write("CEP: ");
        funcionario.Endereco.Cep = Console.ReadLine();

        #endregion

        #region Exportar para arquivo XML

        var funcionarioRepositoryXml = new FuncionarioRepositoryXML();
        funcionarioRepositoryXml.Exportar(funcionario);

        Console.WriteLine("\nDados Gravados com Sucesso!");

        #endregion

    }
}
