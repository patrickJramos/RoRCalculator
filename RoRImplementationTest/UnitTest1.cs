using RoR;
using RoRImplementation.Items;
using System;
using Xunit;

namespace RoRImplementationTest
{
    public class UnitTest1
    {
        IGameManager _gameManager { get; set; }
        public UnitTest1(IGameManager gameManager) => _gameManager = gameManager;

        [Fact]
        public void GiveItemToPlayerShouldGiveItemToThePlayer()
        {
            int itemId = 1;
            _gameManager.GiveItemToPlayer(itemId);


            var expectedStackAmount = 1;
            var actualStackAmount = _gameManager.Player.Inventory[itemId].StackAmout;

            Assert.Equal(expectedStackAmount, actualStackAmount);

            _gameManager.GiveItemToPlayer(itemId);
            _gameManager.GiveItemToPlayer(itemId);
            _gameManager.GiveItemToPlayer(itemId);

            expectedStackAmount = 4;
            actualStackAmount = _gameManager.Player.Inventory[itemId].StackAmout;
            Assert.Equal(expectedStackAmount, actualStackAmount);

            var expectedMultiplier = 12;
            var actualMultiplier = ((AtGMissile)_gameManager.Player.Inventory[itemId].Item).Multiplier;
            Assert.Equal(expectedMultiplier, actualMultiplier);

            var expectedDamage = 16;

            _gameManager.Player.Skills[0].Activate(_gameManager.Player);
            var actualDamage = _gameManager.Player.Stats.TotalDamageDealt;

            Assert.Equal(expectedDamage, actualDamage);


            
        }

        [Fact]
        public void ThisWorks()
        {
            IGameManager notExpected = null;
            Assert.NotEqual(this._gameManager, notExpected);
        }

    }
}
