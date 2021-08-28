using System;
using System.Collections.Generic;
using System.Text;
using Interface_Apps.Entity;
using Interface_Apps.DataAccess.Abstract;


namespace Interface_Apps.DataAccess.Concrete
{
    public class EfUrunDal : IUrunDeposu
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
            Console.WriteLine("efUrun - Oluştur.");
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

