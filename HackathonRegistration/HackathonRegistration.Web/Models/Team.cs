namespace HackathonRegistration.Web.Models
{
    public class Team
    {
        public string Id { get; set; } = string.Empty;

        public string TeamName { get; set; } = string.Empty;

        /// <summary>
        /// Possible states are: US Central, Western Europe, East Asia
        /// </summary>
        public string EventTimezone { get; set; } = string.Empty;

        public string UseCase { get; set; } = string.Empty;

        public string SubscriptionId { get; set; } = string.Empty;

        public List<TeamMember> TeamMembers { get; } = new List<TeamMember>();
    }
}
