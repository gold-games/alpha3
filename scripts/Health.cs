﻿using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
	public int maxHealth;
	public int MaxHealth {
				get { return currentHealth; }
		}
	public void SetMaxHealth(int setAmount)
	{
			maxHealth = setAmount;
	}
	public int currentHealth;
	public void ModifyHealth(int modifyAmount)
	{
<<<<<<< HEAD
		currentHealth += modifyAmount;
		if (currentHealth < 1) {
			currentHealth = 0;
			Application.LoadLevel ("gameover");
=======
				currentHealth += modifyAmount;
				if (currentHealth < 1) {
						currentHealth = 0;
>>>>>>> origin/master
					
			//player dies code
		} else if (currentHealth > maxHealth) {
			currentHealth = maxHealth;
			if (currentHealth <= 0) {
				Application.LoadLevel ("gameover");
			
				//player dies code
			}
		}
	}

	void Start()
	{
		SetMaxHealth (100);
		ModifyHealth (100);
	
	}
}
