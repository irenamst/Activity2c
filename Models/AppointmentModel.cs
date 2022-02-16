using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Activity2c.Models
{
    public class AppointmentModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20,MinimumLength =4)]
        [DisplayName("Patient's full name")]
        public string PatientName { get; set; }
        [DisplayName("Appointment Request Date")]
        [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set; }
        [DisplayName("Patient's Approximate Net Worth")]
        [DataType(DataType.Currency)]
        public decimal PatientNetWorth { get; set; }
        [DisplayName("Private Doctor's Last Name")]
        public string DoctorName { get; set; }
        [DisplayName("Patient Peceved Level of Pain (1 low to 10 high)")]
        [Range(1,10)]
        public int PainLevel { get; set; }
        [DisplayName("Street")]
        public string Street { get; set; }
        [DisplayName("City")]
        public string City { get; set; }
        [DisplayName("Zip Code")]
        [DataType(DataType.PostalCode)]
        [StringLength(4)]
        public string ZipCode { get; set; }
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DisplayName("Phone")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
    }
}
