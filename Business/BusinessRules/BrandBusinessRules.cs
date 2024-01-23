using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public class BrandBusinessRules
    {

        private readonly IBrandDal _brandDal;

        public BrandBusinessRules(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void CheckIfBrandNameNotExists(string brandName)
        {
            bool isExists = _brandDal.Get(brand => brand.Name == brandName) is not null;
            if (isExists)
            {
                throw new BusinessException("Brand aldready exists."); 
            }

            #region İlk kullanım
            //bool isExists = _brandDal.GetList().Any(brand => brand.Name == brandName);
            
            ////>Brandler üzerinde bir liste alıp Any methodu ile koleksiyonu tek tek gezecek, Name == brandName ile soru ifadesi olarak geziyor)

            ////Kısaca:Listede adı eşit olan herhangi bir öğe olup olmadığını kontrol etmek için

         
            //    if (isExists)
            //    {
            //        throw new BusinessException("Brand aldready exists."); //Varsa hata fırlatacak
            //    }
            #endregion

        }
    }
}
