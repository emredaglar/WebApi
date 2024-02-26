using DataAccess.Business;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    internal class BrandDal : IBrandDal
    {   //Burda farklı bir veritabanı türü olabilirdi.
        //Bize EFDal kullanıyoruz.İnmemory çalışıyoruz
        List<Brand> _brands;

        public BrandDal()
        {
            _brands = new List<Brand>();
            _brands.Add(new Brand { Id = 1, Name = "BMW", CreatedDate = DateTime.Now });
            _brands.Add(new Brand { Id = 2, Name = "Mercede", CreatedDate = DateTime.Now });
            _brands.Add(new Brand { Id = 3, Name = "Ford", CreatedDate = DateTime.Now });

        }

        public void Add(Brand brand)
        {
            _brands.Add(brand);
        }

        public List<Brand> GetAll()
        {
            return _brands;
        }
    }
}
