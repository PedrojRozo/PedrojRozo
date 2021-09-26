using System;
using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioCliente: IRepositorioCliente
    
    {
        private readonly AplicacionContext _appContext;

        public RepositorioCliente (AplicacionContext appContext){
            _appContext = appContext;
        }

        public Cliente AddCliente(Cliente cliente)
        {
            var nuevo_cliente = _appContext.Add(cliente);
            _appContext.SaveChanges();
            return nuevo_cliente.Entity;

        }

        public void DeleteCliente(int idCliente)
        {
            var cliente_encontrado = _appContext.Clientes.FirstOrDefault(
                p => p.Id == idCliente

            ); 

            if (cliente_encontrado == null)
            return;
            _appContext.Remove(cliente_encontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Cliente> GetAllCliente()
        {
            return _appContext.Clientes;

        }

        public Cliente GetCliente(int idCliente)
        {
            return _appContext.Clientes.FirstOrDefault(
                p => p.Id == idCliente 
            );
        }

        public Cliente UpdateCliente(Cliente cliente)
        {
            var cliente_encontrado = _appContext.Clientes.FirstOrDefault(
                p => p.Id == cliente.Id

            );
            if(cliente_encontrado !=null)
            {
                cliente_encontrado.Nombre =cliente.Nombre;
                cliente_encontrado.Edad = cliente.Edad;
                cliente_encontrado.Tipo_Documento = cliente.Tipo_Documento;
                cliente_encontrado.Documento = cliente.Documento;
                _appContext.SaveChanges();

            }
            return cliente_encontrado;

        }
    }
}