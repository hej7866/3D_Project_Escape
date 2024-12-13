using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    Animator anim;
    [Header("Door Information")]
    public int id;
    public bool currentState = false;
    public bool canAccess = true;
    

    int openHashCode = Animator.StringToHash("Open");
    int closeHashCode = Animator.StringToHash("Close");
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            OpenDoor();
        }

        if(Input.GetKeyDown(KeyCode.G))
        {
            CloseDoor();
        }
    }

    public void OpenDoor()
    {
        anim.Play(openHashCode);
    }
    public void CloseDoor()
    {
        anim.Play(closeHashCode);
    }
}