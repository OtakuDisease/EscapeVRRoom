using UnityEngine;

public class ShoojiTrigger1 : MonoBehaviour
{
    [SerializeField] Animator LeftShoojiAnimator;

    void OnTriggerEnter(Collider other)
    {

        LeftShoojiAnimator.SetTrigger("OpenShoojis");
    }

}

