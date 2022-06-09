using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Controllers;
using WebApplication1.Models;

namespace WebApplication1.Hubs
{
    public class ChatHub:Hub
    {
       

        private readonly UserManager<AppUser> _usermanager;
     

        public ChatHub(ILogger<HomeController> logger, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _usermanager = userManager;
        }
        public async Task SendMessage(string user,string message)
        {
            await Clients.All.SendAsync("RecieveMessage",user,message,DateTime.Now.ToString("dddd, dd MMMM yyyy"));
            
        }

        public override Task OnConnectedAsync()
        {
            if (Context.User.Identity.IsAuthenticated)
            {
                AppUser user = _usermanager.FindByNameAsync(Context.User.Identity.Name).Result;
                user.ConnectionId = Context.ConnectionId;
                var result = _usermanager.UpdateAsync(user).Result;
            }
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            if (Context.User.Identity.IsAuthenticated)
            {
                AppUser user = _usermanager.FindByNameAsync(Context.User.Identity.Name).Result;
                user.ConnectionId = null;
                var result = _usermanager.UpdateAsync(user).Result;
            }
           
            return base.OnDisconnectedAsync(exception);
        }
    }
}
