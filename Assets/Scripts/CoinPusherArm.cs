using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CoinPusherArm : MonoBehaviour
{
    private Sequence sequence;
    public float startZ;
    public float endZ;
    public float time = 1;
    // Start is called before the first frame update
    void Start()
    {
        sequence = DOTween.Sequence();
        sequence.Append(transform.DOLocalMoveZ(endZ, 1f));
        sequence.Append(transform.DOLocalMoveZ(startZ, 1f));
        sequence.SetLoops(-1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
