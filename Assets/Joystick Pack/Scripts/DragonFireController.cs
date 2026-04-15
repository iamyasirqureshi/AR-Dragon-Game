using UnityEngine;

public class DragonFireController : MonoBehaviour
{
    public ParticleSystem fireEffect;

    public void StartFire()
    {
        if (fireEffect != null)
            fireEffect.Play();
    }

    public void StopFire()
    {
        if (fireEffect != null)
            fireEffect.Stop();
    }
}
    