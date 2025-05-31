namespace HotelManagement.Logging
{
    public class AuditLogger
    {
        private readonly ILogger<AuditLogger> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AuditLogger(ILogger<AuditLogger> logger, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
        }

        public void Log(string action, string? details = null)
        {
            var user = _httpContextAccessor.HttpContext?.User?.Identity?.Name ?? "Anonymous";

            _logger.LogInformation("UserAction | User: {User} | Action: {Action} | Details: {Details}", user, action, details);
        }
    }
}
