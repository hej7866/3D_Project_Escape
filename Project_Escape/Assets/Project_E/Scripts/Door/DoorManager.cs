using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public Door[] doorEntities;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            CheckDoorID(0);
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            CheckDoorID(1);
        }
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            CheckDoorID(2);
        }
        if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            CheckDoorID(3);
        }
        if(Input.GetKeyDown(KeyCode.Alpha5))
        {
            CheckDoorID(4);
        }
    }
    public void CheckDoorID(int id)
    {
        foreach(var door in doorEntities)
        {
            if(door.id != id)
            {
                continue;
            }
            door.OpenDoor();
        }
    }
}