﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WinFormsDtLib.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual Manager Manager { get; set; }
}