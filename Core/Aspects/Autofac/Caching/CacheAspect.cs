using Core.CrossCuttingConcerns.Caching;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Castle.DynamicProxy;
using System.Linq;

namespace Core.Aspects.Autofac.Caching
{
    public class CacheAspect : MethodInterception
    {
        private int _duration;
        private ICacheManager _cacheManager;

        public CacheAspect(int duration = 60)
        {
            _duration = duration;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }

        public override void Intercept(IInvocation invocation)
        {// namespace, ismi, metot ismi ve parametrelerine göre key oluşturur eğer bu key daha önce varsa direkt cacheden al yoksa veritabanından al ama cache ekle   
            var methodName = string.Format($"{invocation.Method.ReflectedType.FullName}.{invocation.Method.Name}");//bu meteot namespace ve classın ismini verir .ikinci metotda metoodun ismini verir 
            var arguments = invocation.Arguments.ToList();
            var key = $"{methodName}({string.Join(",", arguments.Select(x => x?.ToString() ?? "<Null>"))})";//key oluşturma, string.Join bir araya getir demek , ?? iki soru işareti varsa ilkini ekle yoksa ikinci yani null ı ekle
            if (_cacheManager.IsAdd(key))//var mı diye kontrol eder
            {
                invocation.ReturnValue = _cacheManager.Get(key);//returnvalue, kendimiz manuel olarak return oluştururuz ve cachedeki datadan getir demek 
                return;
            }
            invocation.Proceed();//metodu devam ettir demek 
            _cacheManager.Add(key, invocation.ReturnValue, _duration);
        }
    }
}
