using Abp.Application.Services;
using FlashTest.DisplayNumberHistory.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlashTest.DisplayNumberHistory
{
    public interface IDisplayNumberHistoryService : IApplicationService
    {
        Task<DisplayNumberHistory> CreateDisplayNumberHistoryAsync(CreateDisplayNumberHistoryInput input);

        Task<List<DisplayNumberHistory>> GetDisplayNumberHistoriesAsync();
    }
}
