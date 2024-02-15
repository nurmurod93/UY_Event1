namespace UygaVazifaHodisalar
{
    public class TaqiqlanganFoydalanuvchiEventArgs : EventArgs
    {
        public string Ism {  get; set; }
        public TaqiqlanganFoydalanuvchiEventArgs(string ism)
        {
            Ism = ism;  
        }
    }
}
