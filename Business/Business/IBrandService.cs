using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Business
{
    public interface IBrandService
    {
        //void değil brand.Yani bana bir marka ver sana verdiğin markayı döndüreyim
       //response          //request
        CreatedBrandResponse Add(CreateBrandRequest brand);
        List<Brand> GetAll();
    }
}
//response and request
//istekler ve yanıtlar
