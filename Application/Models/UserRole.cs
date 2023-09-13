﻿using System.Data;

namespace SparkDotnet8.Application.Models;

public class UserRole
{
    public int UserId { get; set; }
    public int RoleId { get; set; }

    public virtual User User { get; set; }
    public virtual Role Role { get; set; }
}
