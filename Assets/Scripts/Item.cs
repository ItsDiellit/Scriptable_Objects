using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public ScriptableItem itemInfo;

    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        spriteRenderer.sprite = itemInfo.itemSprite;
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collider)
    {
        InventoryManager.instance.AddItem(itemInfo);
        Destroy(gameObject);
    }
}
