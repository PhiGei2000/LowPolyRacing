using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

    public KeyCode KeyAccelerate = KeyCode.W;
    public KeyCode KeyBreak = KeyCode.S;
    public KeyCode KeyLeft = KeyCode.A;
    public KeyCode KeyRight = KeyCode.D;

    public float MaxSpeed;

    private Rigidbody rigidbody;    


    // Start is called before the first frame update
    void Start() {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update() {
        Vector3 direction = Vector3.zero;
        float acceleration = 0.001f;

        if (Input.GetKey(KeyAccelerate))
            direction += Vector3.forward;

        if (Input.GetKey(KeyBreak))
            direction -= Vector3.forward;

        rigidbody.velocity += direction * acceleration * Time.frameCount;
    }
}
