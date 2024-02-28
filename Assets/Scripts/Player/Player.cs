using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Config")] [SerializeField] private PlayerStats stats;

    [Header("Test")] public ItemHealthPotion HealthPotion;
    public ItemManaPotion ManaPotion;
    public PlayerStats Stats => stats;
    public PlayerAttack PlayerAttack { get; private set; }
    private PlayerAnimations animations;
    public PlayerMana PlayerMana { get; private set; }
    public PlayerHealth PlayerHealth { get; private set; }

    private void Awake()
    {
        animations = GetComponent<PlayerAnimations>();
        PlayerHealth = GetComponent<PlayerHealth>();
        PlayerAttack= GetComponent<PlayerAttack>();
        PlayerMana = GetComponent<PlayerMana>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (HealthPotion.UseItem())
            {
                Debug.Log("Using Health Potion");
            }

            if (ManaPotion.UseItem())
            {
                Debug.Log("Using Mana Potion");
            }
        }
    }

    public void ResetPlayer()
    {
        stats.ResetPlayer();
        animations.ResetPlayer();
        PlayerMana.ResetMana();
    }
}