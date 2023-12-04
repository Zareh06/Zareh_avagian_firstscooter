using UnityEngine;
using TMPro;

public class AmmoManager : MonoBehaviour
{
    public int maxAmmo = 10;
    private int currentAmmo;

    public TextMeshProUGUI ammoText;

    // Start is called before the first frame update
    void Start()
    {
        currentAmmo = maxAmmo;
        UpdateAmmoText();
    }

    public bool UseAmmo()
    {
        if (currentAmmo > 0)
        {
            currentAmmo--;
            UpdateAmmoText();
            return true;
        }
        else
        {
            return false;
        }
    }

    public void ReloadAmmo()
    {
        currentAmmo = maxAmmo;
        UpdateAmmoText();
    }

    void UpdateAmmoText()
    {
        if (ammoText != null)
        {
            ammoText.text = "Ammo: " + currentAmmo;
        }
    }
}
