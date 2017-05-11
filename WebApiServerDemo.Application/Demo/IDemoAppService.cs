using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;

namespace WebApiServerDemo.Demo
{
    public interface IDemoAppService : IApplicationService
    {
        /// <summary>
        /// Just call the operation
        /// </summary>
        void Test1();

        /// <summary>
        /// Convert value to string
        /// </summary>
        /// <param name="input">Input value</param>
        /// <returns>Converted value</returns>
        string Test2(int input);
    }
}
