using UnityEngine;

public class Tree : MonoBehaviour
{
    public Camera camera;

    void Update()
    {
        // Always stay facing towards the camera
        transform.LookAt((transform.position + camera.transform.rotation * Vector3.down), (camera.transform.rotation * Vector3.forward));
    }
}
