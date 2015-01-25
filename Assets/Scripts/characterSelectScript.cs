using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnitySampleAssets.CrossPlatformInput;

public class characterSelectScript : MonoBehaviour {

	public Canvas[] openPanels;
	public Canvas[] activePanels;
	public Image[] characterImages;
	public Text[] characterTexts;
	public Sprite[] characterSprites;
	public string[] characterNames;

	public bool player1_button_fire = false;
	public bool player2_button_fire = false;

	public Text startText;

	public int numPlayers = 2;


	bool[] hasJoined;
	int[] selectedCharacter;

	// Use this for initialization
	void Start () {
		hasJoined = new bool[numPlayers];
		selectedCharacter = new int[numPlayers];

		for (int i = 0; i < selectedCharacter.Length; i++) {
			updateCharacter (i);
		}
	}
	
	// Update is called once per frame
	void Update () {

		float sensitivity = 0.9f;

		if(CrossPlatformInputManager.GetButtonDown("Player 1 A")) {
			enableCharacterSelect(0);
		}
		if(CrossPlatformInputManager.GetButtonDown("Player 2 A")) {
			enableCharacterSelect(1);
		}
		/*
		if(CrossPlatformInputManager.GetButtonDown("Player 3 A")) {
			enableCharacterSelect(2);
		}
		if(CrossPlatformInputManager.GetButtonDown("Player 4 A")) {
			enableCharacterSelect(3);
		}
		*/

		if(CrossPlatformInputManager.GetButtonDown("Player 1 B")) {
			disableCharacterSelect(0);
		}
		if(CrossPlatformInputManager.GetButtonDown("Player 2 B")) {
			disableCharacterSelect(1);
		}
		/*
		if(CrossPlatformInputManager.GetButtonDown("Player 3 B")) {
			disableCharacterSelect(2);
		}
		if(CrossPlatformInputManager.GetButtonDown("Player 4 B")) {
			disableCharacterSelect(3);
		}
		 */

		if(Mathf.Abs (CrossPlatformInputManager.GetAxis("Player 1 Horizontal")) < sensitivity) {
			player1_button_fire = false;
		}

		if(CrossPlatformInputManager.GetAxis("Player 1 Horizontal") > sensitivity && player1_button_fire == false) {
			changeCharacter(0, false);
			player1_button_fire = true;
		}

		if(CrossPlatformInputManager.GetAxis("Player 1 Horizontal") < -sensitivity && player1_button_fire == false) {
			changeCharacter(0, true);
			player1_button_fire = true;
		}






		if(Mathf.Abs (CrossPlatformInputManager.GetAxis("Player 2 Horizontal")) < sensitivity) {
			player2_button_fire = false;
		}
		
		if(CrossPlatformInputManager.GetAxis("Player 2 Horizontal") > sensitivity && player2_button_fire == false) {
			changeCharacter(1, false);
			player2_button_fire = true;
		}
		
		if(CrossPlatformInputManager.GetAxis("Player 2 Horizontal") < -sensitivity && player2_button_fire == false) {
			changeCharacter(1, true);
			player2_button_fire = true;
		}
	

		/*
		if(CrossPlatformInputManager.GetButtonDown("Player 3 Left")) {
			changeCharacter(2, false);
		}
		if(CrossPlatformInputManager.GetButtonDown("Player 4 Left")) {
			changeCharacter(3, false);
		}*/

		/*
		if(CrossPlatformInputManager.GetButtonDown("Player 3 Right")) {
			changeCharacter(2, true);
		}
		if(CrossPlatformInputManager.GetButtonDown("Player 4 Right")) {
			changeCharacter(3, true);
		}*/

		if (CrossPlatformInputManager.GetButtonDown("Player Start")) {
			startGame();
		}

	}

	void enableCharacterSelect(int index) {
		if (!hasJoined [index]) {
			hasJoined [index] = true;
			openPanels [index].enabled = false;
			activePanels [index].enabled = true;
		}

		startText.enabled = hasAnyoneJoined();
	}

	void disableCharacterSelect(int index) {
		if (hasJoined [index]) {
			hasJoined [index] = false;
			openPanels [index].enabled = true;
			activePanels [index].enabled = false;
		}

		startText.enabled = hasAnyoneJoined();
	}

	void changeCharacter(int index, bool increase) {
		if (selectedCharacter [index] <= 0 && !increase) {
			selectedCharacter [index] = characterSprites.Length - 1;
		} else if (selectedCharacter [index] >= characterSprites.Length - 1 && increase) {
			selectedCharacter [index] = 0;
		} else if (increase) {
			selectedCharacter [index]++;
		} else {
			selectedCharacter [index]--;
		}

		updateCharacter (index);

	}
	void updateCharacter(int index) {
		print (index);
		characterTexts[index].text = characterNames [selectedCharacter [index]];
		characterImages[index].sprite = characterSprites [selectedCharacter [index]];
	}

	bool hasAnyoneJoined() {

		foreach (bool joined in hasJoined) {
			if(joined) {
				return true;
			}
		}
		return false;
	}

	void startGame() {
		if (hasAnyoneJoined ()) {
			PlayerPrefs.SetInt("character1", hasJoined[0] ? selectedCharacter[0] : -1);
			PlayerPrefs.SetInt("character2", hasJoined[1] ? selectedCharacter[1] : -1);
			Application.LoadLevel("Level1");
		}
	}
	

}
