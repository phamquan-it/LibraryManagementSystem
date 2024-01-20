using System;
using System.Collections.Generic;

namespace LibraryManagementSystem.Models;

public partial class TblTransaction
{
    public int TranId { get; set; }

    public int? BookId { get; set; }

    public string? BookTitle { get; set; }

    public string? BookIsbn { get; set; }

    public string? TranStatus { get; set; }

    public string? TransDate { get; set; }

    public int? UserId { get; set; }

    public string? UserName { get; set; }
}
