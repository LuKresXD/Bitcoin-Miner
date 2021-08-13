using UnityEngine;


public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D _rbody;
    private SpriteRenderer _spriteRender;
    private Animator _animator;
    public float Speed = 5;
    public float Jump = 5;
    public Vector2 _extraVector = Vector2.zero;

    private void Start()
    {
        _rbody = GetComponent<Rigidbody2D>();
        _spriteRender = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();
    }

    private int jumpCommand = 0;
    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            jumpCommand = 1;
        }
        if (Input.GetButton("Horizontal"))
        {
            _animator.Play("walk@player");
            _spriteRender.flipX = Input.GetAxis("Horizontal") < 0;
        } else {
            _animator.Play("idle@player");
        }
    }

	private void FixedUpdate()
	{
        var velocity = _rbody.velocity;

        velocity.x = Input.GetAxis("Horizontal") * Speed + _extraVector.x;
        if (jumpCommand > 0)
        {
            jumpCommand -= 1;
            velocity.y = Jump;
        }
        velocity.y += _extraVector.y;

        _rbody.velocity = velocity;
	}
}
