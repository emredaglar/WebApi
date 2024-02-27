using Business.Dtos.Requists;
using Business.Dtos.Responses;
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
                                           //brand ile değişti
        CreatedBrandPesponse Add(CreateBrandRequest createBrandRequest);
       //brand ile değişti
        List<GetAllBrandPesponse> GetAll();
    }
}
//response and request
//istekler ve yanıtlar
