using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnimyHelth : MonoBehaviour
{
    [SerializeField] int maxHitPoint = 5;

    [SerializeField]int currentHitpoint;
    // Start is called before the first frame update
    void Start()
    {
        currentHitpoint = maxHitPoint;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnParticleCollision(GameObject other)
    {
        processHit();
    }

   void processHit()
    {
        currentHitpoint--;
        if(currentHitpoint<= 0)
        {
            Destroy(gameObject);
        }
    }
}
