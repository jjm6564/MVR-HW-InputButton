using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
public class ActionTest : MonoBehaviour
{
    public SteamVR_Input_Sources leftHand;
    public SteamVR_Action_Boolean menu;
    public GameObject canvas;
    private static GameObject istCanvas;
    public GameObject HMD;
    //--------------------------------------------------------------
    public GameObject rightHand;
    public SteamVR_Action_Boolean grab;
    private GameObject dot;
    public LayerMask layerMask;
    private RaycastHit hit;
    private float maxDistance = 10f;
    //=======================================================
    public bool GetMenu()
    {
        return menu.GetState(leftHand);
    }
    void Awake()
    {
        istCanvas = Instantiate(canvas);
        istCanvas.transform.parent = HMD.transform;
        istCanvas.layer = 3;
    }

    void Start()
    {
        istCanvas.SetActive(false);
    }
    void Update()
    {
        if (GetMenu())
        {
            //print("menu" + handType);
            istCanvas.SetActive(true);
        }
        else
        {
            istCanvas.SetActive(false);
        }
    }
}
