using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class RecipieBookUnitChange : MonoBehaviour
{
    [Header("Unit Settings")]
    public GameObject[] unitButtons; // Prefab UnitButton
    public Sprite unitBackgroundSprite;
    public Sprite frameSprite;
    public Sprite[] unitSprites;

    [Header("Ingredient Settings")]
    public GameObject IngredientButton; // IngredientButton
    public Sprite ingredientBackgroundSprite;
    //public Sprite[] ingredientSprites;
    
    void Start()
    {
        if (unitButtons.Length != 11 || unitSprites.Length != 11)
        {
            Debug.LogWarning("Make sure you have 11 buttons and 11 unit images assigned!");
            return;
        }

        for (int i = 0; i < unitButtons.Length; i++)
        {
            Transform buttonTransform = unitButtons[i].transform;

            // Find child image components
            Image background = buttonTransform.Find("Background").GetComponent<Image>();
            Image frame = buttonTransform.Find("Frame").GetComponent<Image>();
            Image unitImage = buttonTransform.Find("UnitImage").GetComponent<Image>();

            // Assign the same background and frame to all buttons
            if (background != null) background.sprite = unitBackgroundSprite;
            if (frame != null) frame.sprite = frameSprite;

            // Assign unique unit images
            if (unitImage != null && i < unitSprites.Length)
            {
                unitImage.sprite = unitSprites[i];
            }
        }
    }

    void Update()
    {
        
    }
}
