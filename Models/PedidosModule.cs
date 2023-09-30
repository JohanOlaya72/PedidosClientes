using ServicioClientesPedidos.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioClientesPedidos.Models
{
    public class PedidosModule
    {

        private string cliente;

        public PedidosModule(string cliente) 
        {
            this.cliente = cliente;
        }  

        public List<DBCliente> getpedidos()
        {
            List<DBCliente> dBClientes = new List<DBCliente>();
            DBModule dBModule = new DBModule(cliente);

            dBClientes = dBModule.setData();
            
            return dBClientes;
        }
    }
}