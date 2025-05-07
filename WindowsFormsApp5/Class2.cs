using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    internal class Class2
    {
    }
}
public class ComboBoxItem
{
    public int Id { get; }
    public string Name { get; }

    public ComboBoxItem(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public override string ToString()
    {
        return Name;
    }
}