using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using UnityEngine;



public class Trigger : MonoBehaviour
{

    protected Thread thread;
    protected SerialThreadLines serialThread;

    public string portName = "COM4";


    public int baudRate = 9600;


    public int reconnectionDelay = 1000;


    public int maxUnreadMessages = 1;

    public int ScoreCount = 0;

    public string Scored = "Score";


    // Start is called before the first frame update
    protected void Start()
    {
        GetComponent<BoxCollider2D>();
    }


    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ScoreCount++;
            Debug.Log("Trigger");

            Scored = "Score";

            SendSerialMessage(Scored);

        }
    }


    void OnEnable()
    {
        serialThread = new SerialThreadLines(portName,
                                             baudRate,
                                             reconnectionDelay,
                                             maxUnreadMessages);
        thread = new Thread(new ThreadStart(serialThread.RunForever));
        thread.Start();
    }
    public void SendSerialMessage(string message)
    {
        serialThread.SendMessage(message);
    }


}

