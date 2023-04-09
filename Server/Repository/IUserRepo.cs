﻿using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using TicketHiveSpaceKittens.Server.Models;
using TicketHiveSpaceKittens.Shared;

namespace TicketHiveSpaceKittens.Server.Repository
{
    public interface IUserRepo
    {
        void AddUser(string username, string country);
        Task<bool> SignInUser(ApplicationUser newUser, string password, string country);
        Task<bool> ChangePassword(string currentPassword, string newPassword);
        Task<string> GetCountryAsync(string username);
        Task<bool> ChangeCountry(string newCountry);
    }
}
