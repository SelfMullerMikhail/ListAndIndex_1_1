using Xunit;

public static void Main()
{
    Func<int[], int, string> take = (source, count) => string.Join(" ", Take(source, count));

    Assert.AreEqual("1 2", take(new[] { 1, 2, 3, 4 }, 2));
    Assert.AreEqual("4", take(new[] { 4 }, 1));
    Assert.AreEqual("", take(new[] { 5 }, 0));

    var num = new Random().Next(0, 1000);
    Assert.AreEqual(num.ToString(), take(new[] { num }, 100500));

    CheckLazyness();
    Console.WriteLine("OK");
}