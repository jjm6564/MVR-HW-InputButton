using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Drawing : MonoBehaviour
{
    //Raycast value
    RaycastHit hit;
    private GameObject parent;
    private GameObject HMD;
    private float maxDistance = 15f;
    public GameObject dot;
    public LayerMask layerMask;
    public SteamVR_Action_Boolean grab;
    public GameObject handType;

    void Update()
    {
        parent = GameObject.FindWithTag("MemoPad");
        HMD = GameObject.FindWithTag("Player");
        RayCasting();
    }
    void RayCasting()
    {
       

        if (grab.state == true)
        {
            Debug.DrawRay(handType.transform.position, handType.transform.forward*maxDistance, Color.red);
            if(Physics.Raycast(handType.transform.position,handType.transform.forward,out hit,maxDistance,layerMask)==true)
            {
                GameObject draw = Instantiate(dot, hit.point, parent.transform.rotation);
                draw.transform.parent = parent.transform;
                draw.transform.rotation = parent.transform.rotation;

                draw.transform.localPosition -= new Vector3(-0.001f,-0.001f,-0.001f);
                //draw.transform.position = draw.transform.position + new Vector3(-0.001f, -0.001f, -0.001f);
                
                draw.SetActive(true);
                
                
                
                Debug.Log("ray2");
            }

        }
    }

}