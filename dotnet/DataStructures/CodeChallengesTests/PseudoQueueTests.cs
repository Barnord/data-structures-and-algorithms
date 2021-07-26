using System;
using Xunit;
using CodeChallenges;
using DataStructures;

namespace CodeChallengesTests
{
  public class PseudoQueueTests
  {
    [Fact]
    public void AEnqueueDequeue()
    {
      PseudoQueue q = new PseudoQueue();
      q.Enqueue(1);

      Assert.Equal(1, q.DeQueue());
    }

    [Fact]
    public void BOrder()
    {
      PseudoQueue q = new PseudoQueue();
      q.Enqueue(1);
      q.Enqueue(2);
      q.Enqueue(3);

      Assert.Equal(1, q.DeQueue());
      Assert.Equal(2, q.DeQueue());
      Assert.Equal(3, q.DeQueue());
    }

    [Fact]
    public void CException()
    {
      PseudoQueue q = new PseudoQueue();

      Assert.Throws<NullReferenceException>(() => q.DeQueue());
    }
  }
}
