using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
public class ActionTest : MonoBehaviour
{
    public Object leftController;
    public SteamVR_Input_Sources handType;
    public SteamVR_Action_Boolean menu;
    public SteamVR_Action_Boolean grab;
    public GameObject canvas;

    public bool GetMenu(){
        return menu.GetState(handType);
    }
    public bool GetGribDown(){
        return grab.GetStateDown(handType);
    }
 
    void Awake()
    {
        //Instantiate (canvas,new Vector3(0,0,3),Quaternion.Euler(-90f,0f,0f));
        Instantiate(canvas,new Vector3(0,0,2),canvas.transform.rotation);

    }
    void Start()
    {
        canvas.SetActive(true);

    }
    void Update()
    {
        if(GetMenu()){
            print("ok"+handType);
           // canvas.SetActive(GetMenu());
        }
        // else{
        //     canvas.SetActive(GetMenu());
        // }
         if(GetGribDown()){
            print("grib"+handType);
            //Debug.Log("ok");
        }
        
    }
}
