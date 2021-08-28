using Interface_Apps.DataAccess.Abstract;
using Interface_Apps.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Apps.DataAccess.Concrete
{
    class MysqlUrunDal : IUrunDeposu
    {
        public void Guncelle(Urun entity)
        {
            throw new NotImplementedException();
        }

        public Urun[] KategoriyeGoreUrunGetir(int id)
        {
            throw new NotImplementedException();
        }

        public Urun NumarayaGoreGetir(int id)
        {
            throw new NotImplementedException();
        }

        public void Olustur(Urun entity)
        {
            Console.WriteLine("MYSQL Urun - Oluştur.");
        }

        public Urun[] PopulerUrunGetir()
        {
            throw new NotImplementedException();
        }

        public void Sil(int id)
        {
            throw new NotImplementedException();
        }
    }
}
