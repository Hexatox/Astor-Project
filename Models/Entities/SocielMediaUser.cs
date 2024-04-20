using Utility;
using Utility.Enum;

namespace Models.Entities
{
    
    public class SocielMediaUser
    {
        public string Link { get; set; }

        // relations / navigations


        // those both <`ApplicationUserId`> and <`SocielMediaTypeId`> are Primary Key of this Entity
        public int ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; } = null!;
                                                            
        public SocialMediaType SocielMediaType { get; set; }
        
    }
    
}
