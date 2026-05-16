using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario:
    // Add three items with different priorities.
    // Expected Result:
    // The item with the highest priority should be removed first.
    // Defect(s) Found:
    // Highest priority item was not always selected correctly.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("Tim", result);
    }

    [TestMethod]
    // Scenario:
    // Add multiple items with the same highest priority.
    // Expected Result:
    // The first item added with the highest priority should be removed first (FIFO behavior).
    // Defect(s) Found:
    // Queue was not preserving FIFO order for equal priorities.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 5);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("Bob", result);
    }

    [TestMethod]
    // Scenario:
    // Attempt to dequeue from an empty queue.
    // Expected Result:
    // InvalidOperationException should be thrown with the correct message.
    // Defect(s) Found:
    // No defects found after correcting empty queue handling.
    public void TestPriorityQueue_EmptyQueue()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }
}