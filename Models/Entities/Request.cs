namespace Models.Entities
{
    public class Request
    {
        public int RequestId { get; set; }
        public DateTime RequestDate { get; set; }

        // navigation Propriry `who Make the Request to be Auther`
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        // navigation Propriry `How Make the Request to be Auther`

        public string AdminId { get; set; }
        public ApplicationUser Admin { get; set; }


        public bool? Status { get; set; }
        public DateTime? AcceptDate { get; set; }
        public string? Notes { get; set; }
    }

}
