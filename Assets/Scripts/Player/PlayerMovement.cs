using Mirror;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement :  NetworkBehaviour
{
    private Rigidbody Rigidbody;

    [SerializeField]
    private float MovementSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (!isLocalPlayer) return;
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Rigidbody.MovePosition(transform.position + move * Time.deltaTime * MovementSpeed);
    }
}
