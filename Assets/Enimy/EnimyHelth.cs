using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnimyHelth : MonoBehaviour
{
    [SerializeField] int maxHitPoint = 5;

    [SerializeField]int currentHitpoint;
    Enimy enimy;
  
    void OnEnable()
    {
        currentHitpoint = maxHitPoint;
    }

    // Update is called once per frame
    void Update()
    {
        enimy = GetComponent<Enimy>();
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
            gameObject.SetActive(false);
            enimy.RewardGold();
        }
    }
}
