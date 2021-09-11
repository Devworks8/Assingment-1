using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using A1;

namespace A1UnitTests
{
	[TestClass]
	public class SubsequenceFinderTester
	{
		[TestMethod]
		public void InvalidSubsequence()
		{
			List<int> seq = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 11, 22, 33, 44, 55, 66, 77, 88, 99, 111, 222, 333, 444, 555, 666, 777, 888, 999 };			
			List<int> subSeq = new List<int>() {1 ,5, 777, 33, 22, 9999 }; // 9999 is not in the sequence

			Assert.IsFalse(SubsequenceFinder.IsValidSubsequeuce(seq, subSeq));
		}
		[TestMethod]
		public void ValidSubsequence()
		{
			List<int> seq = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 11, 22, 33, 44, 55, 66, 77, 88, 99, 111, 222, 333, 444, 555, 666, 777, 888, 999 };
			List<int> subSeq = new List<int>() { 1, 5, 777, 33, 22, 999 };

			Assert.IsTrue(SubsequenceFinder.IsValidSubsequeuce(seq, subSeq));
		}
	}
}
