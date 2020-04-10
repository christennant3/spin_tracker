﻿using Abp.AutoMapper;
using SpinTracker.Authentication.External;

namespace SpinTracker.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
