using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class tergetLoceted : MonoBehaviour
{

    [SerializeField] Transform weapon;
    [SerializeField] float range = 15f;
    Transform terget;
    [SerializeField] ParticleSystem projectileParticles;
    // Start is called before the first frame update
    void Start()
    {
        terget = FindObjectOfType<Enimy>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        AimWapen();
        FindClosestTarget();
    }
    void AimWapen()
    {
        float targetDistance = Vector3.Distance(transform.position, terget.position);
        weapon.LookAt(terget);
        if (targetDistance < range)
        {
            Attack(true);
        }
        else
        {
            Attack(false);
        }
    }

    void FindClosestTarget()
    {
        Enimy[] enemies = FindObjectsOfType<Enimy>();
        Transform closestTarget = null;
        float maxDistance = Mathf.Infinity;

        foreach (Enimy enemy in enemies)
        {
            float targetDistance = Vector3.Distance(transform.position, enemy.transform.position);

            if (targetDistance < maxDistance)
            {
                closestTarget = enemy.transform;
                maxDistance = targetDistance;
            }
        }
        terget = closestTarget;
    }
    void Attack(bool isActive)
    {
        var emissionModule = projectileParticles.emission;
        emissionModule.enabled = isActive;
    }
}
