
using ECommerce.Models.BaseModel;
using ECommerce.Services.AutoMapper;

namespace ECommerce.Services.Models.Book.ServiceModels
{
    public class BookServiceModel : ServiceModel, IMapTo<BaseDbModel>,IMapFrom<BaseDbModel>
    {
        public string ISBN { get; set; }
    }
}
