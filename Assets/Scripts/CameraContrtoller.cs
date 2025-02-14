using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraContrtoller : MonoBehaviour
{
    public GameObject carCam;

    public GameObject coinCam;

    private int curCamIndex = 0;
    
    public Button changeView;
    // Start is called before the first frame update
    void Start()
    {
        coinCam.SetActive(true);
        carCam.SetActive(false);
        curCamIndex = 0;
        changeView.onClick.AddListener(ChangeViewCam);
    }


    void ChangeViewCam()
    {
        if (curCamIndex==0)
        {
            coinCam.SetActive(false);
            carCam.SetActive(true);
            curCamIndex = 1;
        }
        else
        {
            coinCam.SetActive(true);
            carCam.SetActive(false);
            curCamIndex = 0;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
