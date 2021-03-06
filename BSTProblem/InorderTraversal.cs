﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BSTProblem
{
    class InorderTraversal
    {
        public static void Start()
        {
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);

            Console.WriteLine("Inorder Traversal");
            Inorder(root);
            Console.WriteLine();
        }

        public static void Inorder(Node root)
        {
            if (root == null)
            {
                return;
            }

            Inorder(root.left);
            Console.Write(root.data+" ");
            Inorder(root.right);
            
        }
    }
}
