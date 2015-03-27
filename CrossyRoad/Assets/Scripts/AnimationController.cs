/****** Creator: Tony Wijaya ******/
/****** Created in 2014 ******/

/*** Script
 * Name: AnimationController.cs
 * Description: Controller for Character Animations such as transition parameters

 ***/

using UnityEngine;
using System.Collections;

public class AnimationController : MonoBehaviour {

	private Animator animator;
	private CharController charController;

	void Start () {
		animator = gameObject.GetComponent<Animator> ();
		charController = gameObject.GetComponentInParent<CharController>();
	}

	void Update () {
		animator.SetBool ("Jump", charController.justJump);
		animator.SetBool ("Dead1", charController.justDie1);
		animator.SetBool ("Dead2", charController.justDie2);
	}
}
