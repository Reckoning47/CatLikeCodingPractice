using UnityEngine;

public class TestPatrol : MonoBehaviour
{
    public float speed = 1.0f;
    public Transform pointA;
    public Transform pointB;

    Transform target;

    private void Start()
    {
        target = pointA;
    }
    void Update()
    {
        // Move our position a step closer to the target.
        float step = speed * Time.deltaTime; // calculate distance to move
        
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        if (Vector3.Distance(transform.position, target.position) < 0.001f)
        {
            if(target == pointB)
            {
                target = pointA;
            }
            else
            {
                target = pointB;
            }
        }
    }
}
