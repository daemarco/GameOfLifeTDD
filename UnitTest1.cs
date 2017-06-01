using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameOfLife2
{
    [TestClass]
    public class UnitTest1
    {
        private GOLMatrix _gol;

        private void SetupGame()
        {
            _gol = new GOLMatrix(3, 3);            

            
        }


        [TestMethod]
        public void GameOfLife_GridInitialised()
        {
            //Arrange
            SetupGame();

            //Act

            //Assert
            Assert.IsTrue(_gol.Cols > 0);
            Assert.IsTrue(_gol.Rows > 0);
            Assert.AreEqual(_gol.Grid.Length, _gol.Cols);
            for (int i=0; i<_gol.Grid.Length; i++)
            {
                Assert.AreEqual(_gol.Grid[i].Length, _gol.Rows);
            }
        }


        [TestMethod]
        public void GameOfLife_Rule1_0NeighborDied()
        {
            //Arrange
            SetupGame();
            _gol.Grid[1][1] = true;

            //Act
            var actual = GOLManager.GetNextIterationStatus(_gol.Grid, 1, 1);

            //Assert
            Assert.IsFalse(actual);
        }


        [TestMethod]
        public void GameOfLife_Rule1_CellCentered_2NeighborLives()
        {
            //Arrange
            SetupGame();
            _gol.Grid[1][1] = true;
            _gol.Grid[0][1] = true;
            _gol.Grid[0][2] = true;

            //Act
            var actual = GOLManager.GetNextIterationStatus(_gol.Grid, 1, 1);
            var actual2 = GOLManager.GetNextIterationStatus(_gol.Grid, 0, 1);
            var actual3 = GOLManager.GetNextIterationStatus(_gol.Grid, 0, 2);
            var actual4 = GOLManager.GetNextIterationStatus(_gol.Grid, 1, 2);

            var actual5 = GOLManager.GetNextIterationStatus(_gol.Grid, 0, 0);
            var actual6 = GOLManager.GetNextIterationStatus(_gol.Grid, 1, 0);
            var actual7 = GOLManager.GetNextIterationStatus(_gol.Grid, 2, 0);
            var actual8 = GOLManager.GetNextIterationStatus(_gol.Grid, 2, 1);
            var actual9 = GOLManager.GetNextIterationStatus(_gol.Grid, 2, 2);


            //Assert
            Assert.IsTrue(actual);
            Assert.IsTrue(actual2);
            Assert.IsTrue(actual3);
            Assert.IsTrue(actual4);

            Assert.IsFalse(actual5);
            Assert.IsFalse(actual6);
            Assert.IsFalse(actual7);
            Assert.IsFalse(actual8);
            Assert.IsFalse(actual9);

        }





    }
}
