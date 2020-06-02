using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HP.Hierarchy
{
    public class Character
    {        
        HierarchyController hierarchyController;
        
        Character boss;
        List<Character> underlings = new List<Character>();

        float treasure;
        float power;
        float authority;

        public Character(HierarchyController controller)
        {
            hierarchyController = controller;
        }

        public void AddBoss(Character newBoss)
        {
            boss = newBoss;
        }

        public void AddUnderling(Character newUnderling)
        {
            underlings.Add(newUnderling);
        }
    }    
}
