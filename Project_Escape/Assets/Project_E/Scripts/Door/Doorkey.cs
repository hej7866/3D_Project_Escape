using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemData : ScriptableObject
{
    public string mName;
}

[CreateAssetMenu(fileName = "data", menuName = "ItemData/doorKey")]
public class Doorkey : ItemData
{
    public int doorId;

}
