using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
public class test : MonoBehaviour
{
    public Object leftController;
    public SteamVR_Input_Sources handType;
    public SteamVR_Action_Boolean menu;
    public SteamVR_Action_Boolean grab;
    public GameObject canvas;
    private GameObject istCanvas;
    
    public GameObject HMD;
    public GameObject cube;

    public bool GetMenu(){
        return menu.GetState(handType);
    }
    public bool GetGribDown(){
        return grab.GetStateDown(handType);
    }
 
    void Awake()
    {
        //Instantiate (canvas,new Vector3(0,0,3),Quaternion.Euler(-90f,0f,0f));
        //Instantiate(canvas,new Vector3(0,0,2),canvas.transform.rotation).transform.parent = HMD.transform;
        // istCanvas = Instantiate(canvas,canvas.transform.localPosition,canvas.transform.rotation);
        // istCanvas.transform.parent = HMD.transform;
      //Instantiate(canvas,canvas.transform.localPosition,canvas.transform.rotation).transform.parent = HMD.transform;
         istCanvas = Instantiate(canvas);
        istCanvas.transform.parent = HMD.transform;

    }
    void Start()
    {
        istCanvas.SetActive(false);
        cube.SetActive(false);
    }
    void Update()
    {
        if(GetMenu()){
             print("menu" + handType);
            istCanvas.SetActive(true);
           // canvas.SetActive(GetMenu());
        }
        else {
            istCanvas.SetActive(false);
        }
         if(GetGribDown()){
            print("grib"+handType);
            //Debug.Log("ok");
        }
    }
}
