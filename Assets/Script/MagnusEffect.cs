using UnityEngine;

public class MagnusEffect : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField] private Vector3 velocity, spin;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Kick();
            
            ApplyMagnusEffect();
            
        }
        
        
    }

    void Kick()
    {
        rb.linearVelocity = velocity;
        rb.angularVelocity = spin;
    }

    void ApplyMagnusEffect()
    {
        Vector3 magnusForce = Vector3.Cross(velocity, spin);
        
        rb.AddForce(magnusForce);
    }
}
