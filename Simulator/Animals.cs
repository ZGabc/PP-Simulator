﻿using System.Xml.Linq;
namespace Simulator
{
    public class Animals
    {
        public required string Description { get; init; }
        public uint Size { get; set; } = 3;
        public void Info()
        {
            Console.WriteLine($"{Description} <{Size}>");
        }
    }
}

/*
 * Dodaj do niej właściwość do odczytu Info
 * zwracającą opis i liczebność w formie: Dogs < 3 >.

Zrób commit Stwory.
*/