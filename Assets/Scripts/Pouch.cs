using UnityEngine;


public class Pouch : MonoBehaviour
{
	[SerializeField] private int _money = 0;
	public void AddMoney(int toAdd)
	{
		_money += toAdd;
	}
}