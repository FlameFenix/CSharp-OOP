using NUnit.Framework;
using System;

namespace Tests
{
    public class DatabaseTests
    {
        private Database database;
        private const int arrayLength = 16;
        [SetUp]
        public void Setup()
        {
            database = new Database();
        }

        [Test]
        public void DatabaseCapacityExceedSixteenElements()
        {
            int n = 16;
            for (int i = 0; i < n; i++)
            {
                database.Add(i);
            }

            Assert.Throws<InvalidOperationException>(() => this.database.Add(1));
        }

        [Test]
        public void AddItemShouldAddAtLastPositionLikeStack()
        {
            int currentPosition = database.Count;
            int number = 5;

            database.Add(number);

            int[] array = database.Fetch();

            Assert.That(array[currentPosition] != 0);
        }

        [Test]
        public void InputIntegersUsingConstructor()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

            database = new Database(array);

            int[] newArray = database.Fetch();

            Assert.That(newArray, Is.EquivalentTo(array));
        }

        [Test]
        public void WhenCollectionIsEmptyAndUsingRemove()
        {
            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [Test]
        public void WhenCollectionIsNotEmptyAndUsingRemove()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };

            database = new Database(array);

            int[] arrayBeforeRemove = database.Fetch();

            database.Remove();

            int[] arrayAfterRemove = database.Fetch();

            Assert.That(arrayAfterRemove.Length == database.Count);
        }

        [Test]
        public void TestingFetchMethod()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };

            database = new Database(array);

            int[] arrayBeforeRemove = database.Fetch();

            database.Remove();

            int[] arrayAfterRemove = database.Fetch();

            Assert.That(arrayBeforeRemove, Is.Not.EquivalentTo(arrayAfterRemove));
        }
    }
}