using System;
using System.Collections.Generic;

namespace LibraryManagementSystem.Models;

public partial class TblBook
{
    public int BookId { get; set; }

    public string? BookTitle { get; set; }

    public string? BookCategory { get; set; }

    public string? BookAuthor { get; set; }

    public string? BookPub { get; set; }

    public string? BookIsbn { get; set; }

    public int? Copyright { get; set; }

    public string? DateAdded { get; set; }

    public string? Status { get; set; }
}
