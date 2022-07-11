using System;


public class AVLTree
{
    
    
    /// <summary>
    /// 顺时针（右右旋）
    /// </summary>
    /// <param name="node"></param>
    /// <returns></returns>
    public AVLNode LL_rotate(AVLNode node)
    {
        //node 为离操作结点最近的失衡结点
        AVLNode parent, son;

        //获取失衡结点的父节点
        parent = node.parent;

        //获取失衡结点的左孩子
        son = node.lchild;

        //设置son结点的右孩子和根节点连接
        if (son.rchild != null)
        {
            node.lchild = son.rchild;
            son.rchild.parent = node;
        }
        

        //设置son结点的右孩子为根节点
        son.rchild = node;
        
        update_depth(son);

        return son;
    }

    #region 辅助代码

    /// <summary>
    /// 更新当前深度
    /// </summary>
    /// <param name="node"></param>
    void update_depth(AVLNode node)
    {
        if (node == null)
        {
            return;
        }
        else
        {
            int depth_Lchild = get_balance(node.lchild);
            int depth_Rchild = get_balance(node.rchild);
            node.depth = Math.Max(depth_Lchild, depth_Rchild) + 1;
        }
    }

    /// <summary>
    /// 获取当前结点的深度
    /// </summary>
    /// <param name="node"></param>
    /// <returns></returns>
    int get_balance(AVLNode node)
    {
        if (node == null)
        {
            return 0;
        }

        return node.depth;
    }

    /// <summary>
    /// 返回当前平衡因子
    /// </summary>
    /// <param name="node"></param>
    /// <returns></returns>
    int is_balance(AVLNode node)
    {
        if (node == null)
        {
            return 0;
        }
        else
        {
            return get_balance(node.lchild) - get_balance(node.rchild);
        }
    }

    #endregion
}