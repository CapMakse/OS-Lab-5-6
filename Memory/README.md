﻿# Оптимізація роботи із пам'яттю

## Початковий вхідний файл
```C#

static void Main(string[] args)
        {
            int[][] AD = new int[2][2];
            int res = 0;

            for (int j = 500000000; j > 0; j--)
            {
                AD[0][0]++;
                AD[0][0]++;
            }

            AD[1][1] = AD[0][0];

            Console.WriteLine(AD[1][1]);

        }
```

## Оптимізований код та його аналіз

У прикладі наведеному вище ми виконували дві однакові дії у циклі над одними і тими ж даними. Це погано, оскільки нам доводиться звертатися до тих самих даних у 2 рази більше. Трохи оптимізуємо це:

```C#

static void Main(string[] args)
            {
                int[][] AD = new int[2][];
                AD[0] = new int[2];
                AD[1] = new int[2];
                for (int j = 500000000; j > 0; j--)
                {
                    //AD[0][0]++;
                    //AD[0][0]++;
                    AD[1][1]+=2;
                }

            //AD[1][1] = AD[0][0];

            Console.WriteLine(AD[1][1]); 
```

Чи дало це нам насправді якийсь виграш?

## Часові заміри обох прикладів

Для порвніння часу роботи, я запустив кожен із варіантів декілька раз і взяв середнє арифметичне кожного із них.

Результат першого (неоптимізованого): `13497` мілісекунд.

Результат другого (оптимізованого): `8296` мілісекунд.

Як бачимо ми маємо виграш у часі. На перший погляд, це небагато, але у великих програмах, які працюються із великою кількістю великих даних, це може значно скоротити час виконання.