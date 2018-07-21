using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelBindingCalculator.Models
{
    public class Calculator
    {
        [Required(ErrorMessage ="Please enter number")]
        [Display(Name ="1. number")]
        public Nullable<int> Number1 { get; set; }        
        [Required(ErrorMessage ="Please enter number")]
        [Display(Name ="2. number")]
        public Nullable<int> Number2 { get; set; }  
        public Nullable<double> Result { get; set; }
        [Required(ErrorMessage ="Choose operation")]
        [Display(Name ="Operation")]
        public string Operation { get; set; }
        public List<SelectListItem> PosibleOperations { get; set; }

        public Calculator()
        {
            PosibleOperations = new List<SelectListItem>();
            PosibleOperations.Add(new SelectListItem { Text = "Add", Value = "+"});
            PosibleOperations.Add(new SelectListItem { Text = "Sub", Value = "-" });
            PosibleOperations.Add(new SelectListItem { Text = "Multiply", Value = "*" });
            PosibleOperations.Add(new SelectListItem { Text = "Divide", Value = "/" });
        }

        public void Calculate()
        {
            switch (Operation)
            {
                case "+":
                    Result = Number1 + Number2;
                    break;
                case "-":
                    Result = Number1 - Number2;
                    break;
                case "*":
                    Result = Number1 * Number2;
                    break;
                case "/":
                    try
                    {
                        Result = Number1 / Number2;
                    }
                    catch (Exception)
                    {
                        Result = null;
                    }
                    break;                
            }
        }
    }    
}