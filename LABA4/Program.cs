namespace LABA4
{
    abstract class Gadget
    {
        public string NameOfdevice { get; set; }
        public int PriceForDevice { get; set; }
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
    class Computer : Pc
    {
        public Computer(string NAME, int Price)
        {
            NameOfdevice = NAME;
            PriceForDevice = Price;
        }
        public override void GetPrice() => Console.WriteLine($"Цiна системного блоку: {PriceForDevice}");
        public override void Restart() => Console.WriteLine("Перезагрузка...");
        public override void GetInfo() => Console.WriteLine($"Iм'я системного блоку: {NameOfdevice}");
        
    }
    class Screen: Pc
    {
        public string Marka { get; set; }
        public Screen(string NAME, int Price)
        {
            NameOfdevice = NAME;
            PriceForDevice = Price;
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
        public Phone(string NAME, int Price)
        {
            NameOfdevice = NAME;
            PriceForDevice = Price;
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
    class shop: Gadget
    {
        public static void Sort(List<Gadget> gadgets)
        {

            int price1=0;
            int price2=0;
            int price3=0;
            int sum = 0;

            foreach (Gadget gadget in gadgets)
            {
                sum += gadget.PriceForDevice;

            }
            Console.WriteLine("All sum of price: "+sum);

            Console.WriteLine("Choose a kind of gadjets to sum up their costs: PC(1)   Screen(2)    Phone(3)");
            string key =Console.ReadLine();
            if(key =="1")
            {
                foreach (Computer comp in gadgets)
                {
                    price1 = comp.PriceForDevice++;
                }
                Console.WriteLine("Price for all PC = " + price1);
            }
            else if(key == "2")
            {
                foreach (Screen scr in gadgets)
                {
                    price2 = scr.PriceForDevice++;
                }
                Console.WriteLine("Price for all Screen = " + price2);

            }
            else if (key == "3")
            {
                foreach (Phone phone in gadgets)
                {
                    price3 = phone.PriceForDevice++;
                }
                Console.WriteLine("Price for all Screen = " + price3);

            }

        }
        public static void Shop(Gadget gadget, List<Gadget> gadgets)
        {
           
            gadgets.Add(gadget);
            
        }



        public override void Connection()
        {
        }
        public override void GetPrice() => Console.WriteLine($"Цiна: {PriceForDevice}");
        public override void Restart() => Console.WriteLine("Перезагрузка...");
        public override void GetInfo() => Console.WriteLine($"Iм'я: {NameOfdevice}");
    }
    class Program
    {
        public static void Main()
        {
            List<Gadget> gadgets = new List<Gadget>();

            Computer computer = new Computer("Iгровий пк", 32000);
            Screen screen = new Screen("Iгровий монiтор", 5000);
            Phone phone = new Phone("Samsung", 15000);

            Computer computer2 = new Computer(" пк", 60000);
            Screen screen2 = new Screen(" монiтор", 7000);
            Phone phone2 = new Phone("Acer", 20000);

            Computer computer3 = new Computer("pc", 150000);
            Screen screen3 = new Screen("Screen", 10000);
            Phone phone3 = new Phone("Iphone", 10000);

            Screen screen01 = new Screen("Asus");
            Phone phone01 = new Phone("Samsung Electronics");
            /*
            gadgets.Add(computer);
            gadgets.Add(computer2);
            gadgets.Add(computer3);
            gadgets.Add(screen);
            gadgets.Add(screen2);
            gadgets.Add(screen2);
            gadgets.Add(phone);
            gadgets.Add(phone2);
            gadgets.Add(phone3);

            int price1 = 0;
            int price2 = 0;
            int price3 = 0;
            int sum=0;

            foreach(Gadget gadget in gadgets)
            {
                sum += gadget.PriceForDevice;
                
            }
            Console.WriteLine(sum);
            
            Console.WriteLine("Choose a kind of gadjets to sum up their costs: PC(1)   Screen(2)    Phone(3)");
            string key = Console.ReadLine();
            if (key == "1")
            {
                foreach (Computer comp in gadgets)
                {
                    price1 =+comp.PriceForDevice;
                }
                Console.WriteLine("Price for all PC = " + price1);
            }
            else if (key == "2")
            {
                foreach (Screen scr in gadgets)
                {
                    price2 = scr.PriceForDevice++;
                }
                Console.WriteLine("Price for all Screen = " + price2);

            }
            else if (key == "3")
            {
                foreach (Phone ph in gadgets)
                {
                    price3 = ph.PriceForDevice++;
                }
                Console.WriteLine("Price for all Screen = " + price3);

            }


            */
            shop.Shop(computer, gadgets);
            shop.Shop(screen, gadgets);
            shop.Shop(phone, gadgets);
            shop.Shop(computer2, gadgets);
            shop.Shop(screen2, gadgets);
            shop.Shop(phone2, gadgets);
            shop.Shop(computer3, gadgets);
            shop.Shop(screen3, gadgets);
            shop.Shop(phone3, gadgets);
            shop.Sort(gadgets);
            
            computer.GetInfo();computer.GetPrice();computer.Restart();
            screen.GetInfo(); screen.GetPrice(); screen01.GetMArka(); screen.Connection(); screen.Restart();
            phone.GetInfo(); phone.GetPrice(); phone01.GetMArka(); phone.Connection(); phone.Restart();

        }
    }
}