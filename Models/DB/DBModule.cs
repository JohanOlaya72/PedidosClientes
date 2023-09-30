using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioClientesPedidos.Models.DB
{
    public class DBCliente
    {
        public string cliente {  get; set; }
        public long   pedido {  get; set; }
        public long   producto {  get; set; }
        public int    cantidad {  get; set; }
        public double valorLinea { get; set; }

    }
    public class DBModule
    {
        private List<DBCliente> dBClientes;
        string cliente;

        public DBModule(string cliente)
        {
            this.dBClientes = new List<DBCliente>();
            this.cliente = cliente;

            switch (cliente)
            {
                case "cliente_1": getData1(); break;
                case "cliente_2": getData2(); break;
                default: getData3(); break;
            }
    }

        private void getData1() 
        {
            DBCliente dBCliente = new DBCliente();
            dBCliente.cliente = "cliente_1";
            dBCliente.pedido = 212121;
            dBCliente.producto = 34522324;
            dBCliente.cantidad = 100;
            dBCliente.valorLinea = 1500000.0;
            this.dBClientes.Add(dBCliente);

            dBCliente = new DBCliente();
            dBCliente.cliente = "cliente_1";
            dBCliente.pedido = 313131;
            dBCliente.producto = 5323232;
            dBCliente.cantidad = 50;
            dBCliente.valorLinea = 2300000.0;
            this.dBClientes.Add(dBCliente);

            dBCliente = new DBCliente();
            dBCliente.cliente = "cliente_1";
            dBCliente.pedido = 414141;
            dBCliente.producto = 3222222;
            dBCliente.cantidad = 150;
            dBCliente.valorLinea = 7430000.0;
            this.dBClientes.Add(dBCliente);

            dBCliente = new DBCliente();
            dBCliente.cliente = "cliente_1";
            dBCliente.pedido = 212121;
            dBCliente.producto = 34522324;
            dBCliente.cantidad = 100;
            dBCliente.valorLinea = 1500000.0;
            this.dBClientes.Add(dBCliente);
        }
        private void getData2()
        {
            DBCliente dBCliente = new DBCliente();
            dBCliente.cliente = "cliente_2";
            dBCliente.pedido = 414141;
            dBCliente.producto = 3222222;
            dBCliente.cantidad = 100;
            dBCliente.valorLinea = 4000000.0;
            this.dBClientes.Add(dBCliente);

            dBCliente = new DBCliente();
            dBCliente.cliente = "cliente_2";
            dBCliente.pedido = 212121;
            dBCliente.producto = 34522324;
            dBCliente.cantidad = 50;
            dBCliente.valorLinea = 900000.0;
            this.dBClientes.Add(dBCliente);
        }

        private void getData3()
        {
            DBCliente dBCliente = new DBCliente();
            dBCliente.cliente = "Sin datos";
            dBCliente.pedido = 0;
            dBCliente.producto = 0;
            dBCliente.cantidad = 0;
            dBCliente.valorLinea = 0.0;
            this.dBClientes.Add(dBCliente);
        }

        public List<DBCliente> setData() 
        {
            return this.dBClientes;
        }
}
}