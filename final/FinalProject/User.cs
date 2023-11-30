using System;

public class User
{
    protected string _username = "";

    protected string _id = "";
    
    //Getter & Setters
    public void SetUser(string username)
    {
        _username = username;
    }
    public string GetUser()
    {
        return _username;
    }
    public void SetId(string id)
    {
        _id = id;
    }
    public string GetId()
    {
        return _id;
    }

    //Sign up & Log in users
    public void NewUser()
    {

    }

    public void LoadUser()
    {

    }
}