using System;
namespace exceptions.exceptionwrapper
{
    public class ExceptionWrapperExample
    {
      
		public static void Execute() 
		{
            try
			{
				var c = new Counter();

				c.Start();
			} 
			catch (UninitializedCounterException ex) {
				Log(ex.Message);
			}
			catch (InvalidInitialValueException ex)
            {
                Log(ex.Message);
            }
		}

		private static void Log(string message)
		{
            //Log message error.
		}
	}

	public class Counter {

		public void Start(){

			throw new UninitializedCounterException("The counter has to be initialized");

			throw new InvalidInitialValueException("The initial value is invalid");
		}
	}

	public class UninitializedCounterException : Exception {

		public UninitializedCounterException(string message) :base(message){
			
		}
	}

	public class InvalidInitialValueException : Exception
    {

		public InvalidInitialValueException(string message) : base(message)
        {

        }
    }
}
