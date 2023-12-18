using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * List contains below 5 objects of Country Class data.
 * Suppose the scenario where data is huge. In that case its gone loop through all the objects.
 * When we use dictionary over list finding objects through key is very easy.
 * so it is better choice for performance.
 * so thats why we use dictionary over list.
 */


/*
 * Note : 
 * 
 *        1) If we have same class like Country class in both class files ListProgram.cs and DictionaryProgram.cs
 *        then change the namespace of both files and it will work.
 *        
 *        2) And If you have multiple .cs files and that files contain Main() method each.
 *        That means every file has its own Main method so how can we run each file individually?
 *        => Go to Solution Explorer right click on project => Go to Properties
 *        => Application => Startup Object => And Select here in drop down which file you want to run
 *        => save (ctrl + s) => run (ctrl + f5)
 *        
 *        
*/

namespace UsingList
{
    public class ListProgram
    {
        static void Main(string[] args)
        {
            Country country1 = new Country() { Code = "AUS", Name = "AUSTRALIA", Capital = "Canberra" };
            Country country2 = new Country() { Code = "IND", Name = "INDIA", Capital = "New Delhi" };
            Country country3 = new Country() { Code = "USA", Name = "UNITED STATES", Capital = "Washigton D.C." };
            Country country4 = new Country() { Code = "GBR", Name = "UNITED KINGDOM", Capital = "London" };
            Country country5 = new Country() { Code = "CAN", Name = "CANADA", Capital = "Ottawa" };

            List<Country> listCountries = new List<Country>();

            listCountries.Add(country1);
            listCountries.Add(country2);
            listCountries.Add(country3);
            listCountries.Add(country4);
            listCountries.Add(country5);

            string strUserChoice = string.Empty;

            do
            {
                Console.WriteLine("Please enter country code");

                string strCountryCode = Console.ReadLine().ToUpper();

                Country resultCountry = listCountries.Find(country => country.Code == strCountryCode);

                if (resultCountry == null)
                {
                    Console.WriteLine("Country code not valid");
                }
                else
                {
                    Console.WriteLine("Name = {0}, Capital = {1} ", resultCountry.Name, resultCountry.Capital);
                }

                do
                {
                    // If user type any garbage instead of YES or No. So in that case this loop will work. 
                    Console.WriteLine("Do you want to continue ? YES or NO");
                    strUserChoice = Console.ReadLine().ToUpper();

                } while (strUserChoice != "YES" && strUserChoice != "NO");



            } while (strUserChoice == "YES");
        }
    }


    public class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Capital { get; set; }

    }
}
