using System;
using System.Collections.Generic;

public class ListManager
{
    public void AddElement(List<int> list, int element)
    {
        if (list == null) throw new ArgumentNullException(nameof(list));
        list.Add(element);
    }

    public bool RemoveElement(List<int> list, int element)
    {
        if (list == null) throw new ArgumentNullException(nameof(list));
        return list.Remove(element);
    }

    public int GetSize(List<int> list)
    {
        if (list == null) throw new ArgumentNullException(nameof(list));
        return list.Count;
    }
}

using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class ListManagerTests
{
    private ListManager listManager;
    private List<int> testList;

    [SetUp]
    public void Setup()
    {
        listManager = new ListManager();
        testList = new List<int>();  // Initializes a new empty list before each test
    }

    [Test]
    public void AddElement_ShouldAddElementToList()
    {
        listManager.AddElement(testList, 5);
        listManager.AddElement(testList, 10);

        Assert.Contains(5, testList);
        Assert.Contains(10, testList);
        Assert.AreEqual(2, testList.Count);
    }

    [Test]
    public void RemoveElement_ShouldRemoveElementFromList()
    {
        testList.Add(5);
        testList.Add(10);
        bool removed = listManager.RemoveElement(testList, 5);

        Assert.IsTrue(removed);
        Assert.IsFalse(testList.Contains(5));
        Assert.AreEqual(1, testList.Count);
    }

    [Test]
    public void RemoveElement_ShouldReturnFalse_IfElementNotInList()
    {
        testList.Add(10);
        bool removed = listManager.RemoveElement(testList, 99);  // 99 is not in the list

        Assert.IsFalse(removed);
        Assert.AreEqual(1, testList.Count);
    }

    [Test]
    public void GetSize_ShouldReturnCorrectSize()
    {
        testList.Add(1);
        testList.Add(2);
        testList.Add(3);

        Assert.AreEqual(3, listManager.GetSize(testList));

        testList.Remove(2);

        Assert.AreEqual(2, listManager.GetSize(testList));
    }

    [Test]
    public void Methods_ShouldThrowException_ForNullList()
    {
        Assert.Throws<ArgumentNullException>(() => listManager.AddElement(null, 5));
        Assert.Throws<ArgumentNullException>(() => listManager.RemoveElement(null, 5));
        Assert.Throws<ArgumentNullException>(() => listManager.GetSize(null));
    }
}