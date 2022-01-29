using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;
  public class move : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    int scored;
    public Text textscore;
    public GameObject panelgameover;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float hmove = CrossPlatformInputManager.GetAxis("Horizontal");
        float vmove = CrossPlatformInputManager.GetAxis("Vertical");
        Vector3 movement = new Vector3(hmove, 0, vmove) * speed;
        rb.AddForce(movement);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "coins")
        {
            Destroy(other.gameObject);
            scored += 5;
            textscore.text = "Score=" + scored;
        }
        if (other.tag == "enemy")
        {

            rb.velocity = Vector3.zero;
            rb.isKinematic = true;
            panelgameover.SetActive(true);
        }
    }
    public void playagain()
    {
        SceneManager.LoadScene("game");
    }
    public void back()
    {
        SceneManager.LoadScene("mainmenu");
    }
    public void mainmenu()
    {
        SceneManager.LoadScene("mainmenu");
    }

}
    
      
    

      
    