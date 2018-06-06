using System;
using _669.Trim_a_Binary_Search_Tree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TreeNode root = new TreeNode(1) { left=new TreeNode(0),right = new TreeNode(2) };
            Solution sln = new Solution();
            var result = sln.TrimBST(root, 1, 2);
            TreeNode ans = new TreeNode(1) { left = null, right = new TreeNode(2) };
            Assert.AreEqual(JsonConvert.SerializeObject(result), JsonConvert.SerializeObject(ans));
        }
    }
}
