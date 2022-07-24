using BusinessObject;
using DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eStore.Controllers
{
    public class LoginController : Controller
    {
        IMemberRepository memberRepository = null;
        public LoginController() => memberRepository = new MemberRepository();
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult ProcessLogin(string email, string password)
        {
            var member = memberRepository.Login(email, password);
            if (member == null)
            {
                return NotFound();
            }
            else
            {
                if (member.MemberId == 1)
                {
                    return View("Views/Member/Index");
                }
            }
            return View(member);
        }
    }
}
