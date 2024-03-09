using CadastroClientes.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService1" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        void InsertClient(Cliente cliente);

        [OperationContract]
        void DeleteClient(int idCliente);
        
        [OperationContract]
        void UpdateClient(Cliente cliente);

        [OperationContract]
        Cliente GetClient(int idCliente);

        [OperationContract]
        List<Cliente>  GetClients();

    }
}
