using UnityEngine;


public class TeleportPlayer : MonoBehaviour
{
	[SerializeField] private Transform _target;
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.TryGetComponent<PlayerControl>(out var player))
		{
			player.transform.position = _target.position;
		}
	}
}
