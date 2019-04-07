using UnityEngine;

public class ParticleManager : MonoBehaviour {
    public static ParticleManager instance;

    [SerializeField] GameObject deathParticle;
    [SerializeField] GameObject meleeFireParticle;
    [SerializeField] GameObject debuffParticle;

	// Use this for initialization
	void Start ()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);
        }
	}
	
	/// <summary>
    /// Creates Death Particle Effect
    /// </summary>
    /// <param name="myTransform">Transform of current object</param>
    public void DeathParticle(Transform myTransform)
    {
        GameObject particle = Instantiate(deathParticle, myTransform.position, myTransform.rotation);
        Destroy(particle, 5f);
    }

    /// <summary>
    /// Creates fire particle for 
    /// </summary>
    /// <param name="myTransform">Transform of object to spawn</param>
    public void MeleeParticle(Transform myTransform)
    {
        GameObject particle = Instantiate(meleeFireParticle, myTransform.position, myTransform.rotation);
        Destroy(particle, 0.25f);
    }

    /// <summary>
    /// Creates debuff particle
    /// </summary>
    /// <param name="myTransform">Transform where you want to spawn object</param>
    public void DebuffParticle(Transform myTransform)
    {
        GameObject particle = Instantiate(debuffParticle, myTransform.position, myTransform.rotation);
        Destroy(particle, 0.25f);
    }
}
