
namespace TestChesse

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            List<string> movesCode = Test_Wheelzy.Program.moveknight(8, 8);
            List<string> realmoves = new List<string> { "(7,6)", "(6,7)" };

            Assert.IsTrue(AreListsEqual(realmoves, movesCode));

        }
        [TestMethod]
        public void Test2()
        {
            List<string> movesCode = Test_Wheelzy.Program.moveknight(7, 7);
            List<string> realmoves = new List<string> { "(5,6)", "(5,8)","(6,5)", "(8,5)" };

            Assert.IsTrue(AreListsEqual(realmoves, movesCode));

        }
        [TestMethod]
        public void Test3()
        {
            List<string> movesCode = Test_Wheelzy.Program.moveknight(3, 5);
            List<string> realmoves = new List<string> { "(1,4)","(1,6)", "(2,7)", "(4,7)", "(5,6)", "(5,4)", "(4,3)", "(2,3)" };

            Assert.IsTrue(AreListsEqual(realmoves, movesCode));

        }
        [TestMethod]
        public void Test4()
        {
            List<string> movesCode = Test_Wheelzy.Program.moveknight(6, 2);
            List<string> realmoves = new List<string> { "(4,1)", "(4,3)", "(5,4)", "(7,4)", "(8,3)", "(8,1)" };

            Assert.IsTrue(AreListsEqual(realmoves, movesCode));

        }
        [TestMethod]
        public void Test5()
        {
            List<string> movesCode = Test_Wheelzy.Program.moveknight(7, 5);
            List<string> realmoves = new List<string> { "(5,4)", "(6,3)", "(8,3)", "(5,6)", "(6,7)", "(8,7)" };

            Assert.IsTrue(AreListsEqual(realmoves, movesCode));

        }
        [TestMethod]
        public void Test6()
        {
            List<string> movesCode = Test_Wheelzy.Program.moveknight(2, 6);
            List<string> realmoves = new List<string> { "(3,4)", "(4,5)", "(4,7)", "(3,8)", "(1,8)", "(1,4)" };

            Assert.IsTrue(AreListsEqual(realmoves, movesCode));

        }
        [TestMethod]
        public void Test7()
        {
            List<string> movesCode = Test_Wheelzy.Program.moveknight(1, 1);
            List<string> realmoves = new List<string> { "(3,2)", "(2,3)" };

            Assert.IsTrue(AreListsEqual(realmoves, movesCode));

        }
        [TestMethod]
        public void Test8()
        {
            List<string> movesCode = Test_Wheelzy.Program.moveknight(6, 5);
            List<string> realmoves = new List<string> { "(5,3)", "(4,4)", "(4,6)", "(5,7)", "(7,7)", "(8,6)", "(8,4)", "(7,3)" };

            Assert.IsTrue(AreListsEqual(realmoves, movesCode));

        }

        /// <summary>
        /// Order a list and not import the order for the
        /// </summary>
        /// <param name="realmoves">Real moves calculated by user</param>
        /// <param name="movesCode"></param>
        /// <returns>If is equal the list</returns>
        private bool AreListsEqual(List<string> realmoves, List<string> movesCode)
        {
            if (realmoves.Count != movesCode.Count)
                return false;

            realmoves.Sort();
            movesCode.Sort();

            for (int i = 0; i < realmoves.Count; i++)
            {
                if (realmoves[i] != movesCode[i])
                    return false;
            }

            return true;
        }
    }
}