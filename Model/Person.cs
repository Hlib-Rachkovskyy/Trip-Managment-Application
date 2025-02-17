namespace PersonTripManagment.Model;

public class Person
{
    
    private int Id { get; set; }
    private string Name { get; set; }
    private string BirthDay { get; set; }
    private string PhoneNumber { get; set; }
    private string Note { get; set; }
    private double TripCostPaid { get; set; }
    private double InsurancePaid { get; set; }
    private string DateWhenWasAdded { get; set; }
    private ICollection<int> GroupId { get; set; }
}