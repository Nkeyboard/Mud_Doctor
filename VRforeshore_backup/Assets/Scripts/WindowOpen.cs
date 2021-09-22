using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowOpen : MonoBehaviour
{
    public Animator animator;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("GameController")){
            Debug.Log("��Ҵٸ�");
            animator.SetBool("isOpen", true);

        }    
    }
}
