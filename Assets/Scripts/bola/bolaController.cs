using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolaController : MonoBehaviour
{
    public float horizontalMove;
    public float verticalMove;

    private Vector3 playerInput;

    public CharacterController player;
    public float playerSpeed;
    public float jumpforce;
    public float fuerzaSalto;
    float velVertical;

    public Camera mainCamera;
    private Vector3 camForward;
    private Vector3 camRigth;
    private Vector3 movePlayer;

    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");

        playerInput = new Vector3(horizontalMove, 0, verticalMove);
        playerInput = Vector3.ClampMagnitude(playerInput, 1);

        camDirection();

        movePlayer = playerInput.x * camRigth + playerInput.z * camForward;
        player.Move(movePlayer * playerSpeed * Time.deltaTime);
    }

    void camDirection()
    {
        camForward = mainCamera.transform.forward;
        camRigth = mainCamera.transform.right;

        camForward.y = 0;
        camRigth.y = 0;

        camForward = camForward.normalized;
        camRigth = camRigth.normalized;
    }

}
