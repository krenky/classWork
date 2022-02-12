using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculateController : ControllerBase
    {
        [HttpGet]
        [Route("sum")]
        public async Task<string> Sum(int a, int b)
        {
            var sum = a + b;
            return sum.ToString();
        }
        [HttpGet]
        [Route("minus")]
        public async Task<string> Minus(int a, int b)
        {
            var sum = a - b;
            return sum.ToString();
        }
        [HttpGet]
        [Route("delenie")]
        public async Task<string> Delenie(int a, int b)
        {
            var sum = a / b;
            return sum.ToString();
        }
        [HttpGet]
        [Route("umnozh")]
        public async Task<string> Umnozh(int a, int b)
        {
            var sum = a * b;
            return sum.ToString();
        }
    }
}
