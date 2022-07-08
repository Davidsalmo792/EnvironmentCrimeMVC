using System;
using System.ComponentModel.DataAnnotations;


namespace uppgift1VC.Models
{
    public class Errand
    {
        public string RefNumber { get; set; }
        public int ErrandID { set; get; }

        [Required(ErrorMessage = "Du måste fylla i platsen där brottet ha skett")]
        public string Place { set; get; }

        [Display(Name = "Vilken typ av brott?")]
        public string TypeOfCrime { set; get; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Du måste fylla i datum")]
        public DateTime DateOfObservation { set; get; }

        [Display(Name = "Fullständigt namn")]
        [Required(ErrorMessage = "Du måste fylla i ditt namn")]
        public string InformerName { set; get; }

        [RegularExpression(pattern: @"^[0]{1}[0-9]{1,3}-[0-9]{5,9}$", ErrorMessage = "skriv ett giltigt nummer")]
        [Display(Name = "Din telefon:")]
        [Required(ErrorMessage = "Du måste fylla i ditt telefonnummer")]

        public string InformerPhone { set; get; }
        public string Observation { set; get; }
        public string InvestigatorInfo { set; get; }
        public string InvestigatorAction { set; get; }
        public string DepartmentId { set; get; }
        public string EmployeeId { set; get; }
        public string StatusId { set; get; }



    }
}
