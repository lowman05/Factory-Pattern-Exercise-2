namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which database would you like to use:  a List, SQL, or Mongo?");
            string userResponse = Console.ReadLine().ToLower();   
            IDataAccess data = DataAccessFactory.GetDataAccessType(userResponse);
            data.LoadData();
            data.SaveData();
            
        }
    }
}
