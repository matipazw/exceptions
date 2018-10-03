using System;
namespace exceptions.noreturncodes
{
	public class Example1Ok
    {
        public static void DoSomething()
        {

			var connection = new ResourceConnectionOk();
            var connectionString = "example";

            try
			{
				connection.Open(connectionString);
				var result = connection.SendQuery("SELECT * FROM People");

                connection.Close();

				UseResult(result);
			}
			catch (Exception ex)
			{
				HandleConnectionError(ex);
			}
        }

		static void UseResult(object result)
		{
			//Do something
		}

		static void HandleConnectionError(Exception ex)
        {
			//Do something
		}
    }

    public class ResourceConnectionOk
    {
        public StatusConnectionOk Open(string connectionString)
        {

            if (ConnectionOk(connectionString))
            {
                return StatusConnectionOk.Open;
            }

			throw new ApplicationException("Connection Error.");
        }

		public void Close()
		{
			//Do something
		}

		public object SendQuery(string query)
		{
			//Execute query.
			return new Object();
		}

		bool ConnectionOk(string connectionString)
        {
            return true;
        }
    }

    public enum StatusConnectionOk
    {

        Open,
        Close
    }
}
