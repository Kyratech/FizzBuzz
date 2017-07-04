using System;

public class FizzBuzzResult
{
    bool fizz;
    bool buzz;
    bool bang;

    public void SetFizz(bool fizzResult)
    {
        fizz = fizzResult;
    }

    public bool GetFizz()
    {
        return fizz;
    }

    public void SetBuzz(bool buzzResult)
    {
        buzz = buzzResult;
    }

    public bool GetBuzz()
    {
        return buzz;
    }

    public void SetBang(bool bangResult)
    {
        bang = bangResult;
    }

    public bool GetBang()
    {
        return bang;
    }

    public bool NoSpecialCase()
    {
        return !(fizz || buzz || bang);
    }
}
