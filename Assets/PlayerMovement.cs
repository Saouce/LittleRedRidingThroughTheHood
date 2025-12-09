using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _body;

    private float horizontal;

    public float runSpeed = 20.0f;

    private void Start()
    {
        _body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        _body.linearVelocity = new Vector2(horizontal * runSpeed, 0f);
    }
}
