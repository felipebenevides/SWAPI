using System;
using System.Collections.Generic;
using System.Text;

namespace SWAPI.Domain.Interfaces.Service
{
    public interface IService<TEntity> : IDisposable where TEntity :class
    {
        //Se o Objetivo da Tarefa fosse consumir e salvar no Banco usando Entity

        void Incluir(TEntity entity);
        //Uso Object id parar caso tenh uma chave primaria diferente de int
        void Excluir(Object id);

        void Alterar(TEntity entity);

        IEnumerable<TEntity> Listar();

        TEntity Obter(Object id);

    }
}
