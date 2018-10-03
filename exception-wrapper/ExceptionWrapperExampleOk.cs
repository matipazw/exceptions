using System;
namespace exceptions.exceptionwrapper
{
    public class ExceptionWrapperExampleOk

    {
		public static void Execute()
        {
            try
            {
				var c = new CounterWrapper();

                c.Start();
            }
			catch (StartCounterException ex)
            {
                Log(ex.Message);
            }
        }

        static void Log(string message)
        {
            //Log message error.
        }
    }

	public class StartCounterException: Exception
	{

		public StartCounterException(string message) :base(message){
			
		}
	}

	public class CounterWrapper  {

		readonly Counter _counter;

		public CounterWrapper(){

			_counter = new Counter();
		}

		public void Start(){

            try
			{
				_counter.Start();
			}
			catch (UninitializedCounterException ex)
			{
				throw new StartCounterException(ex.Message);
			}
			catch (InvalidInitialValueException ex)
            {
				throw new StartCounterException(ex.Message);
            }
		}
	}
}
