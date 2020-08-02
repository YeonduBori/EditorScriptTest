using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[Serializable]
public struct TableProperty
{
    public string name;
    public Text info;
}

public class TagObjectFinder : MonoBehaviour
{
    public GameObject[] friends;
    public string tagName;
    public CharacterEnum character;

    //public UnityEvent testUnityEvent;
    //public DynamicUnityEvent testDynamicUnityEvent;
    public TableProperty[] properties;
    public void FindObjects()
    {
        friends = GameObject.FindGameObjectsWithTag(tagName);
        //testDynamicUnityEvent?.Invoke("Use Like This");
        //testUnityEvent?.Invoke();
        //testDynamicUnityEvent?.Invoke(new GameObject("Character"),"바뀐 닉네임");
    }

    public void FindObjectsByEnum()
    {
        friends = GameObject.FindGameObjectsWithTag(character.ToString());
    }
}

[Serializable]
public class DynamicUnityEvent : UnityEvent<GameObject, string>
{}

public enum CharacterEnum
{
    Warrior,
    Wizard,
    Thief
}