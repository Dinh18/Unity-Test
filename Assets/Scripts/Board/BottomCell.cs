using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomCell : MonoBehaviour
{
    public int bottom;
    public Item item;

    public bool isEmpty => item == null;

    public void SetUp(int bottom)
    {
        this.bottom = bottom;
    }
    public void SetItem(Item item)
    {
        this.item = item;
    }
}
