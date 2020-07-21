using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagObjectFinder : MonoBehaviour
{
    public GameObject[] friends;

    public string tagName;

    public CharacterEnum character;

    public void FindObjects()
    {
        friends = GameObject.FindGameObjectsWithTag(tagName);
    }

    public void FindObjectsByEnum()
    {
        friends = GameObject.FindGameObjectsWithTag(character.ToString());
    }
}

public enum CharacterEnum
{
    Warrior,
    Wizard,
    Thief
}

//public static class EnumExtension
//{
//    public static 
//}