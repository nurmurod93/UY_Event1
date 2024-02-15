namespace UygaVazifaHodisalar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Foydalanuvchi foydalanuvchi = new Foydalanuvchi();
            foydalanuvchi.TaqiqHodisa += OgohlantirishSignali;
            foydalanuvchi.FoydalanuvchiniKirit();

            Console.ReadLine();
        }

        static void OgohlantirishSignali(object manba, TaqiqlanganFoydalanuvchiEventArgs e)
        {
            Console.WriteLine("{0} Foydalanuvchilar topildi. Ma'muriyatga pochta jo'natilyapti.", e.Ism);
            Console.WriteLine("Pochta jo'natildi.");
            Console.WriteLine("Ogohlantirish signali ishini boshladi.");
            Console.WriteLine("Ctrl + C tugmasini bosing, to'xtatish uchun.");

            for (; ;)
            {
                Console.Beep();
                Thread.Sleep(100);
            }
        }
    }
}