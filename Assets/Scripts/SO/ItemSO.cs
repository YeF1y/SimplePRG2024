using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class ItemSO : ScriptableObject
{
    public int id;
    public new string name;
    public ItemType itemType;
    public string description;
    public List<Property> propertyList;//属性列表
    public Sprite icon;//图标
    public GameObject prefab;
}

public enum ItemType//物品类型
{
    Weapon,
    Consumable
}

[Serializable]//标识为可序列化
public class Property//属性
{
    public PropertyType propertyType;
    public int value;
    public Property()
    {

    }
    public Property(PropertyType propertyType, int value)
    {
        this.propertyType = propertyType;
        this.value = value;
    }
}

public enum PropertyType//属性类型
{
    HPValue,
    EnergyValue,
    MentalValue,
    SpeedValue,
    AttackValue
}