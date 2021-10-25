using AutoMapper;
using FinanceEnterprise.Entities.Finance.Models.humco;
using FinanceEnterpriseApi.Data.Dtos.Finance.humco;

namespace FinanceEnterpriseApi.Data.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PutGlTransactionGrantNotesParamsDto, GlTransactionGrantNote>();
        }
    }
}
