using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HP.Hierarchy
{
    public class HierarchyController : MonoBehaviour
    {
        List<Character> characters = new List<Character>();

        private void AddCharacter(Character character)
        {
            characters.Add(character);
        }

        private void CreateNewCharacter()
        {
            Character character = new Character(this);
            AddCharacter(character);
        }
    }
}