using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Application.Exceptions
{
    public class ValidationException : Exception
    {
        public string Errors { get; set; }
    }
}
