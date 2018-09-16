博碩 Chapter2_2-18

static void Main(string[] args)
{
    int price = 120, qty = 50;
    Console.WriteLine("售價:{0} 數量{1}", price, 50);
    Console.WriteLine();
    Console.WriteLine("打八折後 總金額:{0}", price * qty * 0.8);
    Console.Read();
}

static void Main(string[] args)
{
    string str1;
    int price, qty;
    Console.WriteLine();
    Console.WriteLine("  電腦圖書廣場");
    Console.WriteLine("===========================");
    Console.Write("  1.書名:");
    str1 = Console.ReadLine();    //輸入書名並指定給str1變數。
    Console.Write("  2.售價:");

    //輸入售價並使用 int.Parse() 將輸入的資料轉成整數，在指定給price
    price = int.Parse(Console.ReadLine());
    Console.Write("  3.數量:");

    //輸入數量並使用 Convert.ToInt32 將輸入的資料轉成整數，在指定給qty
    qty = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("====================");
    Console.WriteLine("  4.金額:{0}", price * qty);
    Console.Read();
}

//Escape sequence
static void Main(string[] args)
{
    Console.WriteLine("\"大理世子\"");
    Console.WriteLine("Tom\'s Toys");
    Console.WriteLine("Why 1\\2");
}
