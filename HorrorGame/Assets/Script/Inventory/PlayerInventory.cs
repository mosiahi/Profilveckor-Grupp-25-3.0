using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public GameObject ErrorSign;
    public InventoryObjects inventory;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        DisplayInventory.AccessCanPickUp = false;
        Debug.Log("Yes42342");
        if (inventory.Container.Count == 15 && collision.gameObject.GetComponent<InventoryItems>())
        {
            ErrorSign.SetActive(true);
        }
        else
        {
            ErrorSign.SetActive(false);
        }

        var item = collision.GetComponent<InventoryItems>();
        if (item && inventory.Container.Count <= 14)
        {
            inventory.AddItem(item.myitem, 1, 0);
           
            Destroy(collision.gameObject);
        }
        DisplayInventory.AccessCanPickUp = true;
    }
    public void OnTriggerExit2D(Collider2D collision)
    {

        ErrorSign.SetActive(false);
    }
    private void OnApplicationQuit()
    {
        inventory.Container.Clear();
    }

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        inventory.Container[0].myItem.UseItem();
    //    }
    //}
}
