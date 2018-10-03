using System;
namespace exceptions.noreturncodes
{
    public class Example1
    {
		public void DoSomething() {

			var connection = new ResourceConnection();
			var connectionString = "example";
				
			var status = connection.Open(connectionString);

			if(status == StatusConnection.Error) {

				HandleConnectionError();
			}
			else {

                var result = connection.ExecuteQuery("SELECT * FROM People");

				connection.Close();

				UserResult(result);
			}
		}

	    void UserResult(object result)
		{
            //Use result
		}

		void HandleConnectionError()
		{
            //Do something
		}
	}

	public class ResourceConnection
    {
        public StatusConnection Open(string connectionString)
        {

            if (ConnectionOk(connectionString))
            {
                return StatusConnection.Open;
            }

            return StatusConnection.Error;

        }

		public void Close()
		{
			//Close connection
		}

		public object ExecuteQuery(string v)
		{
            //Execute query
            return new object();
		}

		bool ConnectionOk(string connectionString)
        {
            return true;
        }
    }

    public enum StatusConnection
    {

        Open,
        Close,
        Error
    }
}
