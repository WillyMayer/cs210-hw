using System;

public class Assignment
{
    private string _name;
    private string _topic;

    public Assignment(string name, string topic)
    {
        _name = name;
        _topic = topic;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetTopic()
    {
        return _topic;
    }
    public string GetSumary()
    {
        return $"{_name} - {_topic}";
    }
}