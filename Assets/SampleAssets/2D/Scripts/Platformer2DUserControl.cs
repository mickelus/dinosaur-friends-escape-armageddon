using UnityEngine;
using UnitySampleAssets.CrossPlatformInput;

namespace UnitySampleAssets._2D
{

	[RequireComponent(typeof (PlatformerCharacter2D))]
	[AddComponentMenu("Character2D")]
    public class Platformer2DUserControl : MonoBehaviour
    {
        private PlatformerCharacter2D character;
        private bool jump;

		public string playerControlHorizontal;
		public string playerControlVertical;
		public string playerControlJump;
		public string playerControlUse;

        private void Awake()
        {
            character = GetComponent<PlatformerCharacter2D>();
        }

        private void Update()
        {
            if(!jump) {
            // Read the jump input in Update so button presses aren't missed.
				//jump = Input.GetButtonDown(playerControlJump);
				jump = CrossPlatformInputManager.GetButtonDown(playerControlJump);
			}
        }

        private void FixedUpdate()
        {
            // Read the inputs.
            //bool crouch = Input.GetKey(KeyCode.LeftControl);
			float h = Input.GetAxis(playerControlHorizontal);
            // Pass all parameters to the character control script.
            character.Move(h, false, jump);
            jump = false;

			//Physics2D.IgnoreLayerCollision (8, 9, rigidbody2D.velocity.y > 0);
        }
    }
}