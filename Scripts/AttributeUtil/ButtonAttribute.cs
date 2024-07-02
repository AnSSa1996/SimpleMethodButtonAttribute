using System;

[AttributeUsage(AttributeTargets.Method)]
public class ButtonAttribute : Attribute
{
    public string ButtonName { get; private set; }

    public ButtonAttribute(string name)
    {
        ButtonName = name;
    }
}