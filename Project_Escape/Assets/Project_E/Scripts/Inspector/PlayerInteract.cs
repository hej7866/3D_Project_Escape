using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    [Header("Raycast Info")]
    public float rayLength = 5f;
    private Camera _camera;
    private RaycastHit hit;
    [Header("Input Key")]
    public KeyCode keycode;

    public void Awake()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        if(Physics.Raycast(_camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f)),
            _camera.transform.forward, out hit, rayLength))
        {
            var door = hit.collider.GetComponent<Door>();
            
            if(door != null)
            {
                if(Input.GetKeyDown(keycode))
                {
                    DoorManager.Instance.CheckDoorId(door.id);
                    ExampleST.Instance.ShowDebug();
                    // DoorManager 문을 여세요
                    // DoorManager.CheckDoorId(door.id);
                    // Door Unlock 열쇠를 먹으면 -> CanAccess true
                    // DoorKey -> DoorManager DoorEntity 1번에 해당하는 열쇠를 먹었다.
                    // PlayerInter
                }
            }
        }
    }

    private void OnDrawGizmos()
    {
        if (!EditorApplication.isPlaying) return;

        Vector3 startPos = _camera.transform.position;
        Gizmos.color = Color.red;
        Gizmos.DrawLine(startPos, startPos + _camera.transform.forward * rayLength);
    }
}