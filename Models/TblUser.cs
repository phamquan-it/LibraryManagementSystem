using System;
using System.Collections.Generic;

namespace LibraryManagementSystem.Models;

public partial class TblUser
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? UserGender { get; set; }

    public string? UserDep { get; set; }

    public string? UserEmail { get; set; }

    public string? UserPass { get; set; }
}
