using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Config")]
    [SerializeField] private PlayerStats stats;

    public PlayerStats Stats => stats;

    private PlayerAnimations animations;
    public PlayerMana PlayerMana { get; private set; }

    private void Awake()
    {
        animations = GetComponent<PlayerAnimations>();
        PlayerMana = GetComponent<PlayerMana>();
    }

    public void ResetPlayer()
    {
        stats.ResetPlayer();
        animations.ResetPlayer();
        PlayerMana.ResetMana();
    }
}