﻿using System;
using System.Collections.Generic;

namespace GenericsProject.Models;

public partial class UsersEvent
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int EventId { get; set; }

    public virtual Event Event { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
