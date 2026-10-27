using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace CheckBoxesASPCore6.Models
{
    public class ViewModel
    {
       public List<CheckBoxOption> CheackBoxes { get; set; }
        public List<string> sports { get; set; }
    }


    //public class ViewModel
    //{
    //    public bool AcceptTerms { get; set; }
    //    public string Text { get; set; }
    //}

}
