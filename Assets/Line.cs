using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{   
    LineRenderer m_lineRenderer;
    [SerializeField] GameObject m_start;
    [SerializeField] GameObject m_end;
    float a = -0.5f;
    float b = 5.1666f;
    float c = -7.3333f;

    // Start is called before the first frame update
    void Start()
    {
        //m_lineRenderer = GetComponent<LineRenderer>();

        //var position = new Vector3[]
        //{
        //    new Vector3(m_start.transform.position.x, m_start.transform.position.y, 0),
        //    new Vector3(m_end.transform.position.x, m_end.transform.position.y, 0),
        //    new Vector3(0, 0, 0),
        //};

        //var position2 = new Vector3[]
        //{
        //    new Vector3(0, 0, 0),
        //    new Vector3(2, 1, 0),
        //};

        //m_lineRenderer.SetPositions(position);
        ////m_lineRenderer.SetPositions(position2);

        //m_lineRenderer.startWidth = 0.1f;
        //m_lineRenderer.endWidth = 0.1f;


        for (float x = 0; x <= 5; x++)
        {
            GameObject go = new GameObject();
            var line = go.AddComponent<LineRenderer>();
            var y = (a * (x * x) + (b * x) + c);
            var pos = new Vector3[]{
            //new Vector3(go.transform.position.x, 0, 0),
            //new Vector3(go.transform.position.x + x, ((a * (go.transform.position.x * go.transform.position.x)) + (b * go.transform.position.x) + c), 0),
            new Vector3(x, y + x, 0),
            new Vector3(x + 1, y + 1 + x, 0),
        };
            line.startWidth = 0.1f;//線分の太さ
            line.endWidth = 0.1f;
            line.positionCount = pos.Length;//与えた点の数
            line.SetPositions(pos);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
