using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {

        /// <summary>
        /// belli bir tipteki cache değeri okunmaya çalışır
        /// yani key değerini vericez ve onu hangi tipte istiyorsak
        /// onun bize geri verilmesini sağlayacağız
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        T Get<T>(string key);

        /// <summary>
        /// T Get gibi bunu object olarak da alabiliriz
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        object Get(string key);

        /// <summary>
        /// cache e ekler
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        /// <param name="duration"></param>
        void Add(string key, object data, int duration);

        /// <summary>
        /// cache'e eklenmiş mi diye bakar
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        bool IsAdd(string key);

        /// <summary>
        /// belli bir keydeki cache'in ortadan kaldırılmasını sağlar
        /// </summary>
        /// <param name="key"></param>
        void Remove(string key);

        /// <summary>
        /// belli bir patter a uyan cache'leri siler
        /// (örneğin get ile başlayanları)
        /// </summary>
        /// <param name="pattern"></param>
        void RemoveByPattern(string pattern);

    }
}
