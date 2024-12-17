using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectItem : MonoBehaviour
{
    public InspectData inspectData;

    public void ShowObjectName()
    {
        if(inspectData.showObjectName)
        {
            InspectManager.Instance.ShowName(inspectData.objectName, inspectData.showObjectName);
        }
    }

    public void ShowDetails()
    {
        if(inspectData.showObjectDetails)
        {
            // InspectManager
        }
    }


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            ShowObjectName();
        }
    }

}