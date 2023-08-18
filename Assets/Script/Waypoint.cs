using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] bool isplaceable;
    [SerializeField] GameObject Towerprefb;
    void OnMouseDown()
    {
        if (isplaceable)
        {
            Instantiate(Towerprefb, transform.position, Quaternion.identity);
            isplaceable = false;
        }
      
    }
}
