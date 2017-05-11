using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Authorization.Users;

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
    }
}
