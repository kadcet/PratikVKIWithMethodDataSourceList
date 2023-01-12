namespace PratikVKIApplication.Business
{
    public class Program
    {
        public static void Main()
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine($"1. Yeni VKI Hesabı\n2. VKI Listesi\n3. Arama\n4. Çıkış");
            MenuSelection();
        }

        static void MenuSelection()
        {
            Console.Write("Yapılacak İşlemi Seçiniz :");
            string choose = Console.ReadLine();
            switch (choose)
            {
                case "1":
                    NewVKI();
                    break;
                case "2":
                    ListOfVKI();
                    break;
                case "3":
                    Search();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Hatlı Seçim");
                    MenuSelection();
                    break;
            }
        }

        private static void ListOfVKI()
        {
            var vkiList = VKIService.GetVKIList();
            foreach (var item in vkiList)
            {
                WriteToScreen(item);
            }
        }

        private static void NewVKI()
        {
            VKI newVKI = new VKI();



            Console.Write("BOY GİRİN: :");
            newVKI.boy = Convert.ToDouble(Console.ReadLine());
            Console.Write("KİLO GİRİN : :");
            newVKI.kilo = Convert.ToDouble(Console.ReadLine());
            

            VKIService.SaveVKI(newVKI);

            WriteToScreen(newVKI);
            Again();
        }

        private static void Again()
        {
            Console.WriteLine("Menüye dönmek için ENTER");
            Console.ReadLine();
            Menu();
        }

        static void WriteToScreen(VKI v)
        {
            Console.WriteLine($"Boy : {v.boy}, Kilo :{v.kilo},  VKI Yüzdesi :{v.VKIHesaplama()}");
        }

        private static void Search()
        {
            throw new NotImplementedException();
        }
    }
}
