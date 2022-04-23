using NUnit.Framework;
using Ksu.Cs.Portal.Areas.Maps.Models;



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
        testBuilding.Id = 6;
        Assert.AreEqual(6, testBuilding.Id);
    }
}