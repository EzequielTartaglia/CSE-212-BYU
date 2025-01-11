using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Dequeue from an empty queue.
    // Expected Result: An InvalidOperationException should be thrown.
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        
        // Attempt to dequeue from an empty queue
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue a single item and then dequeue it.
    // Expected Result: The item should be dequeued successfully.
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        
        // Enqueue a single item
        priorityQueue.Enqueue("Only Item", 2);
        
        // Dequeue the item
        var dequeuedItem = priorityQueue.Dequeue();
        Assert.AreEqual("Only Item", dequeuedItem);
    }

    // Add more test cases as needed below
}

[TestClass]
public class PersonQueueTests
{
    [TestMethod]
    // Scenario: Enqueue and dequeue operations in PersonQueue.
    // Expected Result: The first person in the queue should be dequeued first.
    // Defect(s) Found: 
    public void TestPersonQueue_1()
    {
        var personQueue = new PersonQueue();
        
        // Enqueue people
        personQueue.Enqueue(new Person("Alice", 30));
        personQueue.Enqueue(new Person("Bob", 25));
        personQueue.Enqueue(new Person("Charlie", 20));

        // Dequeue and check the order
        var dequeuedPerson = personQueue.Dequeue();
        Assert.AreEqual("Charlie", dequeuedPerson.Name);

        dequeuedPerson = personQueue.Dequeue();
        Assert.AreEqual("Bob", dequeuedPerson.Name);

        dequeuedPerson = personQueue.Dequeue();
        Assert.AreEqual("Alice", dequeuedPerson.Name);
    }

    [TestMethod]
    // Scenario: Check if the queue is empty after dequeueing all items.
    // Expected Result: The queue should be empty after dequeuing all items.
    // Defect(s) Found: 
    public void TestPersonQueue_2()
    {
        var personQueue = new PersonQueue();
        
        // Enqueue people
        personQueue.Enqueue(new Person("Alice", 30));
        personQueue.Enqueue(new Person("Bob", 25));

        // Dequeue all items
        personQueue.Dequeue();
        personQueue.Dequeue();

        // Check if the queue is empty
        Assert.IsTrue(personQueue.IsEmpty());
    }

    [TestMethod]
    // Scenario: Test the Length property of the queue.
    // Expected Result: The Length should reflect the number of people in the queue.
    // Defect(s) Found: 
    public void TestPersonQueue_3()
    {
        var personQueue = new PersonQueue();
        
        // Enqueue people
        personQueue.Enqueue(new Person("Alice", 30));
        personQueue.Enqueue(new Person("Bob", 25));

        // Check the length of the queue
        Assert.AreEqual(2, personQueue.Length);

        // Dequeue one item and check the length
        personQueue.Dequeue();
        Assert.AreEqual(1, personQueue.Length);
    }

    // Add more test cases as needed below
}

// Helper class to simulate a person