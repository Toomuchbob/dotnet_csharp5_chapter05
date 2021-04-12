using System;
using Packt.Shared;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person bob = new();

            // bob.Name = "Bob Smith";
            // bob.DateOfBirth = new DateTime(1965, 12, 22);
            // bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
            // bob.Children.Add(new Person { Name = "Alfred" });
            // bob.Children.Add(new Person { Name = "Zoe" });

            // WriteLine($"{bob.Name} has {bob.Children.Count} children:");
            // foreach (var child in bob.Children) {
            //     WriteLine($"{child.Name}");
            // }

            // WriteLine(
            //     format: "{0} was born on {1:dddd, d MMMM, yyyy}",
            //     arg0: bob.Name,
            //     arg1: bob.DateOfBirth
            // );

            // WriteLine(
            //     format: "{0}'s favorite wonder is {1}. It's integer is {2}.",
            //     arg0: bob.Name,
            //     arg1: bob.FavoriteAncientWonder,
            //     arg2: (int)bob.FavoriteAncientWonder
            // );

            // var alice = new Person {
            //     Name = "Alice Jones",
            //     DateOfBirth = new DateTime(1998, 3, 7)
            // };

            // WriteLine(
            //     format: "{0} was born on {1:dd MMM yy}",
            //     arg0: alice.Name,
            //     arg1: alice.DateOfBirth
            // );

            // BankAccount.InterestRate = 0.012M; // store a shared value

            // var jonesAccount = new BankAccount();
            // jonesAccount.AccountName = "Mrs. Jones";
            // jonesAccount.Balance = 2400;

            // WriteLine(
            //     format: "{0} earned  {1:C} interest.",
            //     arg0: jonesAccount.AccountName,
            //     arg1: jonesAccount.Balance * BankAccount.InterestRate
            // );

            // var gerrierAccount = new BankAccount();
            // gerrierAccount.AccountName = "Mrs. Gerrier";
            // gerrierAccount.Balance = 98;

            // WriteLine(
            //     format: "{0} earned {1:C} interest.",
            //     arg0: gerrierAccount.AccountName,
            //     arg1: gerrierAccount.Balance * BankAccount.InterestRate
            // );

            // Person blankPerson = new();

            // WriteLine(
            //     format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
            //     arg0: blankPerson.Name,
            //     arg1: blankPerson.HomePlanet,
            //     arg2: blankPerson.Instantiated
            // );

            var sam = new Person {
                Name = "Sam",
                DateOfBirth = new DateTime(1972, 1, 27)
            };

            WriteLine(sam.Origin);
            WriteLine(sam.Greeting);
            WriteLine(sam.Age);

            sam.FavoriteIceCream = "Chocolate Fudge";

            WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}.");

            sam.FavoritePrimaryColor = "Red";

            WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}.");
            
            object[] passengers = {
                new FirstClassPassenger { AirMiles = 1_419 },
                new FirstClassPassenger { AirMiles = 16_562 },
                new BusinessClassPassenger(),
                new CoachClassPassenger { CarryOnKG = 25.7 },
                new CoachClassPassenger { CarryOnKG = 0 },
            };

            foreach (object passenger in passengers) {
                decimal flightCost = passenger switch {
                    FirstClassPassenger p when p.AirMiles > 35000 => 1500M,
                    FirstClassPassenger p when p.AirMiles > 15000 => 1750M,
                    FirstClassPassenger _                         => 2000M,
                    BusinessClassPassenger _                      => 1000M,
                    CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
                    CoachClassPassenger _                         => 650M,
                    _                                             => 800M
                };

                WriteLine ($"Flight costs {flightCost:C} for {passenger}");
            }
        }
    }
}
