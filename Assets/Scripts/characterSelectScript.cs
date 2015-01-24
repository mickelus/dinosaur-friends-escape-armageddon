using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class characterSelectScript : MonoBehaviour {

	public Canvas[] openPanels;
	public Canvas[] activePanels;
	public Image[] characterImages;
	public Text[] characterTexts;
	public Sprite[] characterSprites;
	public string[] characterNames;

	public Text startText;

	bool[] hasJoined;
	int[] selectedCharacter;

	// Use this for initialization
	void Start () {
		hasJoined = new bool[4];
		selectedCharacter = new int[4];

		for (int i = 0; i < selectedCharacter.Length; i++) {
			updateCharacter (i);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Joystick1Button16)) {
			enableCharacterSelect(0);
		}
		if(Input.GetKeyDown(KeyCode.Joystick2Button16)) {
			enableCharacterSelect(1);
		}
		if(Input.GetKeyDown(KeyCode.Joystick3Button16)) {
			enableCharacterSelect(2);
		}
		if(Input.GetKeyDown(KeyCode.Joystick4Button16)) {
			enableCharacterSelect(3);
		}

		if(Input.GetKeyDown(KeyCode.Joystick1Button17)) {
			disableCharacterSelect(0);
		}
		if(Input.GetKeyDown(KeyCode.Joystick2Button17)) {
			disableCharacterSelect(1);
		}
		if(Input.GetKeyDown(KeyCode.Joystick3Button17)) {
			disableCharacterSelect(2);
		}
		if(Input.GetKeyDown(KeyCode.Joystick4Button17)) {
			disableCharacterSelect(3);
		}

		if(Input.GetKeyDown(KeyCode.Joystick1Button7)) {
			changeCharacter(0, false);
		}
		if(Input.GetKeyDown(KeyCode.Joystick2Button7)) {
			changeCharacter(1, false);
		}
		if(Input.GetKeyDown(KeyCode.Joystick3Button7)) {
			changeCharacter(2, false);
		}
		if(Input.GetKeyDown(KeyCode.Joystick4Button7)) {
			changeCharacter(3, false);
		}

		if(Input.GetKeyDown(KeyCode.Joystick1Button8)) {
			changeCharacter(0, true);
		}
		if(Input.GetKeyDown(KeyCode.Joystick2Button8)) {
			changeCharacter(1, true);
		}
		if(Input.GetKeyDown(KeyCode.Joystick3Button8)) {
			changeCharacter(2, true);
		}
		if(Input.GetKeyDown(KeyCode.Joystick4Button8)) {
			changeCharacter(3, true);
		}

		if (Input.GetKeyDown (KeyCode.JoystickButton9)) {
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
			// TODO: send dataz
		}
	}
	

}
