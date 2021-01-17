using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRover;
using MarsRover.Models;
using MarsRover.Managers;
using MarsRover.Enum;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCase1()
        {
            Plateau plateau = new Plateau(5, 5);
            Position position = new Position(1, 2);

            Rover rover = new Rover(position, DirectionEnum.N);
            RoverManager.Execute(rover, plateau, "LMLMLMLMM");
            Assert.AreEqual(RoverManager.CurrentPosition(rover), "1 3 N");
        }

        [TestMethod]
        public void TestCase2()
        {
            Plateau plateau = new Plateau(5, 5);
            Position position = new Position(3, 3);

            Rover rover = new Rover(position, DirectionEnum.E);
            RoverManager.Execute(rover, plateau, "MMRMMRMRRM");
            Assert.AreEqual(RoverManager.CurrentPosition(rover), "5 1 E");
        }
    }
}
