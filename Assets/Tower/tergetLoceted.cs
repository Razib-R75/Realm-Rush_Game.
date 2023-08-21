using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class tergetLoceted : MonoBehaviour
{

    [SerializeField] Transform weapon;
   
    Transform terget;
    // Start is called before the first frame update
    void Start()
    {
        terget = FindObjectOfType<EnemyMover1>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        AimWapen();
    }
    void AimWapen()
    {
        weapon.LookAt(terget);
    }
}
