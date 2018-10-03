using System;
using System.Collections.Generic;

namespace exceptions.exceptioncontext
{
    public class Example2
    {

		public static void DoSomething(string param1, string param2) {
           
			try
			{
                //Code executing.
			}
			catch (Exception ex)
			{
				var cex = new CustomException(ex);
				cex.AddContext(param1, param2);
				throw cex;
			}

		}
	}


	public class CustomException : Exception {

        readonly List<object> _context;


        public CustomException(Exception innerException) 
			: base("custom message",innerException) {

            _context = new List<object>();
		}

		public void AddContext(params object[] contextInfo){

            _context.AddRange(contextInfo);
		}
	}
}
