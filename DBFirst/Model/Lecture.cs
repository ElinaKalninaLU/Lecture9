using System;
using System.Collections.Generic;

namespace DBFirst.Model;

public partial class Lecture
{
    public int LectureId { get; set; }

    public string? Room { get; set; }

    public DateTime? Day { get; set; }

    public string? Time { get; set; }

    public int? CourseId { get; set; }

    public int? TeacherId { get; set; }

    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    public virtual Course? Course { get; set; }

    public virtual Teacher? Teacher { get; set; }
}
