using System.Collections.Generic;

public class WeeklyCalendar
{
    private IList<WeeklyEntry> weeklySchedule;

    public WeeklyCalendar()
    {
        this.weeklySchedule = new List<WeeklyEntry>();
    }

    public IEnumerable<WeeklyEntry> WeeklySchedule
    {
        get { return this.weeklySchedule; }
    }

    public void AddEntry(string weekday, string notes)
    {
        this.weeklySchedule.Add(new WeeklyEntry(weekday, notes));
    }
}
