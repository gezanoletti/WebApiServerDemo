using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Abp.Application.Services;
using Abp.Web.Models;
using WebApiServerDemo.Demo.Dto;

namespace WebApiServerDemo.Demo
{
    public interface IDemoAppService : IApplicationService
    {
        void Test1();

        string Test2(int input);

        string Test3(TwoStringInput input);

        [DontWrapResult]
        string Test4(TwoStringInput input);

        [HttpGet]
        string Test5(string str1, string str2);
    }
}
