using Platform.Models;

namespace Platform.Services;

public class RecordService : IRecordService
{
    static List<Record> Records { get; }
    static int nextId = 3;
    static RecordService()
    {
        Records = new List<Record>
        {
            new Record { Id = 1, Name = "Classic Italian", IsActive = false, Bio = "See Him" },
            new Record { Id = 2, Name = "Veggie", IsActive = true, Bio = "And Him" }
        };
    }

    public static List<Record> GetAll() => Records;

    public static Record? Get(int id) => Records.FirstOrDefault(p => p.Id == id);

    public static void Add(Record record)
    {
        record.Id = nextId++;
        Records.Add(record);
    }

    public static void Delete(int id)
    {
        var record = Get(id);
        if(record is null)
            return;

        Records.Remove(record);
    }

    public static void Update(Record record)
    {
        var index = Records.FindIndex(p => p.Id == record.Id);
        if(index == -1)
            return;

        Records[index] = record;
    }

}