using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] bool isplaceable;
    [SerializeField] Tower Towerprefb;


    public bool Isplaceable{get{return isplaceable;}}
    
    void OnMouseDown()
    {
        if (isplaceable)
        {
            bool isPlaced =  Towerprefb.CreateTower(Towerprefb,transform.position);
          //  Instantiate(Towerprefb, transform.position, Quaternion.identity);
            isplaceable = !isPlaced;
        }
      
    }
}
