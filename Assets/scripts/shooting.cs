using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Camera cam;
    public AmmoManager ammoManager;

    private RaycastHit hit;
    private Ray ray;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (ammoManager.UseAmmo())
            {
                ray = cam.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.tag.Equals("NPC"))
                    {
                        Destroy(hit.collider.gameObject);
                        Debug.Log("You are gonna die");
                    }
                }
            }
            else
            {
                Debug.Log("Out of ammo!");
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Reloading...");
            ammoManager.ReloadAmmo();
        }
    }
}
