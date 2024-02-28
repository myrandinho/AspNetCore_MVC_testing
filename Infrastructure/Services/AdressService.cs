

using Infrastructure.Entities;
using Infrastructure.Factories;
using Infrastructure.Models;
using Infrastructure.Repositories;

namespace Infrastructure.Services;

public class AdressService(AdressRepository adressRepository)
{
    private readonly AdressRepository _adressRepository = adressRepository;




    public async Task<ResponsResult> GetOrCreateAdressAsync(string streetName, string postalCode, string city)
    {
        try
        {
            var result = await GetAdressAsync(streetName, postalCode, city);
            if (result.StatusCode == StatusCode.NOT_FOUND) 
                result = await CreateAdressAsync(streetName, postalCode, city);

            return result;
            
        }
        catch (Exception ex) { return ResponseFactory.Error(ex.Message); }
    }


    public async Task<ResponsResult> CreateAdressAsync(string streetName, string postalCode, string city)
    {
        try
        {
            var exists = await _adressRepository.AlreadyExistsAsync(x => x.StreetName == streetName && x.PostalCode == postalCode && x.City == city);
            if ( exists == null)
            {
                var result = await _adressRepository.CreateOneAsync(AdressFactory.Create(streetName, postalCode, city));
                if (result.StatusCode == StatusCode.OK)
                {
                    return ResponseFactory.Ok(AdressFactory.Create((AdressEntity)result.ContentResult!));
                }

                return result;
                
            }

            return exists;
        }
        catch (Exception ex) { return ResponseFactory.Error(ex.Message); }
    }




    public async Task<ResponsResult> GetAdressAsync(string streetName, string postalCode, string city)
    {
        try
        {
            var result = await _adressRepository.GetOneAsync(x => x.StreetName == streetName && x.PostalCode == postalCode && x.City == city);
            return result;
        }
        catch (Exception ex) { return ResponseFactory.Error(ex.Message); }
    }
}
