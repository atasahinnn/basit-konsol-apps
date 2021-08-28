using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Apps.DataAccess.Abstract
{
    public interface IDepom<TEntity>
    {
        TEntity NumarayaGoreGetir(int id);


        void Guncelle(TEntity entity);


        void Olustur(TEntity entity);


        void Sil(int id);
    }
}
