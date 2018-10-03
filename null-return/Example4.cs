using System;
using System.Collections.Generic;

namespace exceptions.nullreturn
{
    public class Example4
    {
  
		public static void Execute() {

			var repository = new Repository();

			var values = repository.GetValues();

			if(values != null) {
				foreach (var v in values)
                {
                    DoSomething(v);
                }
			}

		}

		static void DoSomething(int v)
		{
            //Do something
		}
	}
}
