using System;
using System.Collections.Generic;

namespace WebLibrary.Models;

public class ViewBookIssued
{
    public string   nameBook{ get; set; } = null!;
    public string     languageBook{ get; set; } = null!;
    public int pageBook { get; set; }
    public int countBook { get; set; } 
    public string  genreBook { get; set; } = null!;
    public string  autor { get; set; } = null!;
    public DateOnly autorBithday { get; set; } 
    public long  CountIssuedBook { get; set; } 
}