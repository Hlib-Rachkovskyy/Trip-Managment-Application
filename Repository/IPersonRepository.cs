using PersonTripManagment.Model;

namespace PersonTripManagment.Repository;

public interface IPersonRepository
{
    public Task<ICollection<Person?>?> GetListOfAllPerson();
    public Task<Person?> GetPersonById(int id);
}