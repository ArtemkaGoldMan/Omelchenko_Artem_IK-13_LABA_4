namespace LABA4
{
    abstract class Gadget
    {
        public string NameOfdevice { get; set; }
        public int PriceForDevice { get; set; }
        public string Category { get; set; }
        public abstract void GetPrice();
        public abstract void GetInfo();
        public abstract void Restart();
        public abstract void Connection();
        

    }
    class Pc : Gadget
    {
        public override void Connection()
        {

        }
        public override void GetPrice()=> Console.WriteLine($"Цiна: {PriceForDevice}");
        public override void Restart() => Console.WriteLine("Перезагрузка...");
        public override void GetInfo() => Console.WriteLine($"Iм'я: {NameOfdevice}");
    }
    class Computer : Gadget
    {
        public Computer(string NAME, int Price, string category)
        {
            NameOfdevice = NAME;
            PriceForDevice = Price;
            Category = category;
        }
        public override void GetPrice() => Console.WriteLine($"Цiна системного блоку: {PriceForDevice}");
        public override void Restart() => Console.WriteLine("Перезагрузка...");
        public override void GetInfo() => Console.WriteLine($"Iм'я системного блоку: {NameOfdevice}");

        public override void Connection()
        {
            Console.WriteLine("Turn on (1) or turn off(2) this device");
            if (Int32.Parse(Console.ReadLine()) == 1)
            {
                Console.WriteLine("This device is turned on");

            }
            else
            {
                Console.WriteLine("This device is turned off");
            }
        }
        
    }
    class Screen: Gadget
    {
        public string Marka { get; set; }
        public Screen(string NAME, int Price, string category)
        {
            NameOfdevice = NAME;
            PriceForDevice = Price;
            Category = category;
        }
        public Screen(string MARKA)
        {
            Marka = MARKA;
        }
        public void GetMArka() => Console.WriteLine($"Марка екрану: { Marka}");
        public override void GetPrice() => Console.WriteLine($"Цiна монiтора: {PriceForDevice}");
        public override void Restart() => Console.WriteLine("Перезагрузка...");
        public override void GetInfo() => Console.WriteLine($"Iм'я монiтора: {NameOfdevice}");
        public override void Connection()
        {
            Console.WriteLine("Connect (1) or Disconnect(2) this device to Computer");
            if (Int32.Parse(Console.ReadLine()) == 1)
            {
                Console.WriteLine("This device is connect");

            }
            else
            {
                Console.WriteLine("This device is disconnect");
            }

        }
        
    }
    class Phone : Gadget
    {
        public string Marka { get; set; }
        public Phone(string NAME, int Price, string category)
        {
            NameOfdevice = NAME;
            PriceForDevice = Price;
            Category = category;
        }
        public Phone(string MARKA)
        {
            Marka = MARKA;
        }
        public void GetMArka() => Console.WriteLine($"Марка телефону: { Marka}");
        public override void GetPrice() => Console.WriteLine($"Цiна телефону: {PriceForDevice}");
        public override void Restart() => Console.WriteLine("Перезагрузка...");
        public override void GetInfo() => Console.WriteLine($"Iм'я телефону: {NameOfdevice}");
        public override void Connection()
        {
            Console.WriteLine("Connect (1) or Disconnect(2) this device to Computer");
            if (Int32.Parse(Console.ReadLine()) == 1)
            {
                Console.WriteLine("This device is connect");

            }
            else 
            {
                Console.WriteLine("This device is disconnect");
            }
        }
    }
    class Shop
    {
        List<Gadget> gadgets = new List<Gadget>();
        public void AddToListShop(Gadget gadget)
        {
            gadgets.Add(gadget);
        }
        public void sort()
        {
            int pricePC = 0, priceScreen = 0, pricePhone = 0;
            Console.WriteLine("Choose a  item (1)-PC,(2)-Screen,(3)- Phone to know their full costs");
            string key = Console.ReadLine();
            if(key == "1")
            {
                foreach(Gadget gadget in gadgets)
                {
                    if (gadget.Category.Equals("PC"))
                    {
                        pricePC += gadget.PriceForDevice;
                    }
                   
                }
                Console.WriteLine("Full price for all PC: " + pricePC);
            }
            else if (key == "2")
            {
                foreach (Gadget gadget in gadgets)
                {
                    if (gadget.Category.Equals("Screen"))
                    {
                        pricePC += gadget.PriceForDevice;
                    }

                }
                Console.WriteLine("Full price for all Screen: " + priceScreen);
            }
            else if (key == "3")
            {
                foreach (Gadget gadget in gadgets)
                {
                    if (gadget.Category.Equals("Phone"))
                    {
                        pricePC += gadget.PriceForDevice;
                    }

                }
                Console.WriteLine("Full price for all Phone: " + pricePhone);
            }

        }

    }
    class Program
    {
        public static void Main()
        {
            
            Computer computer = new Computer("Iгровий пк", 32000, "PC");
            Screen screen = new Screen("Iгровий монiтор", 5000, "Screen");
            Phone phone = new Phone("Samsung", 15000, "Phone");

            Computer computer2 = new Computer(" пк", 60000, "PC");
            Screen screen2 = new Screen(" монiтор", 7000, "Screen");
            Phone phone2 = new Phone("Acer", 20000, "Phone");

            Computer computer3 = new Computer("pc", 150000, "PC");
            Screen screen3 = new Screen("Screen", 10000, "Screen");
            Phone phone3 = new Phone("Iphone", 10000, "Phone");

            Screen screen01 = new Screen("Asus");
            Phone phone01 = new Phone("Samsung Electronics");
            var shop = new Shop();
            shop.AddToListShop(computer);
            shop.AddToListShop(screen);
            shop.AddToListShop(phone);
            shop.AddToListShop(computer2);
            shop.AddToListShop(screen2);
            shop.AddToListShop(phone2);
            shop.AddToListShop(computer3);
            shop.AddToListShop(screen3);
            shop.AddToListShop(phone3);
            shop.sort();


            computer.GetInfo();computer.GetPrice();computer.Restart();
            screen.GetInfo(); screen.GetPrice(); screen01.GetMArka(); screen.Connection(); screen.Restart();
            phone.GetInfo(); phone.GetPrice(); phone01.GetMArka(); phone.Connection(); phone.Restart();

        }
    }
}