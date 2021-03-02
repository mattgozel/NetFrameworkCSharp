using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
   internal static class QuestFactory
    {
        private static readonly List<Quest> _quests = new List<Quest>();

        static QuestFactory()
        {
            List<ItemQuanity> itemsToComplete = new List<ItemQuanity>();
            List<ItemQuanity> rewardItems = new List<ItemQuanity>();

            itemsToComplete.Add(new ItemQuanity(9001, 5));
            rewardItems.Add(new ItemQuanity(1002, 1));

            _quests.Add(new Quest(1, "Clear the herb garden", "Defeat the snakes in the Herbalist's garden",
                                    itemsToComplete, 25, 10, rewardItems));
        }

        internal static Quest GetQuestByID(int id)
        {
            return _quests.FirstOrDefault(q => q.ID == id);
        }
    }
}
