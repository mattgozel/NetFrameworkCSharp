using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RPGInventory;
using RPGInventory.Items.Containers;
using RPGInventory.Items.Potions;
using RPGInventory.Items.Weapons;

namespace RPGInventory.Tests
{
    [TestFixture]
    public class RPGInventoryTests
    {
        [Test]
        public void CanAddItemToBackpack()
        {
            BackPack b = new BackPack();
            HealthPotion p = new HealthPotion();

            AddItemStatus actual = b.AddItem(p);
            Assert.AreEqual(AddItemStatus.Success, actual);
        }

        [Test]
        public void CanRemoveItemFromBackPack()
        {
            BackPack b = new BackPack();
            HealthPotion p = new HealthPotion();

            b.AddItem(p);

            Item actual = b.RemoveItem();
            Assert.AreEqual(p, actual);
        }

        [Test]
        public void CannotAddItemToFullBackpack()
        {
            BackPack b = new BackPack();
            HealthPotion p = new HealthPotion();

            b.AddItem(p);
            b.AddItem(p);
            b.AddItem(p);
            b.AddItem(p);

            AddItemStatus actual = b.AddItem(p);
            Assert.AreEqual(AddItemStatus.BagIsFull, actual);
        }

        [Test]
        public void EmptyBagReturnsNull()
        {
            BackPack b = new BackPack();
            Item item = b.RemoveItem();
            Assert.IsNull(item);
        }

        [Test]
        public void PotionSatchelOnlyAllowPotions()
        {
            PotionSatchel satchel = new PotionSatchel();
            GreatAxe axe = new GreatAxe();

            AddItemStatus result = satchel.AddItem(axe);
            Assert.AreEqual(AddItemStatus.ItemWrongType, result);

            HealthPotion p = new HealthPotion();
            AddItemStatus result1 = satchel.AddItem(p);
            Assert.AreEqual(AddItemStatus.Success, result1);
        }

        [Test]
        public void WeightRestrictedBagRestrictsWeight()
        {
            WetPaperSack sack = new WetPaperSack();
            HealthPotion p = new HealthPotion();
            Assert.AreEqual(AddItemStatus.Success, sack.AddItem(p));

            GreatAxe a = new GreatAxe();
            Assert.AreEqual(AddItemStatus.ItemTooHeavy, sack.AddItem(a));

            Item item = sack.RemoveItem();
            Sword s = new Sword();
            Assert.AreEqual(AddItemStatus.Success, sack.AddItem(s));
        }
    }
}
