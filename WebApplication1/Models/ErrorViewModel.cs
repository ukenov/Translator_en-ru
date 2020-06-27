using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class Translation
    {
        [Display(Name = "Input Text")]
        public string InputTxt { get; set; }

        [Display(Name = "Display Text")]
        public string Result { get; set; }

        [Display(Name = "Language")]
        public ChooseLanguage ChooseLanguage { get; set; }

        [Display(Name = "Corection")]
        public string CorectedLng { get; set; }
    }

    public enum ChooseLanguage
    {
        Russian,
        English
    }
}