using UnityEngine;


public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D _rbody;
    public float Speed = 5;
    public float Jump = 5;

    private void Start()
    {
        _rbody = GetComponent<Rigidbody2D>();
    }

    private int jumpCommand = 0;
    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            jumpCommand = 1;
        }
    }

	private void FixedUpdate()
	{
        var velocity = _rbody.velocity;

        velocity.x = Input.GetAxis("Horizontal") * Speed;
        if (jumpCommand > 0)
        {
            jumpCommand -= 1;
            velocity.y = Jump;
        }

        _rbody.velocity = velocity;
	}
}
