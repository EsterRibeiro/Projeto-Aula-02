using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula02.Entities
{

    /// <summary>
    /// comentário em forma de documentação
    /// Essa classe é um Modelo de Entidade
    /// </summary>
    public class Funcionario
    {
        //ajuda a organizar o código
        #region Propriedades 
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public DateTime DataAdmissao { get; set; }
        public decimal Salario { get; set; }
        #endregion

        #region Relacionamentos
        public Endereco Endereco { get; set; }
        #endregion

    }
}
