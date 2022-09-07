public class Circular_buffer
{
    public int[] Buffer;

    public Circular_buffer(int bufferSize)
    {
        Random random = new Random();
        Buffer = new int[bufferSize];
        Buffer[random.Next(1, bufferSize + 1)] = 1;
    }


    public void add()
    {
        int Indice = Array.IndexOf(Buffer, Buffer.Max());
        if (Buffer[NextIndice(Indice)] == 0 && Buffer[NextIndice(NextIndice(Indice))] == 0)
        {
            Buffer[NextIndice(Indice)] = Buffer.Max() + 1;
            Buffer[NextIndice(NextIndice(Indice))] = Buffer.Max() + 1;

        }
        else
        {
            Console.WriteLine("Overwrite ? 1 - Sim, 2 - Não");
            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 1)
                Overwrite();

        }
    }

    public void Show()
    {
        foreach (var numbers in Buffer)
        {
            Console.WriteLine(numbers);
        }
    }


    public int NextIndice(int Indice)
    {
        Indice += 1;
        while (Indice >= Buffer.Length)
        {
            Indice = Indice - Buffer.Length;
        }
        return Indice;
    }

    public void Overwrite()
    {
        int Indice = Array.IndexOf(Buffer, Buffer.Min());
        Buffer[Indice] = Buffer.Max() + 1;
        Buffer[NextIndice(Indice)] = Buffer.Max() + 2;
    }

    public void Remove()
    {
        int Indice = Array.IndexOf(Buffer, Buffer.Min());
        while (Buffer[Indice] == 0)
        {
            Indice = NextIndice(Indice);
        }

        Buffer[Indice] = 0;
        Buffer[NextIndice(Indice)] = 0;

    }
}