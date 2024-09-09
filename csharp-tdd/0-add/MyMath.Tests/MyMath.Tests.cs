using NUnit.Framework;
using System;
namespace MyMath.Tests
{


public class Tests
{
    [SetUp]
    public void Setup()
    {
    }


    [Test]
    public void PositiveNumbers()
    {
        int a = 3;
        int b = 4;
        int expected = 7;


        int result = Operations.Add(a, b);


        Assert.That(result, Is.EqualTo(expected));
        Console.WriteLine("Test Run Successful");
    }


    [Test]
    public void NegativeNumbers()
    {
        int a = -7;
        int b = -3;
        int expected = -10;


        int result = Operations.Add(a, b);


        Assert.That(result, Is.EqualTo(expected));
    }


    [Test]
    public void NegativePositive()
    {
        int a = -8;
        int b = 6;
        int expected = -2;


        int result = Operations.Add(a, b);


        Assert.That(result, Is.EqualTo(expected));
    }


    [Test]
    public void PositiveNegative()
    {
        int a = 8;
        int b = -6;
        int expected = 2;


        int result = Operations.Add(a, b);


        Assert.That(result, Is.EqualTo(expected));
    }


    [Test]
    public void OneZero()
    {
        int a = 9;
        int b = 0;
        int expected = 9;


        int result = Operations.Add(a, b);


        Assert.That(result, Is.EqualTo(expected));
    }


    [Test]
    public void Zeros()
    {
        int a = 0;
        int b = 0;
        int expected = 0;


        int result = Operations.Add(a, b);


        Assert.That(result, Is.EqualTo(expected));
    }


    [Test]
    public void SameResult_Test()
    {
        int a = 15;
        int b = 85;
        int expected = 100;


        int result1 = Operations.Add(a, b);
        int result2 = Operations.Add(a, b);


        Assert.That(result1, Is.EqualTo(expected));
        Assert.That(result2, Is.EqualTo(expected));
    }


    [Test]
    public void LoopTest()
    {
        int a = 13;
        int b = 17;
        int expected = 30;




        for (int i = 0; i < 5; i++)
        {
            int result = Operations.Add(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}

}