using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Adding three items with different priorities
    // Expected Result: The item with the highest priority should be removed first
    // Defect(s) Found: The last item was not checked because the loop stopped before the final index value. 
    // Error Message: Assert.AreEqual failed. Expected:<High>. Actual:<Medium>.
    public void TestPriorityQueue_HighestPriority()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 5);
        priorityQueue.Enqueue("High", 10);
        // Assert.Fail("Implement the test case and then remove this.");
        Assert.AreEqual("High", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Add multiple items with the same highest priority
    // Expected Result: Removing first the item wiht the highest priority
    // Defect(s) Found: The code used >= operator which selected the later item with the same priority instead of FIFO order.
    // Error Message: Assert.AreEqual failed. Expected:<first>. Actual:<Second>. 
    public void TestPriorityQueue_SamePriority()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 10);
        priorityQueue.Enqueue("Second", 10);
        priorityQueue.Enqueue("Third", 5);
        // Assert.Fail("Implement the test case and then remove this.");
        Assert.AreEqual("First", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: Dequeue multiple times after adding several items.
    // Expected Result: Removed items should not remain in the queue
    // Defect(s) Found: Dequeue returned the value but did not remove the item from the queue.
    // Error Message: Assert.AreEqual failed. Expected:<B>. Actual:<A>.
    public void TestPriorityQueue_RemoveItem()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 3);
        
        Assert.AreEqual("B", priorityQueue.Dequeue());
        Assert.AreEqual("A", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Try dequeueing from an empty queue
    // Expected Result: InvalidOperationException wiht message "The queue is empty"
    // Defect(s) Found: None.
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }

}