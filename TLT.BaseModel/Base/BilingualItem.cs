#region

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Eventing.Reader;
using Microsoft.EntityFrameworkCore;
using TLT.Localization.Utility;

#endregion

namespace TLT.BaseModel.Base
{

    [Owned]
    public class BilingualItem
    {
        public BilingualItem() { }

        public BilingualItem(string name_fr, string name_nl)
        {
            FR = name_fr ?? string.Empty;
            NL = name_nl ?? string.Empty;
        }

        [Required]
        public string FR { get; set; }

        [Required]
        public string NL { get; set; }

        [NotMapped]
        public string InLocal
        {
            get
            {
                if (AppLanguage.IsNL) return !string.IsNullOrEmpty(NL) ? NL : FR;
                return FR;
            }
        }
    }

}