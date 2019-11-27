using System;
using System.Collections.Generic;
using System.Text;

namespace SWAPI.Application.Interfaces
{
    public interface IAppService<TEntity> : IDisposable where TEntity : class
    {
        void Incluir(TEntity entity);

        void Excluir(Object id);

        void Alterar(TEntity entity);

        IEnumerable<TEntity> Listar();

        TEntity Obter(Object id);
    }
}
