using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {//object bütün koleksiyonların base i dir dolayısı ile buraya her şeyi atayabiliriz
        void Add(string key, object value, int duration);//duration cache de ne kadr duracak onu belirlemek için, dakika ve saat çinsinden verebiliriz
       
        T Get<T>(string key);

        object Get(string key);

        bool IsAdd(string key);//cache de var mı kontrolu iççin yazılan metot

        void Remove(string key);//cacheden uçurma silme 

        void RemoveByPattern(string pattern);// başı sonu önemli değil içinde get/category olanları silme 
    }
}
