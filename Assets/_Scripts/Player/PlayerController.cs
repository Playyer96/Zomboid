using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public static Vector3 Position;

    [SerializeField] private PlayerData playerData;
    public GameObject character;

    private Rigidbody rb;
    private float screenWidth;

    float delta;
    Vector3 movement;
    bool isGrounded;

    // Start is called before the first frame update
    void Start () {
        screenWidth = Screen.width;
        rb = character.GetComponent<Rigidbody> ();
    }

    // Update is called once per frame
    void Update () {
        delta = Time.deltaTime;

        int i = 0;
        while (i < Input.touchCount) {
            if (Input.GetTouch (i).position.x > screenWidth / 2) {
                // TODO: Move right
                transform.Rotate (new Vector3 (0, 1, 0) * delta * playerData.rotationSpeed);
            }
            if (Input.GetTouch (i).position.x < screenWidth / 2) {
                // TODO: Move left
                transform.Rotate (new Vector3 (0, -1, 0) * delta * playerData.rotationSpeed);
            }
            i++;
        }
    }
    void FixedUpdate () {
#if UNITY_EDITOR
        Movement (Input.GetAxis ("Horizontal"));
#endif

        // if (isGrounded)
        rb.velocity = transform.forward * delta * playerData.speed;
        Position = rb.position;
    }

    // handles the movement in the Editor
    void Movement (float horizontalInput) {
        transform.Rotate (new Vector3 (0, horizontalInput, 0) * delta * playerData.rotationSpeed);
    }
}