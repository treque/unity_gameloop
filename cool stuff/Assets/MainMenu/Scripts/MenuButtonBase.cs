using UnityEngine;

public abstract class MenuButtonBase : MonoBehaviour
{
    [SerializeField] MenuButtonController MenuButtonController; // maybe make this private like the animator and get from parent
    [SerializeField] uint Index;
    Animator _animator;
    public virtual void Start()
    {
        _animator = GetComponent<Animator>();
    }
    public virtual void Update()
    {
        if (MenuButtonController.SelectedIndex == Index)
        {
            _animator.SetBool("isSelected", true);
            if (Input.GetAxis("Submit") == 1) _animator.SetBool("isPressed", true);
            else if (_animator.GetBool("isPressed"))
            {
                _animator.SetBool("isPressed", false);
            }
        }
        else
        {
            _animator.SetBool("isSelected", false);
        }
    }
    protected abstract void ExecutePressAction();
}
