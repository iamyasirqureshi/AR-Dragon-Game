using UnityEngine;

public class DragonAttack : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void StartFire()
    {
        Debug.Log("Fire button pressed");
        anim.SetBool("Fire", true);
    }


    public void StopFire()
    {
        anim.SetBool("Fire", false);
    }
}
