﻿using MagicVilla_Web.Models;

namespace MagicVilla_Web.Services.IServices
{
    public interface IBaseService
    {
        APIRespone ResponeModel { get; set; }
        Task<T> SendAsync<T>(APIRequest apiRequest);
    }
}
