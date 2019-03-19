using UnityEngine;

public class weaponswitching : MonoBehaviour
{

    public int selecectedWeapon = 0;

    // Start is called before the first frame update
    void Start()
    {
        SelectWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        int previousSelectedWeapon = selecectedWeapon;

        if (Input.GetAxis("Mouse Scrollwheel") > 0f)
        {
            if (selecectedWeapon >= transform.childCount - 1)
                selecectedWeapon = 0;
            else
                selecectedWeapon++;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (selecectedWeapon <= 0)
                selecectedWeapon = transform.childCount - 1;
            else
                selecectedWeapon--;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selecectedWeapon = 0;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >=2)
        {
            selecectedWeapon = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3) && transform.childCount >= 3)
        {
            selecectedWeapon = 2;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4) && transform.childCount >= 4)
        {
            selecectedWeapon = 3;
        }

        if (previousSelectedWeapon != selecectedWeapon)
        {
            SelectWeapon();
        }
    }
    void SelectWeapon()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == selecectedWeapon)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(false);
            i++;
        }
    }
}
