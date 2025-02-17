using PersonTripManagment.Model;

namespace PersonTripManagment.Repository;

public interface IPersonRepository
{
    public Task<bool> AddPersonInSystem();
    public Task<bool> DeletePersonFromSystem();
    public Task<Person?> ModifyPersonData();
    public Task<bool> WriteMoneyThatWasPaid(string currency, double value);
    public Task<ICollection<Person?>?> GetListOfAllPersonInTripByTripId(int tripId);
    // SELECT * FROM Person p
    // INNER JOIN PersonTrip pt on p.Id = pt.Person_Id
    // INNER JOIN PersonGroup pg on p.Id = pg.Person_Id
    // INNER JOIN TripPersonGroup tpg on pg.Group_Id = tpg.PersonGroup_Group_Id 
    // AND tpg.Trip_Id = @tripId
    public Task<ICollection<Person?>?> GetListOfAllPerson();
    // SELECT * FROM Person
    public Task<Person?> GetPersonById(int id);
    // SELECT * FROM Person WHERE Id = @id
}