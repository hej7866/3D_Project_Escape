using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class CubeDotween : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // sequence.Append(transform.DOMove(new Vector3(10,0,0), 1).SetRelative().SetLoops(-1, LoopType.Yoyo).SetEase(Ease.OutExpo))
        //     .Join(transform.DORotate(new Vector3(0, 90, 0), 1).SetLoops(2,LoopType.Restart).SetEase(Ease.OutExpo))
        //     .Join(transform.DOScale(new Vector3(1.2f, 1.2f, 1.2f), 1).SetLoops(3, LoopType.Incremental).SetEase(Ease.OutExpo));
        
        transform.DOMove(new Vector3(10,0,0), 1).SetRelative().SetLoops(-1, LoopType.Yoyo).SetEase(Ease.OutExpo);
        transform.DORotate(new Vector3(0, 90, 0), 1).SetLoops(2, LoopType.Restart).SetEase(Ease.OutExpo).OnComplete(DoScale);
        transform.DOShakePosition(3,3);
        // transform.DOScale(new Vector3(1.2f, 1.2f, 1.2f), 1).SetLoops(3, LoopType.Incremental).SetEase(Ease.OutExpo);

        // transform.DORotate(new Vector3(0, 90, 0), 1).SetLoops(2, LoopType.Restart).SetEase(Ease.OutExpo).OnComplete
        // (
        //     () => transform.DOScale(new Vector3(1.2f, 1.2f, 1.2f), 1).SetLoops(3, LoopType.Incremental).SetEase(Ease.OutExpo)
        // );


    }

    // Update is called once per frame
    void DoScale()
    {
        transform.DOScale(new Vector3(1.2f, 1.2f, 1.2f), 1).SetLoops(3, LoopType.Incremental).SetEase(Ease.OutExpo);
    }
}
