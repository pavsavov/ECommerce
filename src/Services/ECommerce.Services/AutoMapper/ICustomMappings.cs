using AutoMapper;

namespace ECommerce.Services.AutoMapper
{
    public interface IHaveCustomMappings
    {
        void CreateMappings(IProfileExpression configuration);
    }
}
