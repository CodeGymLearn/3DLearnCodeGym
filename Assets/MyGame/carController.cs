using UnityEngine;

public class carController : MonoBehaviour
{
    Transform car;
    void Awake()
    {
        car = GetComponent<Transform>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            car.position -= Vector3.right;
    }
}
