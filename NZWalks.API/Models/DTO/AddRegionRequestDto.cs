namespace NZWalks.API.Models.DTO
{
    /// <summary>
    /// Region DTO
    /// </summary>
    public class AddRegionRequestDto
    {
        /// <summary>
        /// Ayush v8
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Ayush v8
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Class
        /// </summary>
        public string? RegionImageUrl { get; set; }
    }
}
