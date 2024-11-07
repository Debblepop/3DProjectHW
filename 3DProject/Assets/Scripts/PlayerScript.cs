using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Camera Eyes;
    public Rigidbody RB;
    public float MouseSensitivity = 5;
    public float WalkSpeed = 30;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;

    }

    // Update is called once per frame
    void Update()
    {
        float xRot = Input.GetAxis("Mouse X") * MouseSensitivity;
        float yRot = -Input.GetAxis("Mouse Y") * MouseSensitivity;
        transform.Rotate(0, xRot, 0);
        Eyes.transform.Rotate(yRot, 0, 0);

        if (WalkSpeed > 0)
        {
            Vector3 move = Vector3.zero;
            if (Input.GetKey(KeyCode.W))
            {
                move += transform.forward;
            }
            if (Input.GetKey(KeyCode.S))
            {
                move -= transform.forward;
            }
            if (Input.GetKey(KeyCode.A))
            {
                move -= transform.right;
            }
            if (Input.GetKey(KeyCode.D))
            {
                move += transform.right;
            }
            RB.velocity = move;
        }
    }
}
