
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI diamondText;

    // Start is called before the first frame update
    void Start()
    {
        diamondText = GetComponent<TextMeshProUGUI>();
        
    }

    public void UpdateDiamondText(PlayerInventory playerInventory)
    {

        if (playerInventory.NumberOfDiamonds.ToString() == ("3"))
        {

            diamondText.text = "Well done! now you can return home!";

        }

        else
        {
            string text = ("Oh no! your shuttle crash landed on an unknown planet, find your items to repair it and go home \n " + playerInventory.NumberOfDiamonds.ToString() + " / 3 Items Found");
            diamondText.text = text;
        }
        
    }
}
