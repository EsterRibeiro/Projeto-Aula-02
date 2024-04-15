using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  ProjetoAula02.Interfaces;
using ProjetoAula02.Entities;
using System.Xml.Serialization;

namespace ProjetoAula02.Repositories
{

    /// <summary>
    /// Classe para implementação do repositório de funcionário para tipo XML
    /// </summary>
    public class FuncionarioRepositoryXML : IFuncionarioRepository
    {
        public void Exportar(Funcionario funcionario) { 
        
            //serialozar os dados do funcionário para formato XML
            var xmlSerializer = new XmlSerializer(typeof(Funcionario));

            //abrir um arquivo em modo de escrita
            var streamWriter = new StreamWriter($@"c:\temp\funcionario_{funcionario.Id}.xml");

            //escrever os dados do funcionário no arquivo
            xmlSerializer.Serialize(streamWriter, funcionario);

            //fechar o arquivo
            streamWriter.Close();
        }
    }
}
