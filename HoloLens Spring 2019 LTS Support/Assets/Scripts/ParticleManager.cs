using UnityEngine;

public class ParticleManager : MonoBehaviour {
    public static ParticleManager instance;

    [SerializeField] GameObject deathParticle;

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
}
