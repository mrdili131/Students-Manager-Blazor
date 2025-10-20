using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Components;
using Bogcha.Data;
using Bogcha.Models;

namespace Bogcha.Services
{
    public class AuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly NavigationManager _navigator;
        bool _Debug;

        public AuthService(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            NavigationManager navigator
        )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _navigator = navigator;
            _Debug = true;
        }

        public async Task<bool> RegisterAsync(string email, string username, string password, string FirstName, string LastName, string MiddleName, int BogchaId)
        {
            if (_Debug) { Console.WriteLine("AuthService.cs: RegisterAsync() is running ..."); }
            var user = new ApplicationUser
            {
                UserName = username,
                Email = email,
                FirstName = FirstName,
                LastName = LastName,
                MiddleName = MiddleName,
                BogchaId = BogchaId
            };
            if (_Debug) { Console.WriteLine("Creating user ..."); }
            var res = await _userManager.CreateAsync(user, password);

            if (res.Succeeded)
            {
                if (_Debug) { Console.WriteLine("User created !"); }
                return true;
            }
            else { if (_Debug) { Console.WriteLine("Could not create user !"); } }
            if (_Debug) { Console.WriteLine("RegisterAsync() returned false"); }
            return false;
        }

        public async Task<bool> LoginAsync(string username, string password)
        {
            if (_Debug) { Console.WriteLine("AuthService.cs: LoginAsync() is running ..."); }
            var res = await _signInManager.PasswordSignInAsync(username, password, false, false);
            if (res.Succeeded)
            {
                if (_Debug) { Console.WriteLine("LoginAsync() returned true"); }
                return true;
            }
            else
            {
                if (_Debug) { Console.WriteLine("LoginAsync() returned false"); }
                return false;
            }
        }

        public async Task<ApplicationUser?> GetCurrentUser()
        {
            return await _userManager.GetUserAsync(_signInManager.Context.User);
        }
        
        public bool IsAuthenticated()
        {
            return _signInManager.IsSignedIn(_signInManager.Context.User);
        }
    }
}