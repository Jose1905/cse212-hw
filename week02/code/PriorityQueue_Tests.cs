using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following values and priority: Bob (2), Tim (5), Sue (3)
    // Run until the queue is empty.
    // Expected Result: [Tim, Sue, Bob]
    // Defect(s) Found: Dequeue method not removing the item from the queue. Dequeue method not comparing last item's priority
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);

        List<String> expectedResult = ["Tim", "Sue", "Bob"];
        for (int i = 0; i < expectedResult.Count(); i++)
        {
            var item = priorityQueue.Dequeue();
            Assert.AreEqual(item, expectedResult[i]);
        }
    }

    [TestMethod]
    // Scenario: Create a queue with the following values and priority: Bob (2), Tim (5), Sue (3), Mark (5)
    // Run until the queue is empty.
    // Expected Result: [Tim, Mark, Sue, Bob]
    // Defect(s) Found: Dequeue method returned the last item with the highest priority instead of the first one.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);
        priorityQueue.Enqueue("Mark", 5);

        List<String> expectedResult = ["Tim", "Mark", "Sue", "Bob"];
        for (int i = 0; i < expectedResult.Count(); i++)
        {
            var item = priorityQueue.Dequeue();
            Assert.AreEqual(item, expectedResult[i]);
        }
    }

    [TestMethod]
    // Scenario: Try to dequeue an item from an empty queue
    // Expected Result: Exception should be thrown with appropriate error message.
    // Defect(s) Found: 
    public void TestPriorityQueue_3()
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
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                 string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }
    }
}