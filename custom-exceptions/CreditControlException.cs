using System;
namespace exceptions.nonullparameters
{
	public class CreditControlException : Exception
    {
        public decimal TotalConfiguration { get; set; }
		public decimal CurrentValue { get; set; }

		public CreditControlException(decimal configuration, decimal currentValue) : base("Need more credit.")
		{
			TotalConfiguration = configuration;
            CurrentValue = currentValue;
		}

    }
}
