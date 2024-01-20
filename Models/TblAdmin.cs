using System;
using System.Collections.Generic;

namespace LibraryManagementSystem.Models;

public partial class TblAdmin
{
    public int AdminId { get; set; }

    public string? AdminName { get; set; }

    public string? AdminEmail { get; set; }

    public string? AdminPass { get; set; }
}
