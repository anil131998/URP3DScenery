using UnityEngine;

public class movecamera : MonoBehaviour
{
    [SerializeField]private float movespeed;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");
        float Ascend = Input.GetKey(KeyCode.Space) ? 1 : 0;
        float Descend = Input.GetKey(KeyCode.LeftControl) ? -1 : 0;

        Vector3 moveDir = (Camera.main.transform.forward * VerticalInput) + (Camera.main.transform.right * HorizontalInput);
        moveDir = moveDir + new Vector3(0, Ascend, 0) + new Vector3(0, Descend, 0);

        Debug.Log(moveDir);

        transform.Translate(moveDir.normalized * movespeed * Time.deltaTime);
    }

}
