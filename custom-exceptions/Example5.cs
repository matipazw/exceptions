using exceptions.nonullparameters;

namespace exceptions.customexceptions
{
	public class Example5
    {
		public void Execute() {

			var totalSales = 2000;

			ValidateCredit(totalSales);
            RegisterSale(totalSales);
		}
              
        void ValidateCredit(int totalSales)
		{
            var config = GetConfiguration();

			if(config.Total < totalSales) {
                throw new CreditControlException(config.Total, totalSales);
			}
		}

		void RegisterSale(int importeVentas)
        {
            //Do somethings.
        }


	    CreditControlConfiguration GetConfiguration()
		{
			return new CreditControlConfiguration
			{
                Total = 100,
			};
		}
	}

	public class CreditControlConfiguration {

        public decimal Total { get; set; }
	}
}
