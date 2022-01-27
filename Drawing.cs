using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Drawing : MonoBehaviour
{
    //Raycast value
    RaycastHit hit;
    public GameObject parent;
    private float maxDistance = 15f;
    public GameObject dot;
    public LayerMask layerMask;
    public SteamVR_Action_Boolean grab;
    public GameObject handType;

    void Update()
    {
        RayCasting();
    }
    void RayCasting()
    {

        if (grab.state == true)
        {
            Debug.Log("ray1");
            Debug.DrawRay(handType.transform.position, handType.transform.forward, Color.red);
            if(Physics.Raycast(handType.transform.position,handType.transform.forward,out hit,maxDistance,layerMask)==true)
            {
                hit.transform.GetComponent<MeshRenderer>().material.color = Color.red;
                // GameObject draw = Instantiate(dot, hit.point, parent.transform.rotation);
                // draw.transform.parent = parent.transform;
                // draw.transform.position = draw.transform.position + new Vector3(0, 0, -0.001f);
                Debug.Log("ray2");
            }

        }
    }

}