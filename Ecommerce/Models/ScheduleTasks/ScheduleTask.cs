namespace Ecommerce.Models.ScheduleTasks
{
    public partial class ScheduleTask 
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int Seconds { get; set; }
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the datetime when task was enabled last time
        /// </summary>
        public DateTime? LastEnabledUtc { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether a task is enabled
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether a task should be stopped on some error
        /// </summary>
        public bool StopOnError { get; set; }

        /// <summary>
        /// Gets or sets the datetime when it was started last time
        /// </summary>
        public DateTime? LastStartUtc { get; set; }

        /// <summary>
        /// Gets or sets the datetime when it was finished last time (no matter failed is success)
        /// </summary>
        public DateTime? LastEndUtc { get; set; }

        /// <summary>
        /// Gets or sets the datetime when it was successfully finished last time
        /// </summary>
        public DateTime? LastSuccessUtc { get; set; }
    }
}
