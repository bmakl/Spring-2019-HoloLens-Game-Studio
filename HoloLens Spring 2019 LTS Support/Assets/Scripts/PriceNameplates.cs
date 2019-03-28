using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PriceNameplates : MonoBehaviour {

    public Text basic;
    public Text melee;
    public Text powerful;
    public Text debuff;

    // Use this for initialization
    void Start ()
    {

        if(this.gameObject.CompareTag("ScythePlate"))
        {
            melee.text = GameManager.instance.meleeCost.ToString();
        }
        if (this.gameObject.CompareTag("TombstonePlate"))
        {
            basic.text = GameManager.instance.baseCost.ToString();
        }
        if (this.gameObject.CompareTag("HolyWrathPlate"))
        {
            powerful.text = GameManager.instance.powerfulCost.ToString();
        }
        if (this.gameObject.CompareTag("CursedPlate"))
        {
            debuff.text = GameManager.instance.debuffCost.ToString();
        }

    }
	
}
