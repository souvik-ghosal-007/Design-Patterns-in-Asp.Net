﻿namespace Design_Patterns.SOLID_Principles.Open_Closed_Principle;

public class Product
{
    public string Name;
    public Color Color;
    public Size Size;

    public Product(string name, Color color, Size size)
    {
        Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
        Color = color;
        Size = size;
    }
}