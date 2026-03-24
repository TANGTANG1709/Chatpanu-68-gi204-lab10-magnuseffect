using UnityEngine;
// เพิ่มบรรทัดนี้เหมือนเดิมครับ
using UnityEngine.InputSystem;

public class TorqueRotate : MonoBehaviour
{
    public float torqueForce = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Keyboard.current != null && Keyboard.current.dKey.isPressed)
        {
            rb.AddTorque(Vector3.forward * torqueForce);
        }
    }
}