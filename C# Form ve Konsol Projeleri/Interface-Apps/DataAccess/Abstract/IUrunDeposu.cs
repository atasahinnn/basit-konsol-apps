using Interface_Apps.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Apps.DataAccess.Abstract
{
    public interface IUrunDeposu:IDepom<Urun>
    { 
        Urun[] KategoriyeGoreUrunGetir(int id);
        Urun[] PopulerUrunGetir();
        
    }
}
