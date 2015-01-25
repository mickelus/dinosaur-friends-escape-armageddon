using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Fader : MonoBehaviour
{
	public float fadeSpeed;          // Speed that the screen fades to and from black.
	public bool sceneStarting = true;      // Whether or not the scene is still fading in.
	public Image target;	
	
	void Update ()
	{
		// If the scene is starting...
		if(sceneStarting) {
			FadeToClear ();
		} else {
			FadeToBlack ();
		}
	}
	
	
	public void FadeToClear ()
	{
		target.color = Color.Lerp(target.color, Color.clear, fadeSpeed * Time.deltaTime);
	}
	
	
	public void FadeToBlack ()
	{
		target.color = Color.Lerp(target.color, Color.black, fadeSpeed * Time.deltaTime);
	}

}