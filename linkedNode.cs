using System;

public class SingleLinkedNode
{
	public SingleLinkedNode(){}
    public SingleLinkedNode next;
    public String value;
}


public class DoubleLinkedNode
{
    public DoubleLinkedNode(){}
    public DoubleLinkedNode(String value)
    {
        this.value = value;
    }
    public DoubleLinkedNode next;
    public DoubleLinkedNode previous;
    public String value;
}
