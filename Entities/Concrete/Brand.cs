using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Brand:BaseEntity<int>
    {
        //araba kiralama şirketine ait arabalara ait bilgiler.     
        public string Name { get; set; }
       

    }
}
