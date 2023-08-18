using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnimyMover : MonoBehaviour
{

    [SerializeField] List<Waypoint> path = new List<Waypoint>();
 
    [SerializeField][Range(0f, 5f)] float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {


        StartCoroutine(FlowPath());

    }

    // Update is called once per frame
    IEnumerator FlowPath()
    {
        foreach (Waypoint waypoint in path)
        {
            
          
            Vector3 startPosition = transform.position;
            Vector3 endPosition = waypoint.transform.position;
            float travelPercent = 0f;

            transform.LookAt(endPosition);

            while (travelPercent < 1f)
            {
                travelPercent += Time.deltaTime * speed;
                transform.position = Vector3.Lerp(startPosition, endPosition, travelPercent);
                yield return new WaitForEndOfFrame();

            }
        }
    }
}
