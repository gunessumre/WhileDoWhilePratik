
//WHILE ILE YAPIM
int limit;
Console.Write("Bir limit değeri giriniz: ");
limit = int.Parse(Console.ReadLine());
int sayac = 0;
while (sayac <= limit)
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac++;
}

//DO WHILE ILE YAPIM
int limit1;
Console.Write("Bir limit değeri giriniz: ");
limit1 = int.Parse(Console.ReadLine());
int sayac1 = 0;
do
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac++;
} while (sayac<= limit1);
