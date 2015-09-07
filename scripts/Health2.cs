using UnityEngine;
using System.Collections;

public class Health2 : MonoBehaviour {

	public int maxHealth2;
	public int MaxHealth2 {
		get { return currentHealth2; }
	}
	public void SetMaxHealth(int setAmount)
	{
		maxHealth2 = setAmount;
	}
	public int currentHealth2;

	public void ModifyHealth(int modifyAmount)
	{
		currentHealth2 += modifyAmount;
		if (currentHealth2 < 1) {
			currentHealth2 = 0;
			//player dies code
		} else if (currentHealth2 > maxHealth2) {
			currentHealth2 = maxHealth2;
		}
	}
	void Start()
	{
		SetMaxHealth (100);
		ModifyHealth (100);
		
	}
}

