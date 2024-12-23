using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class UITween : MonoBehaviour
{
    Image image;

    public float endValue = 0f;
    public float duration = 1f;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();

        image.DOFade(endValue, duration).OnComplete
        (
            () => image.DOFade(1 - endValue, duration + 5)
        );
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
