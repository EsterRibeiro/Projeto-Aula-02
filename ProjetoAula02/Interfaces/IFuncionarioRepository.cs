using ProjetoAula02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula02.Interfaces
{

    /// <summary>
    /// Interface para abstração do repositório de funcionário
    /// </summary>
    public interface IFuncionarioRepository
    {
        #region Métodos abstratos
        void Exportar(Funcionario funcionario); //não usa public porque implicitamente todo método é publico em interfaces

        #endregion
    }
}
