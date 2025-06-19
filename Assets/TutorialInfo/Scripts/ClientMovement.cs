using System;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.InputSystem;
using StarterAssets;


public class ClientMovement : NetworkBehaviour
{
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private StarterAssetsInputs _starterAssetsInputs;
    [SerializeField] private ThirdPersonController _thirdPersonController;

    private void Awake()
    {
        _playerInput.enabled = false;
        _starterAssetsInputs.enabled = false;
        _thirdPersonController.enabled = false;
    }

    public override void OnNetworkSpawn()
    {
        base.OnNetworkPostSpawn();

        if (IsOwner)
        {
        _playerInput.enabled = true;
        _starterAssetsInputs.enabled = true;
        _thirdPersonController.enabled = true;
        }
    }
}
