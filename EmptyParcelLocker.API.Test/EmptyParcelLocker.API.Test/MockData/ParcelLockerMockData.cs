using System.Net.Sockets;
using EmptyParcelLocker.API.Data.Models;

namespace EmptyParcelLocker.API.Test.MockData;

public class ParcelLockerMockData
{
    private static readonly Random _random = new();
    
    public static List<ParcelLocker> GetParcelLockers(int quantity)
    {
        var parcelLockers = new List<ParcelLocker>();
        
        for (var i = 0; i < quantity; i++)
        {
            var lockers = LockerMockData.GetLockers(_random.Next(3, 13));
            
            var parcelLocker = new ParcelLocker
            {
                Id = Guid.NewGuid(),
                Name = $"ParcelLocker{i}",
                Address = $"street{i};houseNumber{i};ApartmentNumber{i};{i}{i}-{i}{i}{i};City{i}",
            };
            
            foreach (var locker in lockers)
            {
                locker.ParcelLocerId = parcelLocker.Id;
            }

            parcelLocker.Lockers = lockers;
            parcelLockers.Add(parcelLocker);
        }

        return parcelLockers;
    }
}