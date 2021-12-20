using Abp.Authorization;
using Abp.Domain.Repositories;
//using AutoMapper;
using FlashTest.Authorization;
using FlashTest.DisplayNumberHistory.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


using System.Linq;
using System.Text.RegularExpressions;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.Extensions;
using Abp.IdentityFramework;
using Abp.Linq.Extensions;
using Abp.Localization;
using Abp.Runtime.Session;
using Abp.UI;
using FlashTest.Authorization.Accounts;
using FlashTest.Authorization.Roles;
using FlashTest.Authorization.Users;
using FlashTest.Roles.Dto;
using FlashTest.Users.Dto;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;



namespace FlashTest.DisplayNumberHistory
{
    [AbpAuthorize(PermissionNames.Pages_Users)]
    public class DisplayNumberHistoryService : IDisplayNumberHistoryService
    {
        private readonly IRepository<DisplayNumberHistory> _repository;

        public DisplayNumberHistoryService(IRepository<DisplayNumberHistory> repository)
        {
            _repository = repository;
        }

        public async Task<DisplayNumberHistory> CreateDisplayNumberHistoryAsync(CreateDisplayNumberHistoryInput input)
        {
            var DisplayNumberHistory = new DisplayNumberHistory()
            {
                UserId = input.UserId,
                InputNumber = input.InputNumber,
                OutputResult = input.OutputResult,
                IsActive = input.IsActive,
                CreationTime = DateTime.Now
            };
            return await _repository.InsertAsync(DisplayNumberHistory);
        }

       
        public async Task<List<DisplayNumberHistory>> GetDisplayNumberHistoriesAsync()
        {
            return await _repository.GetAllListAsync();
        }
    }
}
