using Abp.Application.Services;
using FlashTest.MultiTenancy.Dto;

namespace FlashTest.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

