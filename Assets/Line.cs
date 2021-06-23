using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{   
    LineRenderer m_lineRenderer;
    [SerializeField] GameObject m_start;
    [SerializeField] GameObject m_end;

    // Start is called before the first frame update
    void Start()
    {
        var m_lineRenderer = GetComponent<LineRenderer>();

        var position = new Vector3[]
        {
            new Vector3(m_start.transform.position.x, m_start.transform.position.y, 0),
            new Vector3(m_end.transform.position.x, m_end.transform.position.y, 0),
        };

        m_lineRenderer.startWidth = 0.1f;
        m_lineRenderer.endWidth = 0.1f;

        m_lineRenderer.SetPositions(position);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
