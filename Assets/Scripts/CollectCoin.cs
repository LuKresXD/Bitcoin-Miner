using UnityEngine;



public class CollectCoin : MonoBehaviour
{
    [SerializeField] private int _value = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Pouch>(out var pouch))
        {
            pouch.AddMoney(_value);
            GetComponent<Collider2D>().enabled = false;
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<AudioSource>().Play();
            Destroy(gameObject, 1);
        }
    }
}
