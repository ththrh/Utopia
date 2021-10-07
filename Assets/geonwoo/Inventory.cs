﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{


    public static Inventory instance;
    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
    }



    public delegate void OnSlotCountChange(int val);
    public OnSlotCountChange onSlotCountChange;

    public List<Item> items = new List<Item>();
    public delegate void OnChangeItem();
    public OnChangeItem onChangeItem;



    private int slotCnt;
    public int SlotCnt
    {
        get => slotCnt;
        set
        {
            slotCnt = value;
            onSlotCountChange.Invoke(slotCnt);
        }
    }

    void Start()
    {
        SlotCnt = 4;
    }


    public bool AddItem(Item _item)
    {
        if (items.Count<SlotCnt)
        {
            items.Add(_item);
            if(onChangeItem!=null)
            onChangeItem.Invoke();
            return true;
        }
        return false;
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("FieldItem"))
        {
            FieldItems fieldItems = collision.GetComponent<FieldItems>();
            if (AddItem(fieldItems.GetItem()))
                fieldItems.DestroyItem();

        }
    }


}
