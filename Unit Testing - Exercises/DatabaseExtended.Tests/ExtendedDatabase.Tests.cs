using NUnit.Framework;
using System;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private ExtendedDatabase database;
        private Person person;

        [SetUp]
        public void Setup()
        {
            database = new ExtendedDatabase();
        }

        [Test]
        public void WhenThereHasAUserWithThatName()
        {
            person = new Person(10, "Pesho");
            database.Add(person);
            Assert.Throws<InvalidOperationException>(() => database.Add(person));
        }

        [Test]
        public void WhenThereHasAUserWithThatID()
        {
            person = new Person(10, "Pesho");
            Person Stoqn = new Person(10, "Stoqn");

            database.Add(person);

            Assert.Throws<InvalidOperationException>(() => database.Add(Stoqn));
        }

        [Test]
        public void WhenThereHasAMoreUsersThanAllowed()
        {
            int n = 16;

            for (int i = 0; i < n; i++)
            {
                person = new Person(i, $"Stoqn {i}");
                database.Add(person);
            }

            Assert.Throws<InvalidOperationException>(() => database.Add(person = new Person(n + 1, $"Stoqn {n + 1}")));
        }

        [Test]
        public void WhenAddingNewPerson()
        {
            person = new Person(10, "Pesho");

            int currentCount = database.Count;

            database.Add(person);

            Assert.That(currentCount != database.Count);
        }

        [Test]

        public void WhenRemovingUserFromEmptyDatabase()
        {
            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [Test]
        public void WhenRemovingUserFromFilledDatabase()
        {
            int n = 5;

            for (int i = 0; i < n; i++)
            {
                person = new Person(i, $"Name{i}");
                database.Add(person);
            }

            database.Remove();

            Assert.That(database.Count == n - 1);
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void WhenFindingPersonByUsernameNameShouldntEmptyOrNull(string name)
        {
            Assert.Throws<ArgumentNullException>(() => database.FindByUsername(name));
        }

        [Test]
        [TestCase("Stoqn")]
        public void WhenFindingPersonByUsernameName(string name)
        {
            person = new Person(10, name);
            database.Add(person);
            Assert.That(database.FindByUsername(name), Is.EqualTo(person));
        }

        [Test]
        [TestCase(-5)]
        public void WhenFindingPersonByIdItShouldBePositiveNumber(long id)
        {
            person = new Person(id, "stoqn");
            database.Add(person);
            Assert.Throws<ArgumentOutOfRangeException>(() => database.FindById(id));
        }

        [Test]
        [TestCase(8)]
        public void WhenFindingPersonByIdIfIdDoesNotExist(long id)
        {
            person = new Person(5, "stoqn");
            database.Add(person);
            Assert.Throws<InvalidOperationException>(() => database.FindById(id));
        }

        [Test]
        [TestCase(8)]
        public void WhenFindingPersonById(long id)
        {
            person = new Person(id, "stoqn");
            database.Add(person);
            Assert.That(database.FindById(id), Is.EqualTo(person));
        }
    }
}