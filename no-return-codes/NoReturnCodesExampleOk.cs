using System;
namespace exceptions.noreturncodes
{
    public class NoReturnCodesExampleOk
    {
        public void DoSomething()
        {

	    var connection = new ResourceConnectionOk();
            var connectionString = "example";

            try
	    {
		connection.Open(connectionString);
		var result = connection.ExecuteQuery("SELECT * FROM People");

                connection.Close();

		UseResult(result);
	    }
	    catch (Exception ex)
	    {
		HandleConnectionError(ex);
	    }
        }

	void UseResult(object result)
	{
		//Do something
	}

	void HandleConnectionError(Exception ex)
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

	public object ExecuteQuery(string query)
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
