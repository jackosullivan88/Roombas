using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TankControls : MonoBehaviour
{
    public balloonScript bs;
    public SphereCollider balloon;
    private CharacterController character;
    public float moveSpeed = 6.0f;
    public float turnSpeed = 90f;
    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDir = new Vector3();

        transform.Rotate(0, Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime, 0);
        moveDir = transform.forward * 1 * moveSpeed;

        if (Input.GetAxis("Vertical") == -1)
        {
            moveSpeed = 3.0f;
        }
        else if (Input.GetAxis("Vertical") == 1)
        {
            moveSpeed = 12.0f;
        }
        else
            moveSpeed = 6.0f;

        Vector3 up01 = Vector3.up;
        up01 *= 0.1f;

        character.Move((moveDir * Time.deltaTime) - (up01));

        if (bs.hasCollided)
        {
            Debug.Log("Collision with Hazard");
        }
    }

}
