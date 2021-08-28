using Interface_Apps.DataAccess.Abstract;
using Interface_Apps.DataAccess.Concrete;
using Interface_Apps.Entity;
using System;

namespace Interface_Apps
{

    class UrunManager : IUrunDeposu
    {
        IUrunDeposu _depo;
        public UrunManager(IUrunDeposu depo)
        {
            _depo = depo;
        }
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
            _depo.Olustur(entity);
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
    class Program
    {
        static void Main(string[] args)
        {
            //var urunDal = new MysqlUrunDal();
            //urunDal.Olustur(new Entity.Urun());

            //var urunDal = new EfUrunDal();
            //urunDal.Olustur(new Entity.Urun());

            var urunDeposu = new UrunManager(new MysqlUrunDal());
            urunDeposu.Olustur(new Urun());
        }
    }
}
