using Business.Dtos.Brand;
using Entities.Concrete;

namespace Business
{
    public class GetBrandListResponse
    {
        public ICollection<BrandListItemDto> Items { get; set; }
        public GetBrandListResponse(ICollection<BrandListItemDto> items)
        {
            Items = items;
        }
        public GetBrandListResponse()
        {
            Items = Items;
        }

       
    }
}