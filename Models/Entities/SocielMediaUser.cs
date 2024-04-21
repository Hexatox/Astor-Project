using Utility;
using Utility.Enum;

namespace Models.Entities
{
    
    public class SocielMediaUser
    {
        // primary KEY
        public int SocielMediaUserId { get; set; }

        // Foriegn key 
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; } = null!;


        public SocialMediaType SocielMediaType { get; set; }
        public string URL { get; set; }                                                  
        
        
    }
    
}
