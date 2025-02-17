namespace PersonTripManagment.Repository;

public interface IGroupRepository
{
    public Task<bool> CreateNewGroup();
    public Task<bool> DeleteGroup(int groupId);
    public Task<bool> AddPersonToTheGroup(int personId);
    public Task<bool> RemovePersonFromGroup(int personId);

}