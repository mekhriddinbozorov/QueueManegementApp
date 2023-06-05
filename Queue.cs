using System.Text;

public class Queue : IQueue
{
    private static int id = 0;

    public Queue(string fio, string phoneNumber)
    {
        QueueId = ++id;
        Fio = fio;
        PhoneNumber = phoneNumber;
    }

    public int QueueId { get; private set; }
    public string Fio { get; private set; }
    public string PhoneNumber { get; private set; }

    public Queue<Queue> queueList = new Queue<Queue>();
    public void AcceptQueue()
    {
        var builder = new StringBuilder();

        builder.AppendLine("Navbatdagi inson :");
        builder.AppendLine("----------------------------------");
        builder.Append("FIO".PadRight(15));
        builder.AppendLine("PhoneNumber".PadRight(15));

        builder.Append(queueList.Peek().Fio.Substring(0, Math.Min(queueList.Peek().Fio.Length, 13)).PadRight(15));
        var phonuNumber = new StringBuilder(queueList.Peek().PhoneNumber);
        phonuNumber.Remove(5, 2);
        phonuNumber.Insert(5, "**");

        phonuNumber.Remove(12, 2);
        phonuNumber.Insert(12, "**");

        builder.AppendLine($"{phonuNumber}".PadRight(15));
        builder.AppendLine("----------------------------------");

        Console.WriteLine(builder);

        // asdfasdf 123123
        queueList.Dequeue();
    }

    public void AddQueu(string fio, string phoneNumber)
    {
        var queee = new Queue(fio, phoneNumber);
        queueList.Enqueue(queee);
    }

    public bool ifExistQueue()
    {
        if (queueList.Count() > 0)
            return true;
        else
            return false;
    }

    public void ListQueue()
    {
        var builder = new StringBuilder();

        builder.AppendLine("Navbatdagilar:");
        builder.AppendLine("----------------------------------");
        builder.Append("Id".PadRight(3));
        builder.Append("FIO".PadRight(15));
        builder.AppendLine("PhoneNumber".PadRight(15));

        int ctn = 0;

        foreach (var queue in queueList.DistinctBy(p => p.QueueId))
        {
            ctn++;
            builder.Append($"{ctn}".PadRight(3));
            builder.Append(queue.Fio.Substring(0, Math.Min(queue.Fio.Length, 13)).PadRight(15));

            //+998 ** 123 12 12
            var phonuNumber = new StringBuilder(queue.PhoneNumber);
            phonuNumber.Remove(5, 2);
            phonuNumber.Insert(5, "**");

            phonuNumber.Remove(12, 2);
            phonuNumber.Insert(12, "**");

            builder.AppendLine($"{phonuNumber}".PadRight(15));
        }

        builder.AppendLine("-------------------------------------------------------------");

        Console.WriteLine(builder);
    }

    public void NextQueue()
    {
        var builder = new StringBuilder();

        builder.AppendLine("Navbatdagi inson :");
        builder.AppendLine("----------------------------------");
        builder.Append("FIO".PadRight(15));
        builder.AppendLine("PhoneNumber".PadRight(15));

        builder.Append(queueList.Peek().Fio.Substring(0, Math.Min(queueList.Peek().Fio.Length, 13)).PadRight(15));
        var phonuNumber = new StringBuilder(queueList.Peek().PhoneNumber);
        phonuNumber.Remove(5, 2);
        phonuNumber.Insert(5, "**");

        phonuNumber.Remove(12, 2);
        phonuNumber.Insert(12, "**");

        builder.AppendLine($"{phonuNumber}".PadRight(15));
        builder.AppendLine("----------------------------------");

        Console.WriteLine(builder);
    }
}