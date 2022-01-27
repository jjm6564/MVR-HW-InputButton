using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
public class ActionTest : MonoBehaviour
{
    //public Object leftController;
    public SteamVR_Input_Sources leftHand;
    public SteamVR_Action_Boolean menu;
    public GameObject canvas;
    private GameObject istCanvas;
    public GameObject HMD;
    //--------------------------------------------------------------
    public GameObject rightHand;
    public SteamVR_Action_Boolean grab;
    public GameObject dot;
    public LayerMask layerMask;
    private RaycastHit hit;
    private float maxDistance = 10f;
    //=======================================================

    public bool GetMenu()
    {
        return menu.GetState(leftHand);
    }
    // public bool GetGribDown()
    // {
    //     return grab.GetStateDown(leftHand);
    // }
    // void casting()
    // {
    //     if (grab.state==true)
    //     {
    //             Debug.Log("first");
    //         Debug.DrawRay(rightHand.transform.position,rightHand.transform.forward*maxDistance,Color.red);
    //         if(Physics.Raycast(rightHand.transform.position,transform.forward,out hit,maxDistance,layerMask)==true){
    //             Debug.Log("boom");
    //         }

    //     }
    // }

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
            // canvas.SetActive(GetMenu());
        }
        else
        {
            istCanvas.SetActive(false);
        }
        // if (GetGribDown())
        // {
        //     //print("grib"+handType);
        //     // casting();
        // }
    }
}
