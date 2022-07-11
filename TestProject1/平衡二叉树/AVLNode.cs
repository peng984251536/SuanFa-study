public class AVLNode
{
    public int val;
    
    public int depth;
    
    public AVLNode parent;
    public AVLNode lchild;
    public AVLNode rchild;

    public AVLNode(int val = 0)
    {
        parent = null;
        depth = 0;
        lchild = rchild = null;
        this.val = val;
    }
}