
using KonicaTracking.Data.Contracts;
using KonicaTracking.Models.Request;
using KonicaTracking.Models.Response;
using KonicaTracking.Services;
using KonicaTracking.Services.Auth;
using Microsoft.AspNetCore.Mvc;

namespace KonicaTracking.Controllers
{
    /// <summary>
    /// Controller for handling authentication-related API endpoints.
    /// </summary>
    [ApiController]
    [Route("api/auth")]
    public class AuthenticationController : Controller
    {
        private readonly ILogger<AuthenticationController> _logger;
        private readonly IUsersRepository _usersRepository;
        private readonly AppSettings _appSettings;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationController"/> class with the provided logger manager and users repository.
        /// </summary>
        /// <param name="loggerManager">The logger manager used for logging.</param>
        /// <param name="usersRepository">The repository for interacting with user data.</param>
        public AuthenticationController(ILogger<AuthenticationController> loggerManager, IUsersRepository usersRepository, AppSettings appSettings)
        {
            _logger = loggerManager;
            _usersRepository = usersRepository;
            _appSettings = appSettings;
        }

        /// <summary>
        /// HTTP POST action that authenticates a user using the provided credentials.
        /// </summary>
        /// <param name="user">User object that contains the username and password.</param>
        /// <returns>ActionResult object that indicates whether the authentication was successful or not.</returns>
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> LoginAsync([FromBody] AuthUserRequest user)
        {
            try
            {
                if (await _usersRepository.LoginUserAsync(user))
                {
                    AuthUserResponse userResponse = new AuthUserResponse()
                    {
                        Name = user.Name,
                        Token = TokenManager.GetToken(user, _appSettings.Secret),
                        Password = user.Password
                    };

                    await _usersRepository.RegisterTokenUserAsync(userResponse);
                    return Ok(MessageResponse<AuthUserResponse>.Success(userResponse));
                }

                _logger.LogWarning($"Unauthorized user {user.Name} name.");
                return Unauthorized($"Unauthorized user.");
            }
            catch (Exception ex)
            {
                _logger.LogWarning($"Unhandled error when trying to login user {user.Name} name. Message: {ex.Message}");
                return BadRequest(MessageResponse<String>.Fail($"Unhandled error when trying to login user {user.Name} name."));
            }
        }
    }
}
