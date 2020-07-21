using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagObjectFinder : MonoBehaviour
{
    public GameObject[] friends;

    public string tagName;

    public void FindObjects()
    {
        friends = GameObject.FindGameObjectsWithTag(tagName);
    }
}
