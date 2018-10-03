namespace exceptions.nullreturn
{
    public class NullReturnExampleOk
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
