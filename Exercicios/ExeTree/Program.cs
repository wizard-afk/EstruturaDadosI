using System;
using System.Collections.Generic;

public class TreeNode<T>
{
    public T Data { get; set; }
    public TreeNode<T> Parent { get; set; }
    public List<TreeNode<T>> Children { get; set; }
}

public class Tree<T>
{
    public TreeNode<T> Root { get; set; }
}

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Role { get; set; }

    public Person() { }

    public Person(int id, string name, string role)
    {
        Id = id;
        Name = name;
        Role = role;
    }
}

class Program
{
    static void Main()
    {
        Tree<Person> company = new Tree<Person>();
        company.Root = new TreeNode<Person>()
        {
            Data = new Person(100, "Marcin Jamro", "CEO"),
            Parent = null,
            Children = new List<TreeNode<Person>>()
        };

        company.Root.Children.Add(new TreeNode<Person>()
        {
            Data = new Person(1, "John Smith", "Head of Development"),
            Parent = company.Root,
            Children = new List<TreeNode<Person>>()
        });

        company.Root.Children.Add(new TreeNode<Person>()
        {
            Data = new Person(50, "Mary Fox", "Head of Research"),
            Parent = company.Root,
            Children = new List<TreeNode<Person>>()
        });

        company.Root.Children.Add(new TreeNode<Person>()
        {
            Data = new Person(150, "Lily Smith", "Head of Sales"),
            Parent = company.Root,
            Children = new List<TreeNode<Person>>()
        });

        company.Root.Children[2].Children.Add(new TreeNode<Person>()
        {
            Data = new Person(30, "Anthony Black", "Sales Specialist"),
            Parent = company.Root.Children[2],
            Children = new List<TreeNode<Person>>()
        });

        // Exemplo de como acessar dados na árvore
        Console.WriteLine("Nome do CEO: " + company.Root.Data.Name);
        Console.WriteLine("Nome do primeiro funcionário: " + company.Root.Children[0].Data.Name);
    }
}