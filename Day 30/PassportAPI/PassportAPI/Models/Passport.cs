using System;
using System.Collections.Generic;

namespace PassportAPI.Models;

public partial class Passport
{
    public int Pid { get; set; }

    public string Pnumber { get; set; } = null!;

    public string PholderName { get; set; } = null!;

    public string? PofficeCode { get; set; }
}
