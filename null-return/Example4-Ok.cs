using System;
namespace exceptions.nullreturn
{
	public class Example4Ok
    {

        public static void Execute()
        {
            var repository = new RepositoryOk();

            var values = repository.GetValues();

            foreach (var v in values)
            {
                DoSomething(v);
            }
        }

        static void DoSomething(int v)
        {
            //Do something
        }
    }
}
