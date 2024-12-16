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
            var interactable = hit.collider.GetComponent<IInteract>();

            if(interactable != null && Input.GetKeyDown(keycode))
            {
                interactable.Interact();
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