using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour
{

    public static UpgradeManager instance;
    public GameObject currentTower;
    //public MeleeTower currentMelee;
    public Text damage;
    public Text fireRate;
    public Text radius;
    public Text description;
    public Button sell;
    public Button upgrade;
    public GameObject displayTile;
    public GameObject upgradeCanvas;
    public Transform spawnPoint;
    public GameObject towerToDelete;
    public string desc;
    private GameObject towerUI;


    public static bool sellTowerBool = true;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }


    public void spawnObject()
    {

        if (towerUI != null)
        {
            Destroy(towerUI);
        }
        GameObject towerToDisplay = Instantiate(towerToDelete, spawnPoint.position, spawnPoint.rotation);
        towerUI = towerToDisplay;
    }

    public void displayInfo(GameObject myTower, string _description)
    {
        desc = _description;
        Debug.Log(myTower.GetComponent<BaseTower>().attackDamage);
        damage.text = "Damage: " + Mathf.RoundToInt(myTower.GetComponent<BaseTower>().attackDamage);
        fireRate.text = "Fire rate: " + Mathf.RoundToInt(myTower.GetComponent<BaseTower>().fireRate);
        radius.text = "Radius: " + Mathf.RoundToInt(myTower.GetComponent<BaseTower>().radius);
        description.text = "Description: " + _description;
        //towerToDisplay.GetComponent<BaseTower>().enabled = false;
    }

    public void SellTower()
    {
        if (sellTowerBool == true)
        {
            if (SceneManager.GetActiveScene().name == "TutorialScene")
            {
                if (TutorialManager.instance.sellTower != true)
                {
                    TutorialManager.instance.sellTower = true;
                    TutorialManager.instance.MoveToFreePlay();
                }
            }
            Debug.Log("sell tower");
            GameManager.instance.coins += currentTower.GetComponent<BaseTower>().price;
            currentTower.GetComponent<BaseTower>().node.GetComponent<TowerSpawn>().towerPrefab = null;
            currentTower = null;
            Destroy(towerToDelete);
        }


    }

    public void SellMelee()
    {
        if (sellTowerBool == true)
        {

            Debug.Log("sell tower");
            Debug.Log(currentTower.name);
            GameManager.instance.coins += currentTower.GetComponent<MeleeTower>().price;
            currentTower.GetComponent<MeleeTower>().node.GetComponent<TowerSpawn>().towerPrefab = null;
            currentTower = null;
            Destroy(towerToDelete);
        }
    }

    public void Sell()
    {
        if(currentTower.CompareTag("Melee Tower"))
        {
            SellMelee();
        }
        if(currentTower.CompareTag("Basic Tower") || currentTower.CompareTag("Debuff Tower") || currentTower.CompareTag("Powerful Tower"))
        {
            SellTower();
        }
    }

    public void UpgradeTower()
    {
        if (GameManager.instance.lastUpgrade == "Melee Tower")
        {
            currentTower.GetComponent<BaseTower>().Upgrade();
            displayInfo(currentTower.gameObject, desc);

        }
        else
        {
            currentTower.GetComponent<BaseTower>().Upgrade();
            displayInfo(currentTower.gameObject, desc);
        }
        if (SceneManager.GetActiveScene().name == "TutorialScene")
        {
            if (TutorialManager.instance.upgradeTower != true)
            {
                TutorialManager.instance.upgradeTower = true;
                TutorialManager.instance.MoveToStartWave2();
            }
        }
    }

    public void UpgradeMelee()
    {
        currentTower.GetComponent<MeleeTower>().Upgrade();
        displayInfo(currentTower.gameObject, desc);
    }

    public void Upgrade()
    {
        if (currentTower.CompareTag("Melee Tower"))
        {
            UpgradeMelee();
        }
        if (currentTower.CompareTag("Basic Tower") || currentTower.CompareTag("Debuff Tower") || currentTower.CompareTag("Powerful Tower"))
        {
            UpgradeTower();
        }
    }
    /// <summary>
    /// Disables Sell Button on upgrade cavnas
    /// </summary>
    public void DisableUpgradeButton()
    {
        upgrade.interactable = false;
    }
    /// <summary>
    /// Enables Button on upgrade canvas
    /// </summary>
    public void EnableUpgradeButton()
    {
        upgrade.interactable = true;
    }


}
