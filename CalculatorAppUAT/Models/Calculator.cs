using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CalculatorAppUAT.Models
{
    public class Calculator
    {
        [Required(ErrorMessage = "Enter a number")]
        [Display(Name = "1. number")]
        public double FirstNumber { get; set; }
        [Required(ErrorMessage = "Enter a number")]
        [Display(Name = "2. number")]
        public double SecondNumber { get; set; }
        public double Result { get; set; }
        public string Operation { get; set; }

        public List<SelectListItem> PossibleOperations { get; set; } = new List<SelectListItem>
        {
            new SelectListItem { Text = "Add", Value = "+", Selected = true },
            new SelectListItem { Text = "Subtract", Value = "-" },
            new SelectListItem { Text = "Multiply", Value = "*" },
            new SelectListItem { Text = "Divide", Value = "/" }
        };

        public void Count()
        {
            switch (Operation)
            {
                case "+":
                    Result = FirstNumber + SecondNumber;
                    break;
                case "-":
                    Result = FirstNumber - SecondNumber;
                    break;
                case "*":
                    Result = FirstNumber * SecondNumber;
                    break;
                case "/":
                    Result = FirstNumber / SecondNumber;
                    break;
            }
        }
    }
}
