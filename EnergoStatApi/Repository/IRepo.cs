using EnergoStatApi.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;

namespace EnergoStatApi.Repository
{
    public interface IRepo<T> where T : IIdentifiable
    {
        bool Add(T item);

        bool Update(T item);

        bool Remove(T item);

        bool Get(T item);

        IEnumerable<T> GetAll();
    }

    public enum TransitionMethod
    {
        Portal,
        Operator,
        LK_TES
    }

}
