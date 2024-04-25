namespace DAL.Entities
{
    public class UserReview
    {
        public int UserReviewId { get; set; }

        public string UserId { get; set; } // navigate who make the Review
        public ApplicationUser User { get; set; } 

        public string ReviewToId { get; set; }    // this navigate review to 
        public ApplicationUser ReviewTo { get; set; }

        public DateTime ReviewDate { get; set; }    
        public byte Rate { get; set; }
        public string Messege {  get; set; }

    }
}
