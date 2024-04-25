using Utility;
using Utility.Enum;

namespace DAL.Entities
{
    
    public class SocielMediaUser
    {
        // primary KEY
        public int SocielMediaUserId { get; set; }

        // Foriegn key 
        public string UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;


        public SocialMediaType SocielMediaType { get; set; }
        public string URL { get; set; }                                                  
        
        
    }
    
}
