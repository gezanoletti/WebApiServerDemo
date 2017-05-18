using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Authorization.Users;
using Abp.Web.Models;
using WebApiServerDemo.Demo.Dto;

namespace WebApiServerDemo.Demo
{
    public class DemoAppService : ApplicationService, IDemoAppService
    {
        public void Test1()
        {
            
        }

        public string Test2(int input)
        {
            return Convert.ToString(input);
        }
       
        public string Test3(TwoStringInput input)
        {
            return input.Str1 + input.Str2;
        }

        public string Test4(TwoStringInput input)
        {
            return input.Str1 + input.Str2;
        }

        public string Test5(string str1, string str2)
        {
            return str1 + str2;
        }
    }
}
