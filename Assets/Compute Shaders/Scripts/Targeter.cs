using UnityEngine;
public class Targeter : MonoBehaviour
{
    Camera cam;
    Vector3 pos;

    [SerializeField] Transform target;

    void Start()
    {
        cam = Camera.main;
    }
    void Update()
    {
        pos = cam.WorldToScreenPoint(target.position);
        Ray ray = cam.ScreenPointToRay(pos);
        Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);
    }
}
