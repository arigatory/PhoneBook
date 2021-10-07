using System.ComponentModel.DataAnnotations;

namespace PhoneBook.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите фамилию")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите имя")]
        public string FirstName {  get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите отчество")]
        public string MiddleName {  get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите телефон")]
        public string Phone {  get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите адрес")]
        public string Address {  get; set; }
        public string Description {  get; set; }
    }
}
