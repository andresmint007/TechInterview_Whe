using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Test_Wheelzy
{
    public  class Interceptor
    {
        public void validerror(int code)
        {
            if ((int)code >= 400)
            {
                var errorMessage = $"Error in the application : {code.ToString()}";
                throw new Exception(errorMessage);
            }
            else if (code >= 500)
            {
                throw new Exception("An internal error occurred on the server. Please try again later or contact technical support..");
            }
            else if (code == 404)
            {
                throw new Exception("resource not found. The specified URL does not exist.");
            }
        }
    }
}
