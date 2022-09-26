internal class Program
{
    private static void Main(string[] args)
    {
        string[] objects = { "Red", "Tea", "Cat", "Мoscow", "Meat" };

        Random rand = new Random();
        string hide = (objects[rand.Next(objects.Length-1)]);

        if (hide == "Red")
        {
            Console.WriteLine("Привет , компьютер загадал слово на тему: Цвет. Твоя задача отгадать это слово , удачи ! Ах да ,я усложнил игру и тебе нужно угадывать слово на английсокм языке, если ты не отгадаешь может погибнуть человек!");
        }
        if (hide == "Tea")
        {
            Console.WriteLine("Привет , компьютер загадал слово на тему: Напиток. Твоя задача отгадать это слово , удачи ! Ах да ,я усложнил игру и тебе нужно угадывать слово на английсокм языке, если ты не отгадаешь может погибнуть человек!");
        }
        if (hide == "Cat")
        {
            Console.WriteLine("Привет , компьютер загадал слово на тему: Домашнее Животное. Твоя задача отгадать это слово , удачи ! Ах да ,я усложнил игру и тебе нужно угадывать слово на английсокм языке, если ты не отгадаешь может погибнуть человек!");
        }
        if (hide == "Moscow")
        {
            Console.WriteLine("Привет , компьютер загадал слово на тему: Город в России. Твоя задача отгадать это слово , удачи ! Ах да ,я усложнил игру и тебе нужно угадывать слово на английсокм языке, если ты не отгадаешь может погибнуть человек!");
        }

        if (hide == "Meat")
        {
            Console.WriteLine("Привет , компьютер загадал слово на тему: Еда. Твоя задача отгадать это слово , удачи ! Ах да ,я усложнил игру и тебе нужно угадывать слово на английсокм языке, если ты не отгадаешь может погибнуть человек!");
        }
        /* void Game(string a)
         {
             int i = 0, j = 0, ochibka = 0;
             bool verno = false;
             int lenl = a->size(); // получить длину переданного слова
             char bukva;

         }
        */
        int tryes = 7;
        List<char> user_letters = new List<char>();
        while (tryes-- > 0)
        {
            Console.WriteLine(Environment.NewLine);
            string show_user_word = null;
            foreach (char _char in hide.ToCharArray())
            {
                if (!user_letters.Contains(_char)) show_user_word += "_";
                else show_user_word += _char;
            }
            if (show_user_word.Contains("_"))
            {
                Console.WriteLine($@"Осталось попыток: {tryes} {Environment.NewLine}{show_user_word}");
                try
                {
                    Console.WriteLine("Укажите букву: "); 
                    var user_char = Console.ReadLine();
                    user_letters.Add(char.Parse(user_char));
                    if (hide.Contains(user_char))
                    {
                        tryes++;
                        Console.WriteLine($@"Буква '{user_char}' оказалась правильной");
                    }

                    else Console.WriteLine($@"Буква '{user_char}' оказалась неправильной");


                }
                catch 
                {
                    Console.WriteLine("Особо умные теряют попытки:D");
                   
                }
               
            }
            else
            {
                Console.WriteLine($@"Вы выиграли! {Environment.NewLine}{show_user_word}");
                return;

            }
        }
        Console.WriteLine($@"Вы проиграли! {Environment.NewLine}{hide}");








    }
}