using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CounterTest
{
    [Test]
    public void TestIncrement()
    {
        //Assign
        var counter = new BasicCounter(0);

        //Act
        counter.Increment();

        //Assert
        Assert.AreEqual(1, counter.Count);
    }

    [Test]
    public void TestMaxCount()
    {
        //Assign
        var counter = new BasicCounter(10);

        //Act
        counter.Increment();

        //Assert
        Assert.AreEqual(9, counter.Count);
    }
}
