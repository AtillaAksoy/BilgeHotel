using BilgeHotel.Application.Repositories.Token;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Employee.Commands.Login
{
    public class LoginEmployeeCommandHandler : IRequestHandler<LoginEmployeeCommandRequest, LoginEmployeeCommandResponse>
    {
        private readonly UserManager<BilgeHotel.Domain.Entities.Identity.Employee> _userManager;
        private readonly SignInManager<BilgeHotel.Domain.Entities.Identity.Employee> _signInManager;
        private readonly ITokenHandler _tokenHandler;
        public LoginEmployeeCommandHandler(UserManager<Domain.Entities.Identity.Employee> userManager, SignInManager<Domain.Entities.Identity.Employee> signInManager, ITokenHandler tokenHandler)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenHandler = tokenHandler;
        }
        public async Task<LoginEmployeeCommandResponse> Handle(LoginEmployeeCommandRequest request, CancellationToken cancellationToken)
        {
           var user = await _userManager.FindByNameAsync(request.UserNameOrEmail);
            if (user == null) user = await _userManager.FindByEmailAsync(request.UserNameOrEmail);
            if (user == null)
            {
                throw new Exception("Kullanıcı bulunamadı");
            }

         var result =  await   _signInManager.CheckPasswordSignInAsync(user, request.Password,false);
            if (result.Succeeded)//Auth True
            {
                //yetkiler belirlenecek
              var token =  _tokenHandler.CreateAccessToken(100);
                return new LoginEmployeeCommandResponse { Token = token };
            }
            throw new Exception("hata");
        }
    }
}
