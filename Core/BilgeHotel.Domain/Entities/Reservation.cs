using BilgeHotel.Domain.Entities.Common;
using BilgeHotel.Domain.Entities.Identity;

namespace BilgeHotel.Domain.Entities
{
    public class Reservation:BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal RealPrice { get; set; }

        public decimal? RefuendedPrice { get; set; }
        public string? CancelDescription { get; set; }

        public bool? IsPayyed { get; set; }
        //Mapping 
        public int ReservationTypeId { get; set; }
        public ReservationType reservationType { get; set; }
        public int ReservationStateId { get; set; }
        public ReservationState reservationState { get; set; }
        public int CustomerId { get; set; }
        public Customer customer { get; set; }
        public int RoomId {  get; set; }
        public Room room { get; set; }
        public string? EmployeId { get; set; }
        public Employee? employee { get; set; }
    }
}