using Domain;
using Infrastructure;

GroupRepository repo = new GroupRepository();

while (true)
{
    Console.WriteLine("\n1. Create Group");
    Console.WriteLine("2. Get Group");
    Console.WriteLine("3. Update Group");
    Console.WriteLine("4. Delete Group");
    Console.WriteLine("0. Exit");
    Console.Write("Choose: ");

    int choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1)
    {
        Console.Write("Enter Id: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine() ?? "";

        Console.Write("Enter Description: ");
        string description = Console.ReadLine() ?? "";

        Group group = new Group(id, name, description);
        repo.CreateGroup(group);
    }
    else if (choice == 2)
    {
        Console.Write("Enter Id: ");
        int id = Convert.ToInt32(Console.ReadLine());

        repo.GetGroups(id);
    }
    else if (choice == 3)
    {
        Console.Write("Enter Id: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter new Name: ");
        string name = Console.ReadLine() ?? "";

        Console.Write("Enter new Description: ");
        string description = Console.ReadLine() ?? "";

        repo.UpdateGroup(id, name, description);
    }
    else if (choice == 4)
    {
        Console.Write("Enter Id: ");
        int id = Convert.ToInt32(Console.ReadLine());

        repo.DeleteGroup(id);
    }
    else if (choice == 0)
    {
        break;
    }
    else
    {
        Console.WriteLine("Wrong choice!");
    }
}
