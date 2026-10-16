using Domain;

namespace Infrastructure;

public class GroupRepository
{
    private List<Group> groups = new List<Group>();

    public void CreateGroup(Group group)
    {
        groups.Add(group);
        Console.WriteLine("Group created!");
    }

    public void GetGroups(int id)
    {
        Group? group = groups.Find(g => g.Id == id);

        if (group != null)
        {
            Console.WriteLine($"Id: {group.Id}");
            Console.WriteLine($"Name: {group.Name}");
            Console.WriteLine($"Description: {group.Description}");
        }
        else
        {
            Console.WriteLine("Group not found!");
        }
    }

    public void UpdateGroup(int id, string name, string description)
    {
        Group? group = groups.Find(g => g.Id == id);

        if (group != null)
        {
            group.Name = name;
            group.Description = description;

            Console.WriteLine("Group updated!");
        }
        else
        {
            Console.WriteLine("Group not found!");
        }
    }

    public void DeleteGroup(int id)
    {
        Group? group = groups.Find(g => g.Id == id);

        if (group != null)
        {
            groups.Remove(group);
            Console.WriteLine("Group deleted!");
        }
        else
        {
            Console.WriteLine("Group not found!");
        }
    }
}