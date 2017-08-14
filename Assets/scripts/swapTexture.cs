using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class swapTexture : MonoBehaviour {
	public Image imageGO;
	public Sprite[] sprites;
	public int currentSprite;


	public void ClickToChangeFront()
	{
		currentSprite++;
		currentSprite %= sprites.Length;
		imageGO.sprite = sprites [currentSprite];

		if (currentSprite > 50)
		{
		
			currentSprite = 1;
		}
	}


	public void ClickToChangeBack()
	{
		currentSprite--;
		currentSprite %= sprites.Length;
		imageGO.sprite = sprites [currentSprite];

		if (currentSprite < 1)
		{

			currentSprite = 50;
		}
	}
}
