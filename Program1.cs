using System; 

internal class Program
{
    static void QSort(int[] m, int LG, int PG)
    {
        int i = LG, j = PG, T;
        double X = m[((LG + PG) / 2)];
        while (i <= j)
        {
            while (m[i] < X) i += 1;
            while (m[j] > X) j -= 1;
            if (i <= j)
            {
                T = m[i]; m[i] = m[j]; m[j] = T;
                i += 1; j -= 1;
            }
        }
        if (LG < j) QSort(m, LG, j);
        if (i < PG) QSort(m, i, PG);
    }
    static void Main(string[] args)
    {
        const int k = 9;
        int[] m = new int[k];
        Random rand = new Random();
        for (int i = 0; i < k; i++) { m[i] = rand.Next(-9, 9); }
        Console.WriteLine("Исходный массив");
        for (int i = 0; i < m.Length; i++) { Console.WriteLine(m[i] + " "); }
        Console.WriteLine();
        QSort(m, 0, m.Length - 1);
        Console.WriteLine("Отсортированны массиив");
        for(int i = 0; i < m.Length; i++) { Console.Write(m[i] + " "); }
    }
}