using Business.Business;
using Business.Dtos.Requists;
using Business.Dtos.Responses;
using DataAccess.Business;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandal = brandDal;
        }

        public CreatedBrandPesponse Add(CreateBrandRequest createBrandRequest)
        {
            //business rules( iş kurallarını burda üstte oluşturmamız lazım)

            //amaç veritabanı nesnesini kullanıcıya açmamak
            //mapping--> automapper kullancağız
            //gelen requsti(istek-bilgi) veri tabanı nesnesine dönüştürdük.
            Brand brand = new();
            brand.Name = createBrandRequest.Name;
            brand.CreatedDate=DateTime.Now;
            _brandal.Add(brand);

            //mapping
            //veri tabanı nesnesini de response çevirip döndürüyoruz.
            CreatedBrandPesponse createdBrandPesponse = new CreatedBrandPesponse();
            //Normalde veri tabanından gelir simule ediyoruz.
            createdBrandPesponse.Name = brand.Name;
            createdBrandPesponse.Id = 1;
            createdBrandPesponse.CreatedDate = brand.CreatedDate;

            return createdBrandPesponse;
        }

        public List<GetAllBrandPesponse> GetAll()
        {
            List<Brand> brands = _brandal.GetAll();
            List<GetAllBrandPesponse> getAllBrandPesponses = new List<GetAllBrandPesponse>();
            foreach (var brand in brands)
            {
                GetAllBrandPesponse getAllBrandPesponse=new GetAllBrandPesponse();
                getAllBrandPesponse.Name= brand.Name;
                getAllBrandPesponse.Id=brand.Id;
                getAllBrandPesponse.CreatedDate= brand.CreatedDate;

                getAllBrandPesponses.Add(getAllBrandPesponse);


            }
            return getAllBrandPesponses;
        }
    }
}
