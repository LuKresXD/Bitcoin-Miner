using UnityEngine;


public class PushZone : MonoBehaviour
{
	[SerializeField] private Vector2 _pushVector = Vector2.up;
	private void OnTriggerEnter2D(Collider2D collision) 
	{
		if (collision.TryGetComponent<PlayerControl>(out var player))
		{
			player._extraVector += _pushVector;
		}
	}
    private void OnTriggerExit2D(Collider2D collision) 
	{
		if (collision.TryGetComponent<PlayerControl>(out var player))
		{
			player._extraVector -= _pushVector;
		}
	}
}
