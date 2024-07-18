
    for (int i = 0; i <= 9; i++)
    {
          Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
                }


Console.WriteLine("---------------------------------");


for (int i = 1; i <= 20; i++)
    {
         Console.WriteLine($"{i}");
         }

Console.WriteLine("---------------------------------");

    for (int i = 2; i <= 20; i+=2)
      {
           Console.WriteLine($"{i}");
                }

Console.WriteLine("---------------------------------");

  int x = 0;
       for (int i = 50; i <= 150; i++)
            {
               x += i; 
                    }
                Console.WriteLine($"{x}");
//x i bilerek dışarda gösterdim son toplamını vermesi için aksi taktirde döngünün içindeyken son toplamı veremiyor



Console.WriteLine("---------------------------------");

 int even = 0;
    for (int i = 0; i <= 120; i+=2)
         {
              even += i;
                   }
                Console.WriteLine(even);
//if kullanmaya gerek kalmadan direkt i yi 2 şer arttırdım

Console.WriteLine("---------------------------------");

int odd = 0;

    for (int i = 0; i <= 120; i++)
             {
             if (i % 2 != 0)
                  { 
                      odd += i;
                                   }
                                     }
                    Console.WriteLine(odd);