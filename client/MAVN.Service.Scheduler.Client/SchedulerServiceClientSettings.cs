using Lykke.SettingsReader.Attributes;

namespace MAVN.Service.Scheduler.Client 
{
    /// <summary>
    /// Scheduler client settings.
    /// </summary>
    public class SchedulerServiceClientSettings 
    {
        /// <summary>Service url.</summary>
        [HttpCheck("api/isalive")]
        public string ServiceUrl {get; set;}
    }
}
