using UnityEngine;

public class DoorAnim : MonoBehaviour
{
    Animator anim;
    [SerializeField] Transform playerTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && Vector3.Distance(transform.position, playerTransform.position) < 3)
        {
            anim.SetTrigger("openDoor");
            anim.SetBool("isDoorClosed", !anim.GetBool("isDoorClosed"));
        }
    }
}
