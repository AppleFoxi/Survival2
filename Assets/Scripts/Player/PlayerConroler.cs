using UnityEngine;
using UnityEngine.InputSystem;
using YG;

public class PlayerConroler : MonoBehaviour
{
    [Tooltip("Inventory")]
    [SerializeField] private GameObject _inventory;
    private bool _isInventoryOpen = false;
    [Tooltip("Input reference")]
    public MovementActions input;


    private void Awake()
    {
        input = new MovementActions();
    }
    private void OnEnable()
    {
        input.Enable();
        input.Gameplay.Inventory.performed += OpenInventory;
    }
    private void OnDisable()
    {
        input.Disable();
        input.Gameplay.Inventory.performed -= OpenInventory;
    }




    private void OpenInventory(InputAction.CallbackContext obj)
    {
        if(_isInventoryOpen)
        {
            _inventory.SetActive(false);
            if (YG2.envir.isDesktop)
            {
                Cursor.lockState = CursorLockMode.Locked;
            }
            _isInventoryOpen = false;
        }
        else
        {
            _inventory.SetActive(true);
            if (YG2.envir.isDesktop)
            {
                Cursor.lockState = CursorLockMode.Confined;
            }
            _isInventoryOpen = true;
        }
    }
   

  }
