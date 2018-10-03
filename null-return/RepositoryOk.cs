using System;
using System.Collections.Generic;
using System.Linq;

namespace exceptions.nullreturn
{
    public class RepositoryOk
    {
        public IList<int> GetValues(){

			var values = GetValuesFromSource();

			if (values.Count() == 0) 
			    return new List<int>();

			return values;
		}

		IList<int> GetValuesFromSource()
		{
			return new List<int> { 1, 2, 3 };
		}
	}
}
