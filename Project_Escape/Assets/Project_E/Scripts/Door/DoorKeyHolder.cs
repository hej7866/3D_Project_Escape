using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKeyHolder : MonoBehaviour, IInteract
{
    public Doorkey doorKey;

    public void Interact()
    {
        DoorManager.Instance.UnlockDoor(doorKey.doorId);
    }
}
