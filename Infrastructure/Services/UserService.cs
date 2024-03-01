

using Infrastructure.Entities;
using Infrastructure.Factories;
using Infrastructure.Helpers;
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
            var exists = await _userRepository.AlreadyExistsAsync(x => x.Email == model.Email);
            if (exists.StatusCode == StatusCode.EXISTS)
                return exists;

            var result = await _userRepository.CreateOneAsync(UserFactory.Create(model));
            if (result.StatusCode != StatusCode.OK) 
                return result;


            return ResponseFactory.Ok("User was created successfully.");
        }
        catch (Exception ex) { return ResponseFactory.Error(ex.Message); }
    }


    public async Task<ResponsResult> SignInUserAsync(SignInModel model)
    {
        try
        {
            var result = await _userRepository.GetOneAsync(x => x.Email == model.Email);
            if (result.StatusCode == StatusCode.OK && result.ContentResult != null)
            {
                var userEntity = (UserEntity)result.ContentResult;
                if (PasswordHasher.ValidateSecurePassword(model.Password, userEntity.Password, userEntity.SecurityKey))
                    return ResponseFactory.Ok();
            }

            return ResponseFactory.Error("Incorrect email or password");



        }
        catch (Exception ex) { return ResponseFactory.Error(ex.Message); }
    }
}
