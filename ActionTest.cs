using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
public class ActionTest : MonoBehaviour
{
    public SteamVR_Input_Sources handType;
    public SteamVR_Action_Boolean menu;
    public SteamVR_Action_Boolean grab;

    public bool GetMenuDown(){
        return menu.GetStateDown(handType);
    }
    public bool GetGribDown(){
        return grab.GetStateDown(handType);
    }
    void Update()
    {
        if(GetMenuDown()){
            print("ok"+handType);
            //Debug.Log("ok");
        }
         if(GetGribDown()){
            print("grib"+handType);
            //Debug.Log("ok");
        }
    }
}
