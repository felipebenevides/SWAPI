using System;
using System.Collections.Generic;
using System.Text;

namespace SWAPI.Domain.Interfaces.Interface
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Incluir(TEntity entity);

        void Excluir(Object id);

        void Alterar(TEntity entity);

        IEnumerable<TEntity> Listar();

        TEntity Obter(Object id);
    }
}
