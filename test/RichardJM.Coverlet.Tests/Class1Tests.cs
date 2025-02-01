using NUnit.Framework;

namespace RichardJM.Coverlet.Tests;

[TestFixture]
public class Class1Tests
{
  [Test]
  public void Add()
  {
    var class1 = new Class1();
    Assert.That(class1.Add(1, 2), Is.EqualTo(3));
  }
}
