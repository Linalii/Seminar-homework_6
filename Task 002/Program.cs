 int N = 10, M = 10;
            int[,] a = new int[N, M];
 
            int count=1;
 
            for (int i = 0; i < N; i++)
            {
                count = 1;
                for (int j = 0; j < M; j++)
                {
                    if ((count + i) != 10) a[i, j] = (count + i) % M;
                    else a[i, j] = (count + i);
                    count++;
                }
 
            }
 
 
            Console.WriteLine("Массив:");
 
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
 
            Console.ReadLine();
