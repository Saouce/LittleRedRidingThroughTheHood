using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _body;
    public bool shouldIMove = true;

    private float horizontal;

    public float runSpeed = 20.0f;

    private void Start()
    {
        _body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (shouldIMove)
        {
            horizontal = Input.GetAxisRaw("Horizontal");
        }
    }

    private void FixedUpdate()
    {
        _body.linearVelocity = new Vector2(horizontal * runSpeed, 0f);
    }

    public void movePlayer()
    {
        shouldIMove = true;
    }

    public void stopPlayer()
    {
        shouldIMove = false;
        horizontal = 0f;
    }
}
