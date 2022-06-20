namespace laba4
{
    abstract class IEquipment
    {
        public int maxspeed { get; set; }
        public int price { get; set; }
        public string name { get; set; }
        public abstract void NameandPrice();
        public abstract void Move();
    }
    class Skiing : IEquipment
    {
        public string color { get; set; }
        public override void NameandPrice() => Console.WriteLine($"Название:{name}   Цена:{price}");
        public override void Move() => Console.WriteLine($"{name} движется со скоростью {maxspeed}");
        public virtual void Inf() { }
    }
    class Snowboard : IEquipment
    {
        public string color { get; set; }
        public int size { get; set; }
        public Snowboard(string Name, int Maxspeed, int Price, string Color, int Size)
        {
            name = Name;
            maxspeed = Maxspeed;
            price = Price;
            color = Color;
            size = Size;
        }
        public override void NameandPrice() => Console.WriteLine($"Название:{name}   Цена:{price}");
        public override void Move() => Console.WriteLine($"{name} движется со скоростью {maxspeed}");
        public void Inf() => Console.WriteLine($"Цвет:{color}   Размер:{size}");
    }
    class DownhillSkiing : Skiing
    {
        public string country { get; set; }
        public DownhillSkiing(string Name, int Maxspeed, int Price, string Color, string Country)
        {
            name = Name;
            maxspeed = Maxspeed;
            price = Price;
            country = Country;
            color = Color;
        }
        public override void Inf() => Console.WriteLine($"Цвет:{color}   Страна:{country}");
    }
    class RunSkiing : Skiing
    {
        public string mark { get; set; }
        public RunSkiing(string Name, int Maxspeed, int Price, string Color, string Mark)
        {
            name = Name; 
            maxspeed = Maxspeed;
            price = Price;
            mark = Mark;
            color = Color;
        }
        public override void Inf() => Console.WriteLine($"Цвет:{color}   Марка:{mark}");
    }
    class Go
    {
        public static void Main()
        {

            Snowboard sn = new Snowboard("Сноуборд", 60, 1000, "Red", 8);
            DownhillSkiing ds = new DownhillSkiing("Горные лыжи", 70, 1200, "Yellow", "Germany");
            RunSkiing rs = new RunSkiing("Беговые лыжи", 80, 1300, "Blue", "Larsen");


            sn.NameandPrice(); 
            sn.Inf();
            ds.NameandPrice(); 
            ds.Inf();
            rs.NameandPrice(); 
            rs.Inf();
            Console.WriteLine();

            sn.Move();
            ds.Move();
            rs.Move();

        }
    }
}
