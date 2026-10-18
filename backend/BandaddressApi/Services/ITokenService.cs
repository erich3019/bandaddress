using BandaddressApi.Models;

namespace BandaddressApi.Services;

/// <summary>Stellt Bearer-Tokens für angemeldete Benutzer aus.</summary>
public interface ITokenService
{
    string CreateToken(User user);
}
