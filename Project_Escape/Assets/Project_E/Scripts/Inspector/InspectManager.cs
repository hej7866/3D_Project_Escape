using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class InspectManager : SingleTon<InspectManager>
{
    // Object Name, Detail 화면에 출력한다.
    // UI - Image - BG, TMP - text

    [Header("Object Name UI")]
    public TextMeshProUGUI objectNameText;
    public GameObject objectNameBG;

    [Header("Object Detail UI")]
    public TextMeshProUGUI objectDetailText;
    public GameObject objectDetailBG;

    [Header("Timer")]
    public float onScreenTimer = 5f;
    public float fadeDuration = 1f;

    private CanvasGroup objectDetailCanvasGroup;
    private bool startTimer;
    private float timer;

    protected override void Awake()
    {
        base.Awake();
        objectDetailCanvasGroup = objectDetailBG.GetComponent<CanvasGroup>();
        objectNameBG.SetActive(false);
        objectDetailCanvasGroup.alpha = 0;
    }

    public void ShowName(string objectName, bool show)
    {
        if(show)
        {
            objectNameBG.SetActive(true);
            objectNameText.text = objectName;
        }
        else
        {
            objectNameBG.SetActive(false);
            objectNameText.text = "";
        }
    }

    public void ShowObjectDetail(string info)
    {
        objectDetailText.text = info;
        // BG 활성화, 비활성화
        // Fade In, Out
        // 코루틴
    }

}