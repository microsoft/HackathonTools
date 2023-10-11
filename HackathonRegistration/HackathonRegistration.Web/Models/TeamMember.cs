namespace HackathonRegistration.Web.Models
{
    public class TeamMember
    {
        public string Id { get; set; } = string.Empty;

        public string EmailAddress { get; set; } = string.Empty;

        /// <summary>
        /// Possible states are: Invited, Confirmed, Declined
        /// </summary>
        public string State { get; set; } = string.Empty;

        public DateTime RegistrationDate { get; set; } = DateTime.UtcNow;
    }
}
