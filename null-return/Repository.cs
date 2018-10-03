using System.Collections.Generic;
using System.Linq;

namespace exceptions.nullreturn
{
	public class Repository
    {
		public IList<int> GetValues()
        {

            var values = GetValuesFromSource();

			if (values.Count() == 0)
				return null;
			
            return values;
        }

        IList<int> GetValuesFromSource()
        {
            return new List<int> { 1, 2, 3 };
        }
    }
}
