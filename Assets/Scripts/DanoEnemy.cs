using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DanoEnemy : MonoBehaviour
{

    [Header("Animation")]
    [SerializeField]
    Animator animator;

    [SerializeField]
    Animator animator2;

    [SerializeField]
    Animator animator3;

    [SerializeField]
    Animator animator4;

    [SerializeField]
    Animator animator5;

    [SerializeField]
    Animator animator6;

    [SerializeField]
    Animator animator7;
    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Enemy"))
        {
            animator.SetBool("isCatch", true);
            animator2.SetBool("isCatch", true);
            animator3.SetBool("isCatch", true);
            animator4.SetBool("isCatch", true);
            animator5.SetBool("isCatch", true);
            animator6.SetBool("isCatch", true);
            animator7.SetBool("isCatch", true);
            SceneManager.LoadScene("GameOver");
        }

    }
}
