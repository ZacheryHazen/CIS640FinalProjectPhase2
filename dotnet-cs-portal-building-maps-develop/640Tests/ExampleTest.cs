using NUnit.Framework;
using Ksu.Cs.Portal.Areas.Maps.Models;

namespace _640Tests;

public class ExampleTest
{
    private Building testBuilding;
    [SetUp]
    public void Setup()
    {
        testBuilding = new Building();
    }

    [Test]
    public void EnsureBuildingIdCanBeAssigned()
    {
        testBuilding.Id = 5;
        Assert.AreEqual(5, testBuilding.Id);
    }
}