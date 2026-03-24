using UnityEngine;
using UnityEngine.InputSystem;

public class AngularVelocity : MonoBehaviour
{
    public float spinSpeed = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Keyboard.current != null && Keyboard.current.aKey.isPressed)
        {
            rb.angularVelocity = new Vector3(0, spinSpeed, 0);
        }
        else
        {
            rb.angularVelocity = Vector3.zero;
        }
    }
}