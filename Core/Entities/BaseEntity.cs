using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    //TId generic bir yapıdır. T typedan geliyor.
    //İnt yada string olabilir o yüzden özel bir veri türü.
    public class BaseEntity<TId>
    {
        //araba kiralama şirketine ait arabalara ait bilgiler.
        public TId Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        //? Nullable demek. Yani illa oluşturmak zorunda
        //değilsin
        public DateTime? DeleteDate { get; set; }

    }
}
