using GrindQuest.ObjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindQuest
{
    //this class is intended to do Logic around item management and inventory management, as well as being used to populate the ItemsReferenceTable
    public class ItemsAndInventoryLogic : IItemsLogic
    {
        //dependency injecting the DbActionsRepo so I don't have to initialise any other classes.
        private readonly IItemsReferenceDbActions _ItemsMasterDbActionsRepo;
        public ItemsAndInventoryLogic(IItemsReferenceDbActions itemsReferenceDbActionsRepo)
        {
            _ItemsMasterDbActionsRepo = itemsReferenceDbActionsRepo;
        }

        //group of Items to Add or Remove from the ItemsMasterTable
        
        

        //Commenting out the method until new item additions are needed.
        public void AddTestItemsToItemsMasterTable()
        {
            //List<Item> ItemsToAdd = new List<Item>();
            //some example items added for testing
            //Item SimpleHealthPotion = new Item()
            //{
            //    ItemName = "Simple Health Potion",
            //    ItemMaxStack = 5,
            //    ItemEffect = "Restore 10 HP",
            //    ItemType = "Potion",
            //};
            //Item StrongHealthPotion = new Item()
            //{
            //    ItemName = "Strong Health Potion",
            //    ItemMaxStack = 5,
            //    ItemEffect = "Restore 50 HP",
            //    ItemType = "Potion"
            //};
            //Item IntenseHealthPotion = new Item()
            //{
            //    ItemName = "Intense Health Potion",
            //    ItemMaxStack = 5,
            //    ItemEffect = "150 HP Recovery",
            //    ItemType = "Potion",
            //};
            //Item SimpleDamagePotion = new Item()
            //{
            //    ItemName = "Simple Damage Potion",
            //    ItemMaxStack = 3,
            //    ItemEffect = "+5 damage to next hit",
            //    ItemType = "food",
            //};
            //Item StrongDamagePotion = new Item()
            //{
            //    ItemName = "Strong Damage Potion",
            //    ItemMaxStack = 5,
            //    ItemEffect = "+25 damage to next hit",
            //    ItemType = "Potion"
            //};
            //Item ChickenSalad = new Item()
            //{
            //    ItemName = "Chicken Salad",
            //    ItemMaxStack = 5,
            //    ItemEffect = "+5 stamina for the next 5 battles",
            //    ItemType = "Food",
            //};
            //Item BreadRoll = new Item()
            //{
            //    ItemName = "Bread Roll",
            //    ItemMaxStack = 5,
            //    ItemEffect = "+3 Stamina for the next 5 battles",
            //    ItemType = "Food"
            //};
            //Item RaspberryPie = new Item()
            //{
            //    ItemName = "Raspberry Pie",
            //    ItemMaxStack = 5,
            //    ItemEffect = "+10 to stamina for the next 5 battles",
            //    ItemType = "Food",
            //};
            //Item ThrowingKnife = new Item()
            //{
            //    ItemName = "Throwing Knife",
            //    ItemMaxStack = 10,
            //    ItemEffect = "Inflict 10 damage",
            //    ItemType = "Thrown"
            //};
            //Item PoisonBomb = new Item()
            //{
            //    ItemName = "Poison Bomb",
            //    ItemMaxStack = 5,
            //    ItemEffect = "Inflict Poison for 3 turns",
            //    ItemType = "Thrown",
            //};

            //ItemsToAdd.Add(SimpleHealthPotion);
            //ItemsToAdd.Add(StrongHealthPotion);
            //ItemsToAdd.Add(IntenseHealthPotion);
            //ItemsToAdd.Add(SimpleDamagePotion);
            //ItemsToAdd.Add(StrongDamagePotion);
            //ItemsToAdd.Add(ChickenSalad);
            //ItemsToAdd.Add(BreadRoll);
            //ItemsToAdd.Add(RaspberryPie);
            //ItemsToAdd.Add(ThrowingKnife);
            //ItemsToAdd.Add(PoisonBomb);


            ////succesful usage of the DbActionsRepo methods to do EF work.
            //foreach (Item i in ItemsToAdd)
            //{
            //    _ItemsMasterDbActionsRepo.InsertItemToItemsMasterDb(i);
            //} 
            ////_ItemsMasterDbActionsRepo.Save();
    }

        public void RemoveItemByItemIdFromItemsMasterTable(int itemId)
        {
            _ItemsMasterDbActionsRepo.RemoveItemFromItemsMasterDb(itemId);
        }

        public void ModifyItemByItemIdFromItemsMasterTable(int itemId, string nameOfColumnToUpdate, Object newValue)
        {
            _ItemsMasterDbActionsRepo.ModifyItemByItemIdFromItemsMasterDb(itemId, nameOfColumnToUpdate, newValue);
        }

        /*again just more examples to clean up what the previous method adds to the datatbase until I start adding items for real. (obselete now)
        public void RemoveItemsFromItemsMasterTable()
        {
            List<string> ItemsToRemove = new List<string>();
            
            string HealthPotion = "Health Potion";
            string StrengthPotion = "Strength Potion";
            string PepsiMax = "Pepsi Max";

            ItemsToRemove.Add(HealthPotion);
            ItemsToRemove.Add(StrengthPotion);
            ItemsToRemove.Add(PepsiMax);

            foreach(var i in ItemsToRemove)
            {
                _dbActionsRepo.RemoveItemFromItemsMasterDb(i);
            }
            _dbActionsRepo.Save();
        }*/
    }
}
