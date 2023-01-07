
using System.ComponentModel.DataAnnotations.Schema;

namespace TechnoSewa.Models
{
    public class SubmitProblemModel
    {
        public int id { get; set; }
        public string Pipe_Leakage { get; set; } = String.Empty;
        public string Tap_Replacement { get; set; } = String.Empty;
        public string Basin_Replacement { get; set; } = String.Empty;
        public string Commode_Replacement { get; set; } = String.Empty;
        public string Other_Problems { get; set; } = String.Empty;


        
        [ForeignKey("UserId")]
        public virtual registerModel User { get; set; }

       // [ForeignKey("UserName")]
       // public virtual ProfileClass Profile{ get; set; }
        //[ForeignKey( "PhoneNumber")]
        //public virtual ProfileClass Profile2 { get; set; }
        //[ForeignKey( "Address")]
        //public virtual ProfileClass Profile3 { get; set; }

        //[ForeignKey("U")]
        //public virtual ProfileClass Profile { get; set; }
        //[ForeignKey("UserName")]
        //public virtual ProfileClass Profile { get; set; }

    }
}
