﻿using Server.Model.Account.Entity;
using Server.Model.Token.Dto;

namespace Server.Service.Interface;

public interface IAuthService
{
    Task<bool> RegisterAsync(string playerId, string password, string email);
    Task<TokenResponse?> LoginAsync(string playerId, string password);
}