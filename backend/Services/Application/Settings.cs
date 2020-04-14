namespace TheRainyCoders.Trainer.Backend.Services.Application
{
    /// <summary>
    ///     Provide application wide settings.
    /// </summary>
    internal class Settings
    {
        /// <summary>
        ///     Base path for all web API controllers.
        /// </summary>
        public const string WebApiControllerBasePath = "api/v{v:apiVersion}/[controller]";
    }
}