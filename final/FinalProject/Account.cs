using System;

public abstract class Account 
{
    protected int _savings;

    public void SetSavings(int savings)
    {
        _savings = savings;
    }
    public int GetSavings()
    {
        return _savings;
    }
    public abstract void UsingSavings();
}