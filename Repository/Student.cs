using System;
using System.Collections.Generic;
using System.Text;

namespace Repository;

internal class Student : ISearchable<int>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Lastname { get; set; }
}

internal class Employee : ISearchable<int>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Lastname { get; set; }
    public decimal Salary { get; set; }
}