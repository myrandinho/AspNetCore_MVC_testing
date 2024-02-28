

using Infrastructure.Factories;
using Infrastructure.Models;
using Infrastructure.Repositories;

namespace Infrastructure.Services;

public class UserService(UserRepository userRepository, AdressService adressService)
{
    private readonly UserRepository _userRepository = userRepository;
    private readonly AdressService _adressService = adressService;



    public async Task<ResponsResult> CreateUserAsync(SignUpModel model)
    {
        try
        {
            var result = await _userRepository.AlreadyExistsAsync(x => x.Email == model.Email);
            if (result.SatusCode != StatusCode.EXISTS)
            {
                result = await _userRepository.CreateOneAsync();
            }
        }
        catch (Exception ex) { return ResponseFactory.Error(ex.Message); }
    }
}
