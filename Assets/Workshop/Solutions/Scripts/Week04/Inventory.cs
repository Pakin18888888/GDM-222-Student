using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Solution {
    public class Inventory : MonoBehaviour
    {
        public Dictionary<ItemData,int> inventory = new Dictionary<ItemData, int>();

        // ���������
        public void AddItem(ItemData item, int amount)
        {
            if (inventory.ContainsKey(item))
            {
                inventory[item] += amount;
            }
            else
            {
                inventory.Add(item,amount);
            }
            Debug.Log("Added " + amount +" " + item.ItemName + "Total : " + inventory[item]);
        }

        // ź�����
        public void UseItem(ItemData item, int amount)
        {
            if (HasItem(item, amount))
            {
                inventory[item] -= amount;
                if(inventory[item] <= 0)
                {
                    inventory.Remove(item);
                    Debug.Log($"Remove {item.ItemName} form Inventory");
                }
                else
                {
                    Debug.Log("Remove " + amount + " " + item.ItemName + " totle " + inventory[item]);
                }
            }
            else
            {
                Debug.Log("Cannot remove " + item.ItemName + ". not found");
            }
        }
        public bool HasItem(ItemData item, int amount)
        {
            return inventory.ContainsKey(item) && inventory[item] >= amount;
        }
        // ��Ǩ�ͺ�ӹǹ�����
        public int GetItemCount(ItemData item)
        {
           
            return 0;
        }

        // �ʴ���¡�÷�����㹤�ѧ
        public void PrintInventory()
        {
           
        }
    }
}

