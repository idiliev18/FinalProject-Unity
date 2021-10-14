public class Achievement 
{
    public int id;
    public string name;
    public bool isAchieved;

    public Achievement(int id, string name)
    {
        this.id = id;
        this.name = name;
        this.isAchieved = false;
    }
}
