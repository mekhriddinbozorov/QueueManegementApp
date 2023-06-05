public interface IQueue
{
    void AddQueu(string fio, string phoneNumber);

    void ListQueue();

    void NextQueue();

    void AcceptQueue();

    bool ifExistQueue();
}