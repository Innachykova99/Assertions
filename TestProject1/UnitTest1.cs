namespace TestProject1
{
    public class Tests
    {
        // Created tests using Classic Model
        [Test]
        [Category("Text tests")]
        [MaxTime(5)]
        public void Test1()
        {
            string expectedString = "Your bunny wrote";
            string actualString = "Your bunny wrote";
            Assert.AreEqual(expectedString, actualString, $"The {actualString} is not equal to {expectedString}");
        }

        [Test]
        [Category("Text tests")]
        public void Test2()
        {
            List<string> AnimalsExpected = new List<string>()
            {
                "Cat",
                "Raccoon",
                "Giraffe"
            };
            List<string> AnimalsActual = new List<string>()
            {
                "Cat",
                "Raccoon",
                "Giraffe"
            };
            Assert.AreEqual(AnimalsExpected, AnimalsActual, $"The {AnimalsExpected} is not equal to {AnimalsActual}");
        }

        [Test]
        [Category("Text tests")]
        public void Test3()
        {
            List<string> Sentences = new List<string>()
            {
            "This is a test string",
            "How to make a perfect code",
            "Cats are cute"
            };
            string actualstring = "Cats are cute";
            Assert.Contains(actualstring, Sentences, $"The {Sentences} doesn't contain {actualstring}");
        }
        [Test]
        [Category("Numeric tests")]
        public void Test4()
        {
            int a = 10;
            int b = 5;
            Assert.IsTrue(a > b, $"Expected number: {a} was less than actual number: {b}");
        }

        // Created tests using Constraint Model
        [Test]
        [Category("Constraint")]
        public void Test5()
        {
            string expectedString = "Your bunny wrote";
            string actualString = "Your bunny wrote";
            Assert.That(actualString, Is.EqualTo(expectedString), $"The {actualString} is not equal to {expectedString}");
        }

        [Test]
        [Category("Constraint")]
        public void Test6()
        {
            List<string> AnimalsExpected = new List<string>()
            {
                "Cat",
                "Raccoon",
                "Giraffe"
            };
            List<string> AnimalsActual = new List<string>()
            {
                "Cat",
                "Raccoon",
                "Giraffe"
            };
            Assert.That(AnimalsActual, Is.EqualTo(AnimalsExpected), $"The {AnimalsActual} is not equal to {AnimalsExpected}");
        }

        [Test]
        [Category("Constraint")]
        [MaxTime(3)]
        public void Test7()
        {
            List<string> Sentences = new List<string>()
            {
            "This is a test string",
            "How to make a perfect code",
            "Cats are cute"
            };
            string actualstring = "Cats are cute";
            Assert.That(Sentences, Contains.Item(actualstring), $"The {Sentences} doesn't contain {actualstring}");

        }
        [Test]
        [Category("Constraint")]
        [Category("Numeric tests")]
        [Description("This test compares two int values")]
        public void Test8()
        {
            int a = 10;
            int b = 5;
            Assert.That(a > b, Is.True, $"Number {a} is not greater than {b}");
        }

        [Test]
        [Explicit("Duplicating logic from test #8")]
        public void Test9()
        {
            int a = 11;
            int b = 6;
            Assert.That(a > b, Is.True, $"Number {a} is not greater than {b}");
        }
    }
}


