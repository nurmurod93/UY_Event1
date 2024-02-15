namespace UygaVazifaHodisalar
{
    public class Foydalanuvchi
    {
        public event EventHandler<TaqiqlanganFoydalanuvchiEventArgs> TaqiqHodisa;

        public void FoydalanuvchiniKirit()
        {
            Console.WriteLine("Foydalanuvchining ismini kiriting: ");
            string ism = Console.ReadLine();

            if (ism == "Lazizbek" || ism == "Nurmurod" || ism == "Zohidbek")
            {
                TaqiqHodisa(this, new TaqiqlanganFoydalanuvchiEventArgs(ism));
            }
            else
            {
                Console.WriteLine(ism + ", xush kelibsiz!");
            }
        }
    }
}
