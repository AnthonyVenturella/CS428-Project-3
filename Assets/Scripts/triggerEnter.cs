using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerEnter : MonoBehaviour {

    private bool inTrigger = false;
    public Animator animator;
    public AudioSource newSound;

    public GameObject pointer;


    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player" && inTrigger == false) {
            Debug.Log("entered trigger volume");
            inTrigger = true;

            animator.SetTrigger("transition1");
            newSound.Play();
            StartCoroutine(sitdown());
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.tag == "Player" && inTrigger == true) {
            Debug.Log("exited trigger volume");
            inTrigger = false;
        }
    }

    IEnumerator sitdown() {
        yield return new WaitForSeconds(2);
        animator.SetTrigger("transition2");
        Debug.Log("Sit");
    }
}
