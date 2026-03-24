using UnityEngine;
using UnityEngine.InputSystem;

public class MagnusSoccerKick : MonoBehaviour
{
    public float kickForce = 500f;
    public float spinAmount = 50f;
    public float magnusStrength = 0.1f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            KickBall();
        }
    }

    void FixedUpdate()
    {
        ApplyMagnusEffect();
    }

    void KickBall()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        rb.AddForce(transform.forward * kickForce);

        rb.AddTorque(Vector3.up * spinAmount);
    }

    void ApplyMagnusEffect()
    {
        Vector3 magnusForce = Vector3.Cross(rb.angularVelocity, rb.velocity);
        rb.AddForce(magnusForce * magnusStrength);
    }
}