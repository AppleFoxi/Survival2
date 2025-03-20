using UnityEngine;
[CreateAssetMenu(fileName = "New Weapon", menuName = "Stats/Create New Weapon")]
public class WeaponPriceInfo : ScriptableObject
{
    public int Price = 10;
    public Sprite IconWeapon;
    public int id = 0;

    public int[] StatsWeapon; // 1 ����, 2 ��������, 3 ��������

}

