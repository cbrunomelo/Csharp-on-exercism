using System.Collections.Generic;
using System.Linq;
public class GradeSchool
{
    private List<RosterEntry> _schoolRoster = new List<RosterEntry>();
    public void Add(string student, int grade)
    {
        if (!_schoolRoster.Contains(new RosterEntry { Name = student }))
            _schoolRoster.Add(new RosterEntry { Name = student, Grade = grade });

    }
    public IEnumerable<string> Roster()
        => _schoolRoster.OrderBy(s => s.Grade).ThenBy(s => s.Name).Select(s => s.Name);
    public IEnumerable<string> Grade(int grade)
        => _schoolRoster.Where(s => s.Grade == grade).Select(s => s.Name).OrderBy(s => s);
}
public class RosterEntry : IEquatable<RosterEntry>
{
    public string Name { get; set; }
    public int Grade { get; set; }

    public bool Equals(RosterEntry? other)
    {
        if (Name == other?.Name)
            return true;
        return false;
    }
}