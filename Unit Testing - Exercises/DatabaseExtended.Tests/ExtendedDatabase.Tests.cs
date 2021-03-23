using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private ExtendedDatabase database;
        private Person person;

        [SetUp]
        public void SetUp()
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

        [Test]
        public void AddingPersonWithConstructor()
        {
            ExtendedDatabase database = new ExtendedDatabase(new Person(10, "Pesho"), new Person(11, "Stoqn"));
            Assert.That(database.Count == 2);
        }

        [Test]
        public void ValidatePersonCountIsSixteenOverConstructor()
        {
            Assert.Throws<ArgumentException>(() => database = new ExtendedDatabase(new Person(1, "Pesho"),
                                                              new Person(2, "Pesho"),
                                                              new Person(3, "Pesho"),
                                                              new Person(4, "Pesho"),
                                                              new Person(5, "Pesho"),
                                                              new Person(6, "Pesho"),
                                                              new Person(7, "Pesho"),
                                                              new Person(8, "Pesho"),
                                                              new Person(9, "Pesho"),
                                                              new Person(10, "Pesho"),
                                                              new Person(11, "Pesho"),
                                                              new Person(12, "Pesho"),
                                                              new Person(13, "Pesho"),
                                                              new Person(14, "Pesho"),
                                                              new Person(15, "Pesho"),
                                                              new Person(16, "Pesho"),
                                                              new Person(17, "Pesho")));
        }

        [Test]
        public void WhenAddingPersonsWithSameNamesByConstructor()
        {
            Assert.Throws<InvalidOperationException>(() => database = new ExtendedDatabase(new Person(5, "Pesho"), new Person(6, "Pesho")));
        }

        [Test]
        public void WhenAddingPersonsWithSameIDByConstructor()
        {
            Assert.Throws<InvalidOperationException>(() => database = new ExtendedDatabase(new Person(5, "Pesho"), new Person(5, "Stoqn")));
        }

        [Test]
        public void ValidateAddPositionOfElements()
        {
            database.Add(new Person(1, "Pesho"));
            int indexOfPesho = database.Count;
            database.Add(new Person(2, "Stoqn"));
            int indexOfStoqn = database.Count;
            Assert.That(indexOfPesho == indexOfStoqn - 1);
        }
    }
}