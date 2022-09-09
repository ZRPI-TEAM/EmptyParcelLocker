using System.Security.AccessControl;
using EmptyParcelLocker.API.Data.Models;

namespace EmptyParcelLocker.API.Test.MockData;

public class LockerMockData
{
    private static readonly Random _random = new Random();
    
    public static List<Locker> GetLockers(int quantity)
    {
        var lockerTypes = LockerTypeMockData.GetLockerTypes();
        var lockers = new List<Locker>();

        for (var i = 0; i <= quantity; i++)
        {
            var randomLockerType = lockerTypes[_random.Next(0, 3)];
            var locker = new Locker
            {
                Id = Guid.NewGuid(),
                IsEmpty = _random.Next(0, 100) % 2 == 0,
                LockerType = randomLockerType,
                LockerTypeId = randomLockerType.Id,
            };
            
            lockers.Add(locker);
        }

        return lockers;
    }
}