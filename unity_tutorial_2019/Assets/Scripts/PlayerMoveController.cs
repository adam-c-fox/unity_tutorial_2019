using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveController : MonoBehaviour
{
    private CharacterController charController;

    // Start is called before the first frame update
    void Start()
    {
        charController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // MOVEMENT
        float movementSpeed = 6.0F;
        float hInput = Input.GetAxis("Horizontal") * movementSpeed;
        float vInput = Input.GetAxis("Vertical") * -movementSpeed;

        Vector3 forwardMovement = transform.forward * hInput;
        Vector3 rightMovement = transform.right * vInput;
        Vector3 sum = forwardMovement + rightMovement;

        charController.SimpleMove(sum);
    }
}
