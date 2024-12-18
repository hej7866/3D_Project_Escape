using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteract
{
    Animator anim;

    [Header("Door Information")]
    public int id;
    public bool currentState = false;
    public bool canAccess = true;

    int openHashCode = Animator.StringToHash("Open");
    int closeHashCode = Animator.StringToHash("Close");

    public AudioClip openDoor;
    public AudioClip closeDoor;


    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void OpenDoor()
    {
        anim.Play(openHashCode);
        AudioManager.Instance.PlaySFX(openDoor);
    }
    public void CloseDoor()
    {
        anim.Play(closeHashCode);
        AudioManager.Instance.PlaySFX(closeDoor);
    }

    public void Interact()
    {
        DoorManager.Instance.CheckDoorId(id);
    }
}