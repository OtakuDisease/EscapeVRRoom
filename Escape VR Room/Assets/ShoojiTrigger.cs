
using UnityEngine;

public class ShoojiTrigger : MonoBehaviour
{
    [SerializeField] Animator LeftShoojiAnimator;

    void OnTriggerEnter(Collider other)
    {
        
        LeftShoojiAnimator.SetTrigger("OpenShoojis");
    }
        
    }

