namespace PersonTripManagment.Repository;

public interface ITripRepository
{
    public Task<bool> CreateTrip();
    public Task<bool> ModifyTripData();
    public Task<bool> DeleteTrip();
    public Task<bool> AddPersonToTrip(int personId);
    public Task<bool> DeletePersonFromTrip(int personId);
    public Task<ICollection<Trip>> GetTripLists();
}