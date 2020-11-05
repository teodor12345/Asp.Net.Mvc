using AspNet.Mvc.EscapeRoomsApp.Models.Domain;
using AspNet.Mvc.EscapeRoomsApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet.Mvc.EscapeRoomsApp.InMemoryDB
{
    public static class Database
    {
        public static List<Product> EscapeRooms;

        static Database()
        {


            EscapeRooms = new List<Product>()
            {    new Product()
            {
                Id = 1,
                Name = "Saw",
                Price = 17,
                Description = "SAW Escape is an immersive, multi-room " +
                "(progressive) escape experience that brings to life twisted games inspired by the blockbuster SAW film franchise. Guests enter the historic Egan & Co." +
                " Meat Packing plant for an after hours tour, only to find they are players in an elaborate game devised by the infamous Jigsaw killer and his" +
                " disciples. By working together to combat their fears," +
                " venture far out of their comfort zones, and solve intricate puzzles, guests will have the opportunity to win their freedom as they traverse the twists and turns of an entire factory of Jigsaw’s games – one of the largest escape experiences in the world.",
                Category = Category.Horror,

            },
                new Product()
                {
                    Id = 2,
                    Name = "Indiana Jones",
                    Price = 18,
                    Description = "It will be hard, you’ll have to face many challenges and pass difficult traps from the ancient temple. Indiana Jones went in search for one of the most desired artifacts," +
                    " The Holy Grail. But he disappeared for some time without anyone knowing whether he is" +
                    " alive or dead. You, his students, worrying for him, decided to start a journey for finding him.Finally, after a long-lasting search and many days spent, deciphering the notes in his office and following a" +
                    " map from his journal, you arrived at the ancient temple from Escape Arena where it looks like Indiana Jones has been seen entering the last time.Grab your friends and start the journey for finding The Holy Grail.",
                    Category = Category.SciFI,

                },
                    new Product()
            {
                Id = 4,
                Name = "Dexter",
                Price = 20,
                Description = "You are a team of independent detectives in Miami. After thorough investigation," +
                " you were led to the conclusion that Dexter Morgan is a primary suspect of a series of " +
                "brutal murders of criminals who were never punished. But you need the final evidence so Dexter can be sentenced." +
                " You have 60 minutes to find the evidence and put Dexter in jail.",
                Category = Category.Crime,
            },
            new Product()
                {
                    Id = 3,
                    Name = "Hunting of the Hill House",
                    Price = 9,
                    Description = "I should have turned back at the gate Eleanor thought…she was afraid, listening to the sick voice inside her which whispered, " +
                    "Get away from here, get away.All ages are welcome to try their luck in this Hill House themed escape room.Can your team solve the mysteries of Hill House before time runs out? " +
                    "To Sign Up for one of the sessions, register here: https://www.signupgenius.com/go/8050a48ada629aafa7-escape " +
                    "Escape rooms are cooperative and interactive games where players discover clues, solve puzzles, and accomplish tasks, within a limited amount of time.",
                    Category = Category.Horror
}
            };

        

        }
    }
}

